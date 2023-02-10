namespace DataAccess.Model
{
    public class Guest : Person
    {
        public Guest(string F_name, string L_name, string Email, string PhoneNo)
            : base()
        {
            base.Role = "Guest";
        }
    }
}
