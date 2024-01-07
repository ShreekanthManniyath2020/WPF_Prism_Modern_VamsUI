using VamsUI.Vams.PrismDemo.Services.Interfaces;

namespace VamsUI.Vams.PrismDemo.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
