// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Classes;

try
{
    //Declaracion de variables

    int day, month, year;

    Console.WriteLine("OPP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n");


    //Inicialización de la clase Date
    Date dateObjet = new Date(day, month, year);
    Console.WriteLine(dateObjet.ToString());

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}


