namespace InterfaceSegregationPrinciple.WithISP.Interfaces
{
    public interface IOrder : ICashOrder, ICreditOrder
    {
        //If i want to use these two services
    }
}
