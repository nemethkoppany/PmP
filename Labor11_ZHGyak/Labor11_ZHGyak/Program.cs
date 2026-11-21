
namespace Labor11_ZHGyak
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Dataset baseSet = null;
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Load data file\r\n2. Get average shipping fee\r\n3. List shipments without recent updates\r\n4. Show distribution of delivery methods\r\n5. Exit");
                Console.Write("Your choice: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.Write("Add meg a fájl nevét: ");
                    string filename = Console.ReadLine();
                    baseSet = new Dataset(filename);
                }
                else if (userChoice == "2")
                {
                    if (baseSet == null)
                    {
                        Console.WriteLine("Előbb be kell töltened egy fájlt.");
                    }
                    else
                    {
                        Console.Write("Add meg a szállítási szintet (Express, Standard, Economy): ");
                        ServiceLevel serviceLevel = (ServiceLevel)Enum.Parse(typeof(ServiceLevel), Console.ReadLine());
                        Console.WriteLine($"Átlag szllítási kölcség: {baseSet.AverageShippingFee(serviceLevel)}");
                    }
                    
                }
                else if (userChoice == "3" )
                {
                    if (baseSet == null)
                    {
                        Console.WriteLine("Előbb be kell töltened egy fájlt.");
                    }
                    else
                    {
                        Console.Write("Adj meg egy egész értéket: ");
                        int days = int.Parse(Console.ReadLine());
                        Package[] set = baseSet.CollectStaleShipments(days);
                        foreach (Package pack in set)
                        {
                            Console.WriteLine(pack.DataAsText());
                        }
                    }
                    
                    
                }
                else if (userChoice == "4" )
                {
                    if (baseSet == null)
                    {
                        Console.WriteLine("Előbb be kell töltened egy fájlt.");
                    }
                    else
                    {
                        Console.Write("Add meg a preferált kézbesítési módodat (Courier, Locker, PickupPoint, PostOffice): ");
                        DeliveryMethod method = (DeliveryMethod)Enum.Parse(typeof(DeliveryMethod), Console.ReadLine());
                        Console.WriteLine(baseSet.DistributionOfDeliveryMethod(method));
                    }
                    
                }
                else if (userChoice == "5")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Adj meg egy helyes menüpontot");
                }
                if (running)
                {
                    Console.WriteLine("Nyomj Entert a folytatáshoz...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            

            
           
        }
    }
}
