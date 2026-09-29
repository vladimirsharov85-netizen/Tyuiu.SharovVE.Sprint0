using Tyuiu.SharovVE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SharovVE.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Владимир"));
            Console.ReadKey();
            Console.ReadKey(); 
        }
    }
}
