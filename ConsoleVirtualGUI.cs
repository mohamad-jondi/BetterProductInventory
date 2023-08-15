
namespace BetterProductInventory
{
    public class ConsoleVirtualGUI
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this Mangment System, please choose what you want to do!");
            while (true)
            {
                Console.WriteLine("1.Add a New Product");
                Console.WriteLine("2.View All Existing Products");
                Console.WriteLine("3.Edit an Exisiting Product");
                Console.WriteLine("4.Delete a Product");
                Console.WriteLine("5.Search For a Product");
                Console.WriteLine("6.Close");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("adding new product");
                        break;
                    case 2:
                        Console.WriteLine("Viewing All Existing Products");
                        break;
                    case 3:
                        Console.WriteLine("Edit an Existing Product");
                        break;
                    case 4:
                        Console.WriteLine("4.Delete a Product");
                        break;
                    case 5:
                        Console.WriteLine("5.Search For a Product");
                        break;
                    case 6:
                        Console.WriteLine("6.Close");
                        break;
                }
            }
        }
    }
}