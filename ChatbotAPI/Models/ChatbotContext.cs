using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoftSq.ChatbotApi.Models
{
    public class ChatbotContext: DbContext
    {
        public ChatbotContext(DbContextOptions<ChatbotContext> options) : base(options) { }

        public DbSet<ConversationMapping> Mappings { get; set; }
    }
}
