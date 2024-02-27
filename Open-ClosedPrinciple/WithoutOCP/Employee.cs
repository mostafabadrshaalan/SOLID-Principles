namespace Open_ClosedPrinciple.WithoutOCP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal CalcBonus(decimal hours)
        {
            var salaryPerHour = (Salary / 30) / 8;
            return salaryPerHour * hours;
        }

        //Now if i want to make edit on calc bouns depends on Employee's position

        public string EmployeePosition { get; set; }
        public decimal CalcBonus(decimal hours, string position)
        {
            var salaryPerHour = (Salary / 30) / 8;
            return EmployeePosition == "Manager" ? salaryPerHour * hours * 3 : salaryPerHour * hours * 2;
        }

        //That's mean when i want to make any modification i must do it in the class and the client (main)

    }
}
