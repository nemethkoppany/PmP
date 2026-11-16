using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor11_ZHGyak
{
    public enum DestinationCountry
    {
        Austria = 1, Belgium = 2, Croatia = 3, CzechRepublic = 4,
        Denmark = 5, Hungary = 6, Netherlands = 7, Poland = 8,
        Slovakia = 9, Sweden = 10
    }

    public enum ServiceLevel
    {
        Economy, Express, Standard
    }

    public enum DeliveryMethod
    {
        Courier, Locker, PickupPoint, PostOffice
    }
    internal class Package
    {
        public int id { get;}
        public ServiceLevel level { get; set; }
        public int fee { get; set; }
        public DateTime sendDate { get; }
        public DateTime TrackerUpdateDate { get;}
        public DestinationCountry country { get; }
        public int weight { get; }
        public DeliveryMethod method { get; }

        public Package(string characterString)
        {
            this.id = id;
            this.level = level;
            this.fee = fee; 
            this.sendDate = sendDate;
            this.TrackerUpdateDate = TrackerUpdateDate;
            this.country = country;
            this.weight = weight;
            this.method = method;
            characterString = (id, level,  fee, sendDate, TrackerUpdateDate, country, weight, method).ToString();
        }

        public int DaysInTransit()
        {
            int transitDays = (DateTime.Today - sendDate.Date).Days;
            return transitDays;
        }

        public int DaysSinceLastUpdate()
        {
            int updateDate = (DateTime.Today- TrackerUpdateDate.Date).Days;
            return updateDate;
        }

        public string DataAsText()
        {
            return ($"ID:{this.id} ({this.country},{this.level},{this.method}). Transit:{DaysInTransit()} days, last update: {DaysSinceLastUpdate()} days");
        }
        // Az InvariantCulture miatt a feldolgozás nem függ attól,
        // hogy a számítógépen magyar vagy más területi beállítás van.
        //variable = DateTime.ParseExact(
        //data, "yyyy-MM-dd", CultureInfo.InvariantCulture);
    }
}
