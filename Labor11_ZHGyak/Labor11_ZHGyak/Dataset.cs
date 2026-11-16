using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Labor11_ZHGyak
{
    internal class Dataset
    {
        private List<Package> PackageList = new List<Package>();
        public int Sum { get
            {
                return PackageList.Count;
            } }
        public Dataset(string FileName)
        {
           string[] lines =  File.ReadAllLines(FileName);
            for(int i = 1; i < lines.Length; i++)
            {
                Package package = new Package(lines[i]);
                PackageList.Add(package);
            }
        }

        //Készítsen egy AverageShippingFee nevű metódust, amely paraméterként egy ServiceLevel értéket vár, majd
        //visszaadja az adott szolgáltatási szinthez tartozó csomagok átlagos szállítási díját(double ).
        public double AverageShippingFee(ServiceLevel level)
        {
                double Sum = 0;
                double packageCount = 0;
                foreach (Package package in PackageList)
                {
                    if (package.ServiceLevel == level)
                    {
                        Sum += package.ShippingFee;
                        packageCount++;
                    }
                }
            if (packageCount == 0)
            {
                return 0.0;
            }
            return Sum / packageCount;
           
        }

        //Készítsen egy CollectStaleShipments nevű metódust, amely paraméterként egy egész számot vár, majd egy
        //tömbbe gyűjti azokat a Package példányokat, amelyeknél legalább a megadott számú nap telt el az utolsó
        
        public Package[] CollectStaleShipments(int Days)
        {
            int goodPackages = 0;
            for (int i = 0; i < PackageList.Count; i++) 
            {
                if (PackageList[i].DaysSinceLastUpdate() >= Days)
                {
                    goodPackages++;
                }
            }

            Package[] DaysSinceLastTrackUpdate = new Package[goodPackages];
            int index = 0;
            for(int i = 0; i < PackageList.Count; i++)
            {
                if (PackageList[i].DaysSinceLastUpdate() >= Days)
                {
                    DaysSinceLastTrackUpdate[index] = PackageList[i];
                    index++;
                }
            }
            return DaysSinceLastTrackUpdate;
        }

        //Készítsen egy MaximalWeightData nevű metódust, amely a legnagyobb tömegű csomag adataival (a
        //DataAsText által előállított karakterlánccal) tér vissza.Ha több azonos, maximális tömegű csomag van, az adathalmazban
        //legelőször előfordulót válassza.

        public string MaximalWeightData()
        {
            Package MaxweightPackage = PackageList[0];

            foreach (Package package in PackageList)
            {
                if(package.WeightKg > MaxweightPackage.WeightKg)
                {
                    MaxweightPackage = package;
                }
               
            }
            return MaxweightPackage.DataAsText();

        }

        /*
        Készítsen egy DistributionOfDeliveryMethod nevű metódust, amely meghatározza a paraméterként átadott
        DeliveryMethod értékkel rendelkező csomagok országok szerinti százalékos megoszlását. A visszatérési érték
        egyetlen, az alábbihoz hasonló formátumú karakterlánc legyen:
        
        
        -- Distribution of Locker --
        Austria: 9.41%
        Belgium: 7.92%
        Croatia: 10.89%
        ...
        Sweden: 10.56%
        
        
        Minden felsorolt célország szerepeljen az eredményben, a DestinationCountry enum sorrendjében. Az egyes százalékok
        számításakor a nevező az adott kézbesítési móddal rendelkező összes csomag száma, nem pedig az összes csomagé.
        Az arányokat két tizedesjeggyel jelenítse meg.
        */

        public string DistributionOfDeliveryMethod(DeliveryMethod method)
        {
            double total = 0;
            int[] counts = new int[11];
            foreach (Package package in PackageList)
            {
                if(package.DeliveryMethod == method)
                {
                    total++;
                    counts[(int)package.Country]++;
                }
            }

            string distribution = $"-- Distribution of {method} --\n";
            for (int i = 1; i < 11; i++)
            {
                DestinationCountry country = (DestinationCountry)i;
                double percentage;
                if(total > 0)
                {
                    
                    percentage = (counts[i] / total) * 100;
                }
                else
                {
                    percentage = 0;
                }
                
                distribution = distribution + ($"{country}: {percentage:F2}%\n");
            }
            return distribution;
        }
    }
}
