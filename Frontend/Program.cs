using Backend;

try
{
    //var date1 = new Date(); // 1900/01/01
    //var date2 = new Date(2027, 2, 29);
    //var date3 = new Date(2026, 12, 3);
    //Console.WriteLine(date1);
    //Console.WriteLine(date2);
    //Console.WriteLine(date3);


    var employee1 = new SalaryEmployee     (1010, "Martha", "lopez", new Date(1978, 7, 9), new Date(2026, 8, 10), true, 2000000);
    var employee2 = new CommissionEmployee (1020, "Marina", "Sanchez", new Date(1987, 6, 23), new Date(2023, 8, 7), true, 0.03f, 800000000);
    var employee3 = new CommissionEmployee (1030, "Tatiana", "Rodriguez", new Date(1990, 10, 14), new Date(2024, 12, 10), true, 0.03f, 260000000);

    var employees = new List<Employee> { employee1, employee2, employee3 };
    foreach (var employee in employees) 
    {
        Console.WriteLine(employee);
        Console.WriteLine("---------------------------------------");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}