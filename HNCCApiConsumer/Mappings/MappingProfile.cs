using AutoMapper;
using HNCAApiConsumerApplication.BestStories;
using HNCAApiDomain;

namespace HNCAApiConsumer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<HNStory, HNStoryModel>();
        }
    }
}
