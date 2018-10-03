using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace demo12HttpClient.Models
{
    public interface IApiConnector
    {
        

    }
    public class ApiConnector : IApiConnector
    {
        private readonly HttpClient _client;
        private readonly ILogger<ApiConnector> _logger;

        public ApiConnector(HttpClient httpClient, ILogger<ApiConnector> logger)
        {
            _logger = logger;
            _client = httpClient;
        }
    }
}
