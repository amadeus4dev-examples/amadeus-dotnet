using System;
using System.IO;
using System.Net;
using System.Text;
using amadeus;
using amadeus.exceptions;
using Newtonsoft.Json;
using resources;

/// <summary>
/// A memoized Access Token, with the ability to auto-refresh when needed.
/// </summary>
public class AccessToken
{
    // Renew the token 10 seconds earlier than required,
    // just to account for system lag
    private const long TOKEN_BUFFER = 10000;

    // An instance of the API client
    private HTTPClient client;

    // The access token value
    private string accessToken { get; set; } = null;

    // The (UNIX) expiry time of this token
    private long expiresAt { get; set; }

    /// <summary>
    /// Initializes a new instance of the AccessToken class.
    /// </summary>
    /// <param name="client">Client.</param>
    public AccessToken(HTTPClient client)
    {
        this.client = client;
    }

    /// <summary>
    /// Creates a Bearer header using the cached Access Token.
    /// </summary>
    /// <returns>The bearer token.</returns>
    public string getBearerToken()
    {
        try
        {
            lazyUpdateAccessToken();
            return "Bearer " + accessToken;
        } catch (ResponseException re)
        {
            throw re;
        }
    }

    // Loads the access token if it's still null
    // or has expired.
    private void lazyUpdateAccessToken()
    {
        try
        {
            if (needsRefresh())
            {
                updateAccessToken();
            }
        }
        catch (ResponseException re)
        {
            throw re;
        }
    }

    // Fetches the access token and then parses the resuling values.
    private void updateAccessToken()
    {
        try
        {
            Response response = fetchAccessToken();
            storeAccessToken(response.result);
        }
        catch (ResponseException re)
        {
            throw re;
        }
    }

    // Checks if this access token needs a refresh.
    private bool needsRefresh()
    {
        bool isNull = accessToken == null;
        bool expired = (GetCurrentMilli() + TOKEN_BUFFER) > expiresAt;
        return isNull || expired;
    }

    // Fetches a new Access Token using the credentials from the client
    private Response fetchAccessToken()
    {
        try
        {
            Configuration config = client.configuration;
            return client.unauthenticatedRequest(
                Constants.POST,
                Constants.AUTH_URL,
                Params.with(Constants.GRANT_TYPE, Constants.CLIENT_CREDENTIALS)
                      .and(Constants.CLIENT_ID, config.clientId)
                      .and(Constants.CLIENT_SECRET, config.clientSecret),
               null
            );
        }
        catch (ResponseException re)
        {
            Console.WriteLine(re.ToString());
            throw re;
        }
    }

    // Store the fetched access token and expiry date
    private void storeAccessToken(dynamic result)
    {
        this.accessToken = (string) result.GetValue(Constants.ACCESS_TOKEN);
        int expiresIn = (int) result.GetValue(Constants.EXPIRES_IN);
        this.expiresAt = GetCurrentMilli() + expiresIn * 1000L;
    }



private static long GetCurrentMilli()
    {
        DateTime Jan1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        TimeSpan javaSpan = DateTime.UtcNow - Jan1970;
        return (long) javaSpan.TotalMilliseconds;
    }

}
