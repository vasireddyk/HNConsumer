using HNCAApiConsumerApplication.BestStories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNCAApiConsumer.Controllers
{
    [Route("api/stories")]
    [ApiController]
    public class HNBestStoriesController : ControllerBase
    {
        private readonly IGetHNBestStoriesQuery _query;

        public HNBestStoriesController(IGetHNBestStoriesQuery query)
        {
            _query = query;
        }

        [HttpGet]
        public async Task<JsonResult> GetStories(int noOfStories)
        {
            var stories = await _query.Execute(noOfStories);

            if (stories == null || stories.Count==0)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(stories));
        }
    }
}
