namespace Backend;

public class HourlyEmployee : Employee
{
    //Fields
    private decimal _hourValue;
    private float _workinghours;

    //Constructors
    public HourlyEmployee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive, float workinghours, decimal hourValue)
        : base(id, firstName, lastName, bornDate, hireDate, isActive)
    {
        HourValue = hourValue;
        Workinghours = workinghours;
       
    }

    //Properties
    public decimal HourValue 
    {
        get => _hourValue; 
        set => _hourValue = ValidateHourlValue(value);
    }
    public float Workinghours 
    {
        get => _workinghours; 
        set => _workinghours = ValidateWorkinghours(value);
    }

    //Public Methods
    public override decimal GetValueToPay() => HourValue * (decimal)Workinghours;
  
    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
               $" Working hours..:    {Workinghours,20:N2}\n\t" +
               $" Hour value........:   {HourValue,20:C2}\n\t" +
               $" Salary............:   {GetValueToPay(),20:C2}";
    }

    //Privatec Methods
    private decimal ValidateHourlValue(decimal hourValue)
    {
        if (hourValue < 10000)
        {
            throw new Exception($"the hour Value: {hourValue:C2}, is less than the $10,000.00");
        }
        return hourValue;
    }
   
    private float ValidateWorkinghours(float workinghours)
    {
        if (workinghours < 0)
        {
            throw new Exception($"the Working hours : {workinghours:N2}, is less than the zero");
        }
        return workinghours;
    }

}
