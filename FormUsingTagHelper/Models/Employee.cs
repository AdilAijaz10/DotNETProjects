namespace FormUsingTagHelper.Models
{
    public enum Gender
    {
        Male,Felmale
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }
        public string Married { get; set; }
        public string Description { get; set; }
    }
    
}
