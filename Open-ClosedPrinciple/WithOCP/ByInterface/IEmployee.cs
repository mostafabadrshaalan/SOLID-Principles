namespace Open_ClosedPrinciple.WithOCP.ByInterface
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }

        decimal CalcBonus(decimal hours);
    }
}
