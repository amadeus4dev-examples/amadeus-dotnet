using amadeus.exceptions;
using amadeus.resources;
using System;
using System.Collections.Generic;

namespace amadeus.booking
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/booking/flight-orders</code> ,
    /// endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.booking.flightOffers;
    /// </code>
    /// </summary>
    public class FlightOrderManagement
    {
        internal Amadeus client { get; set; }

        public FlightOrderManagement(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// /booking/flight-orders/{flight-orderId}.
        /// </para>
        /// 
        /// <code>
        /// amadeus.booking.flightOrder.getFlightOrderManagement(Params.with("flight-orderId", "eJzTd9f3s4gKC%2FMEAAt8Ans%3D"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public FlightOrderCreateQuery getFlightOrderManagement(Params _params)
        {
            try
            {
                var parameters = _params.GetEnumerator();
                parameters.MoveNext();
                var id = parameters.Current;
                string path = "/v1/booking/flight-orders/" + id.Value;
                Response response = client.get(path);
                return (FlightOrderCreateQuery)Resource.fromObject(response, typeof(FlightOrderCreateQuery));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="getFlightOrderManagement(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public FlightOrderCreateQuery getFlightOrderManagement()
        {
            try
            {
                return getFlightOrderManagement(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// /booking/flight-orders.
        /// </para>
        /// 
        /// <code>
        /// amadeus.booking.flightOrder.postFlightOrderManagement(body);
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="body">body the parameters to send to the API as a JSonObject</param>
        public FlightOrderCreateQuery postFlightOrderManagement(string body)
        {
            try
            {
                Response response = client.post("/v1/booking/flight-orders", body);
                return (FlightOrderCreateQuery)Resource.fromObject(response, typeof(FlightOrderCreateQuery));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>post</code> without any parameters.
        /// <see cref="postFlightOrderManagement(string)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public FlightOrderCreateQuery postFlightOrderManagement()
        {
            try
            {
                return postFlightOrderManagement(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// /booking/flight-orders/{flight-orderId}.
        /// </para>
        /// 
        /// <code>
        /// amadeus.booking.flightOrder.deleteFlightOrderManagement(Params.with("flight-orderId", "eJzTd9f3s4gKC%2FMEAAt8Ans%3D"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public FlightOrderCreateQuery[] deleteFlightOrderManagement(Params _params)
        {
            try
            {
                var parameters = _params.GetEnumerator();
                parameters.MoveNext();
                var id = parameters.Current;
                string path = "/v1/booking/flight-orders/" + id.Value;
                Response response = client.delete(path, _params);
                return (FlightOrderCreateQuery[])Resource.fromArray(response, typeof(FlightOrderCreateQuery[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>post</code> without any parameters.
        /// <see cref="deleteFlightOrderManagement(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public FlightOrderCreateQuery[] deleteFlightOrderManagement()
        {
            try
            {
                return deleteFlightOrderManagement(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }
    }
}
