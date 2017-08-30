﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftSq.ChatbotApi.Models.Messages
{
    public class LineMessage
    {
        public List<Event> events { get; set; }
    }

    public class Event
    {
        public string replyToken { get; set; }
        public string type { get; set; }
        public long timestamp { get; set; }
        public Source source { get; set; }
        public Message message { get; set; }
    }

    public class Source
    {
        public string type { get; set; }
        public string userId { get; set; }
        public string roomId { get; set; }
    }

    public class Message
    {
        public string id { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }
}
