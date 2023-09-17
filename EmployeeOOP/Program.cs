using EmployeeOOP.Classes;

try
{
    //Variables declaration
    int day, month, year, hours;
    string firstName, lastName;
    decimal salary, commissionPercentage, sales, b4se, hourValue;

    Console.WriteLine("OOP APPLICATION ");
    Console.WriteLine("-----------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());


    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());


    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date.
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    // HardCoding = Quemar código 

    Console.WriteLine("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.WriteLine("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.WriteLine("Ingresar salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    // SalaryEmployee Case

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {

        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine("-------- SalaryEmployee Case ---------");
    Console.WriteLine(salaryEmployee.ToString());

    // CommissionEmployee Case

    Console.WriteLine("Ingresar el prtje. de comisión: ");
    commissionPercentage = Decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar el valor de las ventas: ");
    sales = Decimal.Parse(Console.ReadLine());


    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentage = commissionPercentage,
        Sales = sales,
    };

    Console.WriteLine("-------- CommissionEmployee Case ---------");
    Console.WriteLine(commissionEmployee.ToString());

    // BaseCommissionEmployee Case

    Console.WriteLine("Ingresar el valor de las ventas: ");
    sales = Decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar el vlr. de la base: ");
    b4se = Decimal.Parse(Console.ReadLine());

    BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentage = commissionPercentage,
        Sales = sales,
        Base = b4se,
    };
    Console.WriteLine("-------- BaseCommissionEmployee Case ---------");
    Console.WriteLine(baseCommissionEmployee.ToString());

    // HourlyEmployee Case

    Console.WriteLine("Ingresar la cant. de hrs, trabajadas: ");
    hours = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresar el vlr. por hora: ");
    hourValue = Decimal.Parse(Console.ReadLine());


    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = hours,
        HourValue = hourValue,
    };

    Console.WriteLine("-------- HourlyEmployee Case ---------");
    Console.WriteLine(hourlyEmployee.ToString());
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
   // Console.ReadLine();

}