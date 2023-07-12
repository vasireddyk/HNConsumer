using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNCAApiConsumerApplication.BestStories
{
    public  record HNStoryModel
    {
        public string Title { get; init; }
        public string Url { get; init; }
        public string PostedBy { get; init; }
        public long Time { get; init; }
        public int Score { get; init; }
        public int CommentCount { get; init; }
    }
}
