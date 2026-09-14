

namespace Backend;

public class BaseCommissionEmployee : CommissionEmployee
{

    //Fields
    private decimal _Salary;

    //Constructor
    public BaseCommissionEmployee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive, float commissionPercentage, decimal sales) 
        : base(id, firstName, lastName, bornDate, hireDate, isActive, commissionPercentage, sales)
    {
    }

    //properties



    //Methodos


}
