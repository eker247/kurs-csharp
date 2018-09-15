using System;
namespace models.User
{
    public class User
    {
        public string Email { get; set; }
        
        [models.Atrybuty.Length(8)]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; private set; }

        public User(string email, string password) 
        {
            this.Email = email;
            this.Password = password;
        }

        public void SetEmail(string email) 
        {
            if (string.IsNullOrWhiteSpace(email)) 
            {
                throw new Exception("Password is incorrect.");
            }
            if (email == this.Email) 
            {
                return;
            }
            this.Email = email;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password) 
        {
            this.Password = password;
        }

    }
}
