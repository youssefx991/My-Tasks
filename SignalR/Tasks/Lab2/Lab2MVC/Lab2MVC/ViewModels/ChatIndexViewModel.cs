using Lab2MVC.Models;

namespace Lab2MVC.ViewModels
{
    public class ChatIndexViewModel
    {
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
        public List<string> Users { get; set; } = new List<string>();


    }
}
