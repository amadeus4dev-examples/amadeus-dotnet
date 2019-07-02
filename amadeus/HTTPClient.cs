using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using amadeus.resources;
using resources;
using resources.exceptions;

namespace amadeus
{
    /// <summary>
    /// The HTTP part of the Amadeus API client. See the Amadeus class for
    /// more details on initialization.
    /// </summary>
    public class HTTPClient
    {
        /// <summary>
        /// A cached copy of the Access Token. It will auto refresh for every bearerToken (if needed)
        /// </summary>
        internal AccessToken accessToken;

        /// <summary>
        /// The configuration for this API client.
        /// </summary>
        /// <value>Configuration</value>
        public Configuration configuration { get; }

        internal HTTPClient(Configuration configuration)
        {
            accessToken = new AccessToken(this);
            this.configuration = configuration;
        }

        /// <summary>
        /// A helper module for making generic GET _requests calls. It is used by
        /// every namespaced API GET method.
        /// <see cref="get(string, Params)"/>  
        /// </summary>
        /// <returns>Response</returns>
        /// <param name="path">Path.</param>
        public virtual Response get(string path)
        {
            return request(Constants.GET, path, null);
        }

        /// <summary>
        /// <para>
        /// A helper module for making generic GET _requests calls. It is used by
        /// every namespaced API GET method.
        /// </para>
        /// <code>
        /// amadeus.referenceData.urls.checkinLinks.get(Params.with("airline", "1X"));
        /// </code>
        /// <para>
        /// It can be used to make any generic API call that is automatically
        /// authenticated using your API credentials:
        /// </para>
        /// <code>
        /// amadeus.get("/v2/reference-data/urls/checkin-links", Params.with("airline", "1X"))
        /// </code>
        /// </summary>
        /// <returns>A Response object containing the status code, body, and parsed data.</returns>
        /// <param name="path">path The full path for the API call</param>
        /// <param name="_params">The optional GET params to pass to the API</param>
        public virtual Response get(string path, Params _params)
        {
            return request(Constants.GET, path, _params);
        }

        /// <summary>
        /// A helper module for making generic POST _requests calls. It is used by
        /// every namespaced API POST method.
        /// <see cref="post(string, Params)"/>
        /// </summary>
        /// <returns>A response object</returns>
        /// <param name="path">Path.</param>
        public virtual Response post(string path)
        {
            return request(Constants.POST, path, null);
        }

        /// <summary>
        /// <para>
        /// A helper module for making generic POST _requests calls. It is used by
        /// every namespaced API POST method.
        /// </para>
        /// <code>
        /// amadeus.foo.bar.post(Params.with("airline", "1X"));
        /// </code>
        /// <para>
        /// It can be used to make any generic API call that is automatically
        /// authenticated using your API credentials:
        /// </para>
        /// <code>
        /// amadeus.post("/v1/foo/bar", Params.with("airline", "1X"));
        /// </code>
        /// </summary>
        /// <returns>A Response object containing the status code, body, and parsed data.</returns>
        /// <param name="path">The full path for the API call</param>
        /// <param name="_params">The optional POST params to pass to the API</param>
        public virtual Response post(string path, Params _params)
        {
            return request(Constants.POST, path, _params);
        }

        /// <summary>
        /// A generic method for making any authenticated or unauthenticated _request,
        /// passing in the bearer token explicitly. Used primarily by the
        /// AccessToken to get the first AccessToken.
        /// </summary>
        public virtual Response unauthenticatedRequest(string verb, string path, Params _params, string bearerToken)
        {
            Request _request = buildRequest(verb, path, _params, bearerToken);
            log(_request);
            return execute(_request);
        }

        /// <summary>
        /// Fetches the previous page for a given response.
        /// </summary>
        /// <returns>A new response of data</returns>
        /// <param name="response">response a response object previously received for which includes an array of data</param>
        public Response previous(Response response)
        {
            return page(Constants.PREVIOUS, response);
        }


        /// <summary>
        /// Fetches the previous page for a given response.
        /// </summary>
        /// <returns>a new array of resources of the same type.</returns>
        /// <param name="resource">resource one of the responses previously received from an API call</param>
        public Resource[] previous(Resource resource) 
        {
            return page(Constants.PREVIOUS, resource);
        }

        /// <summary>
        /// Fetches the next page for a given response.
        /// </summary>
        /// <returns>a new response of data</returns>
        /// <param name="response">a response object previously received for which includes an array of data</param>
        public Response next(Response response)
        {
            return page(Constants.NEXT, response);
        }

        /// <summary>
        /// Fetches the next page for a given response.
        /// </summary>
        /// <returns>a new array of resources of the same type</returns>
        /// <param name="resource">one of the responses previously received from an API call</param>
        public Resource[] next(Resource resource)
        {
            return page(Constants.NEXT, resource);
        }

        /// <summary>
        /// Fetches the first page for a given response.
        /// </summary>
        /// <returns>a new response of data.</returns>
        /// <param name="response">a response object previously received for which includes an array of data.</param>
        public Response first(Response response)
        {
            return page(Constants.FIRST, response);
        }

        /// <summary>
        /// Fetches the first page for a given response.
        /// </summary>
        /// <returns>a new array of resources of the same type.</returns>
        /// <param name="resource">one of the responses previously received from an API call.</param>
        public Resource[] first(Resource resource)
        {
            return page(Constants.FIRST, resource);
        }

        /// <summary>
        /// Fetches the last page for a given response.
        /// </summary>
        /// <returns>a new response of data.</returns>
        /// <param name="response">a response object previously received for which includes an array of data.</param>
        public Response last(Response response)
        {
            return page(Constants.LAST, response);
        }

        /// <summary>
        /// Fetches the last page for a given response.
        /// </summary>
        /// <returns>a new array of resources of the same type.</returns>
        /// <param name="resource">one of the responses previously received from an API call.</param>
        public Resource[] last(Resource resource)
        {
            return page(Constants.LAST, resource);
        }

        // A generic method for making _requests of any verb.
        internal Response request(String verb, String path, Params _params)
        {
            return unauthenticatedRequest(verb, path, _params, accessToken.getBearerToken());
        }

        // Builds a _request
        internal Request buildRequest(String verb, String path, Params _params, String bearerToken)
        {
            return new Request(verb, path, _params, bearerToken, this);
        }

        // A simple log that only triggers if we are in debug mode
        private void log(object _object)
        { 
            if (configuration.logLevel == "debug")
            {
                TraceSource logger = configuration.Logger;
                logger.TraceEvent(TraceEventType.Information, 0, _object.ToString());
            }
        }

        // Executes a _request and return a Response
        private Response execute(Request _request)
        {
            Response response = new Response(fetch(_request));
            response.parse();
            response.detectError();
            return response;
        }


        // Tries to make an API call. Raises an error if it can't complete the call.
        private Request fetch(Request _request)
        {
            try
            {
                _request.establishConnection();
                write(_request);
            } catch (Exception)
            {
                throw new NetworkException(new Response(_request));
            }
            return _request;
        }

        // Writes the parameters to the _request.
        private void write(Request _request)
        {
            if (_request.verb == Constants.POST & _request._params != null)
            {
                var postData = _request._params.toQueryString();
                var data = Encoding.UTF8.GetBytes(postData);
                _request.connection.ContentLength = data.Length;
                using (var stream = _request.connection.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
        }

        // Fetches the response for another page.
        internal Response page(String pageName, Response response)
        {
            try {
                string[] parts = response.result.get("meta").get("links").get(pageName).split("=");

                string pageNumber = parts[parts.Length - 1];

                Request _request = response.request;
                Params _params = (Params)_request._params.clone();
                _params["page[offset]"] = pageNumber;

                return request(_request.verb, _request.path, _params);
            } catch (Exception)
            {
                return null;
            }
        }

        // Fetches the response for another page.
        internal Resource[] page(String pageName, Resource resource)
        {
            Response response = page(pageName, resource.response);
            if (response != null) {
                return Resource.fromArray(response, resource.deSerializationClass);
            }
            else
            {
                return null;
            }
        }



}
}
