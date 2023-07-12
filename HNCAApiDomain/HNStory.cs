using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNCAApiDomain
{
    public class HNStory
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string PostedBy { get; set; }
        public long Time { get; set; }
        public int Score { get; set; }
        public int CommentCount { get; set; }
    }
}
