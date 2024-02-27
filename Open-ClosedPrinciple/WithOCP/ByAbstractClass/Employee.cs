namespace Open_ClosedPrinciple.WithOCP.ByAbstractClass
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public abstract decimal CalcBonus(decimal hours);
    }
}
