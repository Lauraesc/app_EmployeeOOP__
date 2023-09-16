using EmployeeOOP.Classes;

try
{
    Console.WriteLine("OOP APPLICATION ");
    Console.WriteLine("-----------------");

    //Inicialización de la clase Date.
    Date dataObject = new Date(4, 18, 5734834);
    Console.WriteLine(dataObject.ToString());
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}