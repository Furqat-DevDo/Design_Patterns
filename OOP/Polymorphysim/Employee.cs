namespace Polymorphysim
{
    public class Employee
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }
        public string? Salary { get; set; }
        public string? HireDate { get; set; }
        public string? Status { get; set; }
        public virtual void DoWork()
        {
            Console.WriteLine("I am working .. ");
        }
    }
}