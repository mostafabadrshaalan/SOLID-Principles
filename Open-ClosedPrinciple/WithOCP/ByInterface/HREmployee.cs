namespace Open_ClosedPrinciple.WithOCP.ByInterface
{
    public class HREmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public decimal CalcBonus(decimal hours)
        {
            var salaryPerHour = (Salary / 30) / 8;
            return salaryPerHour * hours * 2;
        }
    }
}
