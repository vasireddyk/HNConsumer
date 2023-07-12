using HNCAApiDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNCAApiServices.Interfaces
{
    public interface IHNService
    {
        Task<List<HNStory>> GetBestStories(int noOfStories);
    }
}
