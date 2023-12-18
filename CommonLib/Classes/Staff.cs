using WebApp_GKH.Helpers;

namespace CommonLib.Classes
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public UserType Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateRegistration { get; set; }


        public Staff(string name, string surname, string login, string password, string dateOfBirth, string email, string phone)
        {
            FirstName = name;
            SecondName = surname;
            //Type = Id Работника; // Id UserType
            Login = login;
            Password = password;
            DateOfBirth = Converter.ConvertStringToDate(dateOfBirth);
            Email = email;
            Phone = phone;
            DateRegistration = DateTime.Now;
        }

        public Staff()
        {
            //Type = Id Работника; // Id UserType
            DateRegistration = DateTime.Now;
        }
    }
}
