namespace BizSecureDemo22180074.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
    }

}
