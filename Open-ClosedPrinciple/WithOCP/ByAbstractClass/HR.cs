namespace Open_ClosedPrinciple.WithOCP.ByAbstractClass
{
    public class HR : Employee
    {
        public override decimal CalcBonus(decimal hours)
        {
            var salaryPerHour = (Salary / 30) / 8;
            return salaryPerHour * hours * 2;
        }
    }
}
