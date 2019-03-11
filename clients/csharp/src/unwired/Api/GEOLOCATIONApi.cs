/* 
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using unwired.Client;
using unwired.Model;

namespace unwired.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGEOLOCATIONApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Geolocation
        /// </summary>
        /// <remarks>
        /// The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>Object</returns>
        Object Geolocation (GeolocationSchema geolocationSchema);

        /// <summary>
        /// Geolocation
        /// </summary>
        /// <remarks>
        /// The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GeolocationWithHttpInfo (GeolocationSchema geolocationSchema);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Geolocation
        /// </summary>
        /// <remarks>
        /// The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GeolocationAsync (GeolocationSchema geolocationSchema);

        /// <summary>
        /// Geolocation
        /// </summary>
        /// <remarks>
        /// The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GeolocationAsyncWithHttpInfo (GeolocationSchema geolocationSchema);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GEOLOCATIONApi : IGEOLOCATIONApi
    {
        private unwired.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GEOLOCATIONApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GEOLOCATIONApi(String basePath)
        {
            this.Configuration = new unwired.Client.Configuration { BasePath = basePath };

            ExceptionFactory = unwired.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GEOLOCATIONApi"/> class
        /// </summary>
        /// <returns></returns>
        public GEOLOCATIONApi()
        {
            this.Configuration = unwired.Client.Configuration.Default;

            ExceptionFactory = unwired.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GEOLOCATIONApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GEOLOCATIONApi(unwired.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = unwired.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = unwired.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public unwired.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public unwired.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Geolocation The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>Object</returns>
        public Object Geolocation (GeolocationSchema geolocationSchema)
        {
             ApiResponse<Object> localVarResponse = GeolocationWithHttpInfo(geolocationSchema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Geolocation The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GeolocationWithHttpInfo (GeolocationSchema geolocationSchema)
        {
            // verify the required parameter 'geolocationSchema' is set
            if (geolocationSchema == null)
                throw new ApiException(400, "Missing required parameter 'geolocationSchema' when calling GEOLOCATIONApi->Geolocation");

            var localVarPath = "/process.php";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (geolocationSchema != null && geolocationSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(geolocationSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = geolocationSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Geolocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Geolocation The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GeolocationAsync (GeolocationSchema geolocationSchema)
        {
             ApiResponse<Object> localVarResponse = await GeolocationAsyncWithHttpInfo(geolocationSchema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Geolocation The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="geolocationSchema"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GeolocationAsyncWithHttpInfo (GeolocationSchema geolocationSchema)
        {
            // verify the required parameter 'geolocationSchema' is set
            if (geolocationSchema == null)
                throw new ApiException(400, "Missing required parameter 'geolocationSchema' when calling GEOLOCATIONApi->Geolocation");

            var localVarPath = "/process.php";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (geolocationSchema != null && geolocationSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(geolocationSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = geolocationSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Geolocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}