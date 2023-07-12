using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNCAApiConsumerApplication.BestStories
{
    public  interface IGetHNBestStoriesQuery
    {
       Task<List<HNStoryModel>> Execute(int noOfStories);
    }
}
