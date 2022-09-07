﻿using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Blazor_WA_Sync_Fluxor.Services
{
    public class JsonPlaceholderApiService
    {
        private readonly ILogger<JsonPlaceholderApiService> _logger;
        private readonly HttpClient _httpClient;
        public JsonPlaceholderApiService(ILogger<JsonPlaceholderApiService> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }
        public Task<TResponse> GetAsync<TResponse>(string path)
        {
            _logger.LogInformation($"GET: Retrieving resource of type {typeof(TResponse).Name}");
            return _httpClient.GetFromJsonAsync<TResponse>(path);

        }

        public Task<HttpResponseMessage> PostAsync<TBody>(string path, TBody body)
        {
            _logger.LogInformation($"POST: Creating resource of type {typeof(TBody).Name}");
            return _httpClient.PostAsJsonAsync(path, body);
        }

        public Task<HttpResponseMessage> PutAsync<TBody>(string path, TBody body)
        {
            _logger.LogInformation($"PUT: Updating resource of type {typeof(TBody).Name}");
            return _httpClient.PutAsJsonAsync(path, body);
        }

        public Task<HttpResponseMessage> DeleteAsync(string path)
        {
            _logger.LogInformation("DELETE: Removing resource");
            return _httpClient.DeleteAsync(path);
        }
    }
}
