using Forum_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum_v1.Services
{
    public interface IPagination
    {
       Task<EnterIntoTopicViewModel> PaginateMessages(int topicId, int page = 1);
    }
}
