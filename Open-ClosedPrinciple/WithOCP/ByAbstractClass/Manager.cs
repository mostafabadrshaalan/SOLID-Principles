namespace Open_ClosedPrinciple.WithOCP.ByAbstractClass
{
    public class Manager : Employee
    {
        public override decimal CalcBonus(decimal hours)
        {
            var salaryPerHour = (Salary / 30) / 8;
            return salaryPerHour * hours * 3;
        }
    }
}
