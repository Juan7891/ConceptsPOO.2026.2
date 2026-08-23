namespace Backend;

public class CommissionEmployee : Employee
{
    //Fields
    private float _commissionPercentage;
    private decimal _sales;

    //Constructors
    public CommissionEmployee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive, float commissionPercentage, decimal sales)
        : base(id, firstName, lastName, bornDate, hireDate, isActive)
    {
        CommissionPercentage = commissionPercentage;
        Sales = sales;
    }

    //Properties
    public float CommissionPercentage 
    { 
        get => _commissionPercentage; 
        set => _commissionPercentage = ValidateCommissionPercentage(value); 
    }
    public decimal Sales 
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    //public Methods
    public override decimal GetValueToPay() => _sales * (decimal)_commissionPercentage;
    
    //private Methods
    private float ValidateCommissionPercentage(float commissionPercentege) 
    {
        if (commissionPercentege < 0 || commissionPercentege > 0.3)
        {
            throw new Exception($"the commission Percentage: {commissionPercentege:P2}, is not valid.");
        }
        return commissionPercentege;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new Exception($"the sales: {sales:C2}, is not valid.");
        }
        return sales;
    }
}
