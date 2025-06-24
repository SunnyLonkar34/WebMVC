namespace WebMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }


        public string Name { get; set; } = string.Empty;


        public int Salary { get; set; } 


        public string City { get; set; } = string.Empty;


        public CompanyDetail Company { get; set; } 


    }
  
}
