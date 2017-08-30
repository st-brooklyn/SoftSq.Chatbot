using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftSq.ChatbotApi.Models;
using SoftSq.ChatbotApi.Models.Messages;

namespace SoftSq.ChatbotApi.Controllers
{
    [Produces("application/json")]
    [Route("message")]
    public class MessageController : Controller
    {
        private readonly ChatbotContext _context;
        public MessageController(ChatbotContext context)
        {
            _context = context;

            if(_context.Mappings.Count() == 0)
            {
                //_context.Mappings.Add(new ConversationMapping { })
            }
        }

        [HttpPost("getlinemessage")]        
        public IActionResult GetLineMessage([FromBody] LineMessage message)
        {
            if (message == null)
            {
                return BadRequest();
            }

            if(message.events.Count > 0)
            {
                var item = message.events[0];
                
                // Parse the request into values
                var mapping = new ConversationMapping
                {
                    SenderId =  item.source.userId,
                    RoomId = item.source.roomId
                };

                // Add a new mapping to the database
                _context.Mappings.Add(mapping);
                _context.SaveChanges();

                string originalText = item.message.text;


                return Ok(new { id = mapping.Id });
            }
            else
            {
                // No message sent to this api
                return BadRequest();
            }

            
        }
    }
}