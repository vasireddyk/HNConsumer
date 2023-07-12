using HNCAApiServices.Interfaces;
using AutoMapper;

namespace HNCAApiConsumerApplication.BestStories
{
    public class GetHNBestStoriesQuery : IGetHNBestStoriesQuery
    {
        private readonly IHNService _service;
        private readonly IMapper _mapper;

        public GetHNBestStoriesQuery(IHNService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<List<HNStoryModel>> Execute(int noOfStories)
        {
            var stories=  await _service.GetBestStories(noOfStories);
            var results = _mapper.Map<List<HNStoryModel>>(stories);
            return results.OrderByDescending(x => x.Score).Take(noOfStories).ToList();
        }
    }
}
