using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FilmsMAUI.Services
{
    public class TmdbService
    {
        private const string ApiKey = "";
        public const string TmdbHttpClientName = "TmdbClient";

        private readonly IHttpClientFactory _httpClientFactory;

        public TmdbService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private HttpClient HttpClient => _httpClientFactory.CreateClient(TmdbHttpClientName);


    }
    public static class TmdbUrls
    {
        public const string Trending = "3/trending/all/week?language=en-US";
        public const string NetflixOriginals = "3/discover/tv?language=en-US&with_networks=213";
        public const string TopRated = "3/movie/top_rated?language=en-US";
        public const string Action = "3/discover/movie?language=en-US&swith_generes=28";

    }
}
