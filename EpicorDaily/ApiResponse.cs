using EpicorDaily.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;

namespace EpicorDaily
{
    public class ApiResponse:IDisposable
    {
        //        System.Net.ServicePointManager.ServerCertificateValidationCallback =
        //    ((sender, certificate, chain, sslPolicyErrors) => true);

        //// trust sender
        //System.Net.ServicePointManager.ServerCertificateValidationCallback
        //                = ((sender, cert, chain, errors) => cert.Subject.Contains("YourServerName"));

        // validate cert by calling a function


        // callback used to validate the certificate in an SSL conversation
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors policyErrors)
        {
            bool result = false;
            if (cert.Subject.ToUpper().Contains("https://dis-e10test"))
            {
                result = true;
            }

            return result;
        }
        #region Private Declaration
        private HttpWebRequest _request;
        private AuthenticateModel _authInfo;
        private string _DomainUrl { get; set; } = "https://dis-e10test/epicorerptest/api/V1/";
        #endregion
        public ApiResponse()
        {
            //-------------- user credential from config
            //var AppSettingsReader = new AppSettingsReader();
            _authInfo = new AuthenticateModel()
            {
                UserName = "ECC",//AppSettingsReader.GetValue("E10User",typeof(string)).ToString(),
                Password = "BlueFr0gsPoles"//AppSettingsReader.GetValue("E10Pwd", typeof(string)).ToString()
            };
        }
        #region Api Response
        /// <summary>
        /// GetApiResponse 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ResponseModel GetApiResponse(string url, string method, string requestData = "", string contentType = "application/json")
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(delegate { return true; });
                // ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                // ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;

                _request = (HttpWebRequest)WebRequest.Create(string.Format("{0}{1}", _DomainUrl, url));
                _request.Method = method;
                _request.ContentType = contentType;
               


                string credentials = string.Format("{0}:{1}", _authInfo.UserName, _authInfo.Password);
                CredentialCache mycache = new CredentialCache();
                _request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
                if (requestData.Length > 0)
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(requestData);
                    using (var stream = _request.GetRequestStream())
                    {
                        stream.Write(byteArray, 0, requestData.Length);

                    }
                }
              //  _request.Headers.Add(requestData);
               var _response = ((HttpWebResponse)_request.GetResponse());

                if (_response == null) return new ResponseModel() { Response = string.Empty, success = false };
                //---------- Get Api response stream
                using (var _result = new StreamReader(_response.GetResponseStream()))
                {
                    //----------REturn response
                    return new ResponseModel() { Response = _result.ReadToEnd(), success = true }; ;
                }

            }
            catch (WebException ex)
            {
                return new ResponseModel() { Response = ex.Message, success = false };
            }
        }

       
        #endregion 
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ApiResponse() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
