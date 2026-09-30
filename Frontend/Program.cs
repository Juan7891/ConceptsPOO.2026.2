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
    var employee4 = new HourlyEmployee     (1040, "Fabian", "Sandoval", new Date(1993, 12, 14), new Date(2025, 7, 10), true, 132.5f, 30000);
    var employee5 = new HourlyEmployee     (1050, "Cristina", "Alvarez", new Date(1998, 5, 25), new Date(2025, 6, 9), true, 90, 80000);
    var employee6 = new BaseCommissionEmployee (1060, "Juan", "Ramirez", new Date(1993, 09, 14), new Date(2025, 6, 10), true, 0.0125f, 80000000, 600000);
    var invoice1 = new Invoice  (20301, "Computador Portatil HP52341", 5600000, 7);
    var invoice2 = new Invoice  (20302, "Sillas Escritorio Ergonomus", 3600000, 7);


    var espenses = new List<IPay> { employee1, employee2, employee3, employee4, employee5, employee6, invoice1, invoice2 };
    decimal total = 0;
    foreach (var espense in espenses) 
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(espense);
        total += espense.GetValueToPay();
    }
    
    Console.WriteLine("=================================================");
    Console.WriteLine($"TOTAL.........................:{total,20:C2}");
    Console.WriteLine("=================================================");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}