using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Core.Services
{
    public class ChatCommand
    {
        public string Text { get; set; }
        public string Sender { get; set; }
    }

    public class ChatResponse
    {
        public string Text { get; set; }
    }   

    public interface IChatServicesInfra
    {
        ChatResponse Invoke(ChatCommand chatCommand);
    }

    public class ChatServices
    {
        public IChatServicesInfra _chatServicesInfra { get; set; }

        public ChatServices(IChatServicesInfra chatServicesInfra)
        {
            _chatServicesInfra = chatServicesInfra;
        }

        public ChatResponse Invoke(ChatCommand chatCommand)
        {
            return _chatServicesInfra.Invoke(chatCommand);
        }
    }
}
