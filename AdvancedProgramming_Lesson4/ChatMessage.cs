using Microsoft.AspNetCore.Identity;

namespace AdvancedProgramming_Lesson4
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public IdentityUser User { get; set; }
        public string Message { get; set; }
    }
}
