using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JiraApplicationBusinessLogic.Services
{
    internal class BaseService
    {
        private protected readonly HttpClient _httpClient;

        protected BaseService(string url)
        {
            HttpClientHandler insecureHandler = GetInsecureHandler();
            _httpClient = new HttpClient(insecureHandler);
            _httpClient.BaseAddress = new Uri(url);
        }


        private protected HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}
