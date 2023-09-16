using EmployeeOOP.Classes;

try
{
    //Variables declaration
    int day, month, year;

    Console.WriteLine("OOP APPLICATION ");
    Console.WriteLine("-----------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());


    Console.Write("Ingresar el día: ");
    month = Convert.ToInt32(Console.ReadLine());


    Console.Write("Ingresar el día: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date.
    Date dataObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dataObject.ToString());
    Console.ReadKey();
    Console.ReadLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();

}