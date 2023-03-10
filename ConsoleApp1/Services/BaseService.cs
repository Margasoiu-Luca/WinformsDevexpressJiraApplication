using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using BusinessLogic.Infrastructure;

namespace BusinessLogic.Services
{
    internal class BaseService
    {
        private protected readonly HttpClient _httpClient;
        private protected string restOfUri;
        protected BaseService(string url)
        {
            string[] splitURL = url.Split(new[] { "/api/" }, StringSplitOptions.RemoveEmptyEntries);
            restOfUri = splitURL[1];
            HttpClientHandler insecureHandler = GetInsecureHandler();
            _httpClient = new HttpClient(insecureHandler);
            _httpClient.BaseAddress = new Uri($"{splitURL[0]}/api/");
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
        protected JsonSerializerOptions options = new JsonSerializerOptions()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            WriteIndented = true
        };
    }
}
