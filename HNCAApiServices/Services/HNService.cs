using HNCAApiDomain;
using HNCAApiServices.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace HNCAApiServices.Services
{
    public class HNService : IHNService
    {
        private IMemoryCache _cache;

        private static readonly HttpClient _httpClient = new HttpClient();

        // TODO Could store in configuration file/data store.
        const string baseUrl = "https://hacker-news.firebaseio.com/v0/";
        const string bestStoriesResource = "beststories.json";
        const string storyUrl = "https://hacker-news.firebaseio.com/v0/item/{0}.json";

        public HNService(IMemoryCache cache)
        {
            _cache = cache;
        }
        public async Task<List<HNStory>> GetBestStories(int noOfStories)
        {
            List<HNStory> stories = new List<HNStory>();

            var response = await _httpClient.GetAsync($"{baseUrl}{bestStoriesResource}");

            if (response.IsSuccessStatusCode)
            {
                var storiesResponse = response.Content.ReadAsStringAsync().Result;
                var bestIds = JsonConvert.DeserializeObject<List<int>>(storiesResponse);

                if (bestIds!=null && bestIds.Count > 0)
                {
                    var tasks = bestIds.Select(GetStoryAsync);
                    stories = (await Task.WhenAll(tasks)).ToList();
                }

            }
            return stories.OrderByDescending(x => x.Score).Take(noOfStories).ToList();
        }

        private async Task<HNStory> GetStoryAsync(int storyId)
        {
            return await _cache.GetOrCreateAsync(storyId,
                async cacheEntry =>
                {
                    HNStory story = new HNStory();

                    var response = await _httpClient.GetAsync(string.Format(storyUrl, storyId));
                    if (response.IsSuccessStatusCode)
                    {
                        var storyResponse = response.Content.ReadAsStringAsync().Result;
                        if (storyResponse != null)
                            story = JsonConvert.DeserializeObject<HNStory>(storyResponse);
                    }
                    return story;
                });
        }

    }
}
