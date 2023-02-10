using System.ComponentModel.DataAnnotations;


namespace DataAccess.Model
{
    public class Person
    {
        [Required]
        public string F_name { get; set; }
        [Required]
        public string L_name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]  
        public string Role { get; set; }
        public string? UserName { get; set; }


        public Person (string F_name, string L_name, string Email, string PhoneNo, string Role, string UserName)
        {
            this.F_name = F_name;
            this.L_name = L_name;
            this.Email = Email;
            this.PhoneNo = PhoneNo;
            this.Role = Role;   
            this.UserName = UserName;
        }

        public Person() //is used for DTOConverter when a personDTO is converted to a person object.
        {

        }

		//This method converts a person object to string and is only used if we need to
        //print out the information of a person object in the console
		public override string ToString()
        {
            return $"Name    - {F_name} {L_name}\n" +
                   $"Email   - {Email}\n" +
                   $"Phone   - {PhoneNo}\n" +
                   $"Role   - {Role}\n" +
                   $"UserName   - {UserName}\n" +
                   $"---\n";
        }
    }
}
