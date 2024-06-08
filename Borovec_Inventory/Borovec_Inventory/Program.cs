//Written by Jonathan Borovec
namespace Borovec_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool isRunning = true;
            Shipper shipper = new Shipper();
            IShippable bike = new Bicycle();
            IShippable mower = new LawnMower();
            IShippable phone = new CellPhone();
            IShippable glove = new BaseballGlove();
            IShippable crack = new Crackers();
            Bicycle[] bicycle = new Bicycle[10];
            LawnMower[] lawnMowers = new LawnMower[10];
            CellPhone[] cellPhones = new CellPhone[10];
            BaseballGlove[] baseballGloves = new BaseballGlove[10];
            Crackers[] crackers = new Crackers[10];

            while (isRunning) {

                Console.WriteLine("------ Main Menu ------");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Cell Phone to the shipment");
                Console.WriteLine("4. Add a Baseball Glove to the shipment");
                Console.WriteLine("5. Add Crackers to the shipment");
                Console.WriteLine("6. List shipment items");
                Console.WriteLine("7. Compute shipping charges");
                Console.WriteLine("0. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        shipper.Add(bike, bicycle);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        shipper.Add(mower, lawnMowers);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        shipper.Add(phone, cellPhones);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        shipper.Add(glove, baseballGloves);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        shipper.Add(crack, crackers);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        shipper.List(bicycle, lawnMowers, cellPhones, baseballGloves, crackers);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Total shipping cost for this order is $" + shipper.Total(bicycle, lawnMowers, cellPhones, baseballGloves, crackers));
                        Console.WriteLine("Now exiting...");
                        isRunning = false;
                        break;
                    case 0:
                        Console.WriteLine("Exiting....");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection");
                        break;

                }
            }
        }
    }
}
