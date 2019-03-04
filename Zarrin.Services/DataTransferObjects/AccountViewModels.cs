namespace Zarrin.Services.DataTransferObjects
{
    using System.ComponentModel.DataAnnotations;

    public class UserDto
    {
        public int Id { get; set; }
        
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
    }
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

     public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}