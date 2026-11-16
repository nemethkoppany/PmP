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
        }

        public double AverageShippingFee(ServiceLevel level)
        {
          if(level == ServiceLevel.Economy)
            {
                
            }
        }
    }
}
