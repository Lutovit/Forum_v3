using Forum_v1.Models;
using Repository.Absract;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum_v1.Services
{
    public class PaginationService : IPagination
    {
        private readonly ITopicRepository _topicRepo;
        private readonly int pageSize = 3;


        public PaginationService(ITopicRepository topicRepo) 
        {
            _topicRepo = topicRepo;
        }


        public async Task<EnterIntoTopicViewModel> PaginateMessages(int topic_Id, int page = 1)
        {
            Topic topic = await _topicRepo.FindByIdWithIncludeMessagesAsync(topic_Id);

            IEnumerable<Message> messages = topic.TopicMessages;

            EnterIntoTopicViewModel model = new EnterIntoTopicViewModel
            {
                TopicId = topic_Id,
                Messages = messages.OrderBy(c => c.Date).Skip((page - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = messages.Count()
                }
            };

            return model;
        }
    }
}
