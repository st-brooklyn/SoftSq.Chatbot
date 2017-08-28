using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftSq.ChatbotApi.Models
{
    public class ConversationMapping
    {
        
        public long Id { get; set; }
        public string RoomId { get; set; }
        public string SenderId { get; set; }
        public string ConversationToken { get; set; }
    }
}
