using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor11_ZHGyak
{
    internal class Dataset
    {
         new List<string> PackageList {  get; }
        public int Sum { get
            {
                return PackageList.Count;
            } }
        public Dataset(string FileName)
        {
           string[] lines =  File.ReadAllLines(FileName);
            List<string> packageParts = new List<string>();
            for(int i = 1; i < lines.Length; i++)
            {
                Package package = new Package(lines[i]);
                PackageList.Add(package.ToString());
            }

            
            foreach(string line in lines)
            {
                string[] parts = line.Split(",");
                Package p = new Package(parts[0]);
                p.fee = int.Parse(parts[2]);
                sumParts.Add(p);

            }
        }
        List<Package> sumParts = new List<Package>();

        public double AverageShippingFee(ServiceLevel level)
        {
            if (level == ServiceLevel.Economy)
            {
                double ElevelSum = 0;
                foreach (Package line in sumParts)
                {
                    if (line.level == ServiceLevel.Economy)
                    {
                        ElevelSum += line.fee;
                    }
                }

                return ElevelSum;
            }
            else if(level == ServiceLevel.Express)
            {
                double ElevelSum = 0;
                foreach (Package line in sumParts)
                {
                    if (line.level == ServiceLevel.Express)
                    {
                        ElevelSum += line.fee;
                    }
                }
                return ElevelSum;
            }
            else if (level == ServiceLevel.Standard)
            {
                double SlevelSum = 0;
                foreach (Package line in sumParts)
                {
                    if (line.level == ServiceLevel.Standard)
                    {
                        SlevelSum += line.fee;
                    }
                }
                return SlevelSum;
            }

            return 67;
        }
    }
}
