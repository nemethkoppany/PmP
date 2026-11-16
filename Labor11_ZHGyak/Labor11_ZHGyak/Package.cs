using System;
using System.Globalization;

namespace Labor11_ZHGyak
{
    public enum DestinationCountry
    {
        Austria = 1, Belgium = 2, Croatia = 3, CzechRepublic = 4,
        Denmark = 5, Hungary = 6, Netherlands = 7, Poland = 8,
        Slovakia = 9, Sweden = 10
    }

    public enum ServiceLevel { Economy, Express, Standard }

    public enum DeliveryMethod { Courier, Locker, PickupPoint, PostOffice }

    internal class Package
    {
        private int id;
        private ServiceLevel serviceLevel;
        private int shippingFee;
        private DateTime shippedAt;
        private DateTime lastUpdateAt;
        private DestinationCountry country;
        private int weightKg;
        private DeliveryMethod deliveryMethod;

        public int Id { get { return id; } }
        public ServiceLevel ServiceLevel { get { return serviceLevel; } }
        public int ShippingFee { get { return shippingFee; } }
        public DateTime ShippedAt { get { return shippedAt; } }
        public DateTime LastUpdateAt { get { return lastUpdateAt; } }
        public DestinationCountry Country { get { return country; } }
        public int WeightKg { get { return weightKg; } }
        public DeliveryMethod DeliveryMethod { get { return deliveryMethod; } }

        public Package(string line)
        {
            string[] parts = line.Split(',');
            id = int.Parse(parts[0]);
            serviceLevel = (ServiceLevel)Enum.Parse(typeof(ServiceLevel), parts[1]);
            shippingFee = int.Parse(parts[2]);
            shippedAt = DateTime.Parse(parts[3]);
            lastUpdateAt = DateTime.Parse(parts[4]);
            country = (DestinationCountry)Enum.Parse(typeof(DestinationCountry), parts[5]);
            weightKg = int.Parse(parts[6]);
            deliveryMethod = (DeliveryMethod)Enum.Parse(typeof(DeliveryMethod), parts[7]);
        }

        public int DaysInTransit()
        {
            return (DateTime.Today - shippedAt.Date).Days;
        }

        public int DaysSinceLastUpdate()
        {
            return (DateTime.Today - lastUpdateAt.Date).Days;
        }

        public string DataAsText()
        {
            return $"ID: {id} ({country}, {serviceLevel}, {deliveryMethod}). " +
                   $"Transit: {DaysInTransit()} days, last update: {DaysSinceLastUpdate()} days.";
        }
    }
}