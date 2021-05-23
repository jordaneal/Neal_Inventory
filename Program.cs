using System;

namespace Neal_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose From the Following Options:\n" +
                    "1. Add a Bicycle to the Shipment\n" +
                    "2. Add a Lawn Mower to the Shipment\n" +
                    "3. Add a Baseball Glove to the Shipment\n" +
                    "4. Add Crackers to the Shipment\n" +
                    "5. List Shipment Items\n" +
                    "6. Compute Shipping Charges\n");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write(shipper.Add(new Bicycle()));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write(shipper.Add(new LawnMower()));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write(shipper.Add(new BaseballGlove()));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write(shipper.Add(new Crackers()));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Write(shipper.List());
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write(shipper.ComputeShippingCost());
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Invalid Entry! Press any key to return to try again. . .\n");
                        break;
                }
            } while (input != "6");
        }
    }
}
