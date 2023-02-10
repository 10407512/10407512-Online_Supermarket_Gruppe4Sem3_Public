namespace DataAccess.Model
{
    public class Employee : Person
    {
        //public String UserName { get; set; }
        //public string Role { get; set; }

        public Employee(string F_name, string L_name, string Email, string PhoneNo, string Role, string UserName) 
            : base()
        {  
            this.Role = "Employee";
            this.UserName = UserName;
        }
    }
}
