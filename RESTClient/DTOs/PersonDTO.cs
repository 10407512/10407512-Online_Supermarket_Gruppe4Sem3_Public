using System.ComponentModel.DataAnnotations;

namespace RESTClient.DTOs
{
    public class PersonDTO
    {
        public string F_name { get; set; }
        public string L_name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        //public string Role { get; set; }
        //public string? UserName { get; set; }
    }
}
