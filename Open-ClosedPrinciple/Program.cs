using Open_ClosedPrinciple.WithOCP.ByAbstractClass;
using Open_ClosedPrinciple.WithOCP.ByInterface;

namespace Open_ClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Without OCP
            WithoutOCP.Employee e1 = new WithoutOCP.Employee()
            {
                Id = 1,
                Name = "Mohammed",
                Salary = 5000
            };

            Console.WriteLine(e1.CalcBonus(5)); //104

            //Now if i want to make edit on calc bouns depending on Employee's position

            WithoutOCP.Employee e2 = new WithoutOCP.Employee()
            {
                Id = 2,
                Name = "Ahmed",
                Salary = 6000,
                EmployeePosition = "HR"
            };
            Console.WriteLine(e2.CalcBonus(5, e2.EmployeePosition)); //250

            WithoutOCP.Employee e3 = new WithoutOCP.Employee()
            {
                Id = 3,
                Name = "Amr",
                Salary = 6000,
                EmployeePosition = "Manager"
            };

            Console.WriteLine(e3.CalcBonus(5, e3.EmployeePosition)); //375

            #endregion

            #region WithOCP

            #region ByAbstractClass

            WithOCP.ByAbstractClass.Employee e4 = new Manager() { Id = 4, Name = "Mohamed", Salary = 7000 };
            Console.WriteLine(e4.CalcBonus(3)); //262.5

            WithOCP.ByAbstractClass.Employee e5 = new HR() { Id = 5, Name = "Atef", Salary = 4000 };

            #endregion

            #region ByInterface

            IEmployee e6 = new ManagerEmployee() { Id = 6, Name = "Alaa", Salary = 2000 };
            Console.WriteLine(e6.CalcBonus(7));

            IEmployee e7 = new HREmployee() { Id = 7, Name = "Sasy", Salary = 8000 };
            Console.WriteLine(e7.CalcBonus(7));

            #endregion

            #endregion
        }
    }
}
