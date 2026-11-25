using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_gyak2
{
    internal class SpaceShip
    {
        private string name;
        private ShipClassType classType;
        private int crew_number;
        private CrewStatusType statusType;
        private int cargoWeight;
        private DateTime lastMessage;

        public string Name {  get { return name; }}
        public ShipClassType ClassType { get { return classType; }}
        public int CrewNumber { get { return crew_number; }}
        public CrewStatusType StatusType { get {return statusType; }}
        public int CargoWeight {  get { return cargoWeight; }}
        public DateTime LastMessage { get { return lastMessage; }}

        public SpaceShip(string data)
        {
            string[] parts = data.Split(";");
            name = parts[0];
            classType = (ShipClassType)Enum.Parse(typeof(ShipClassType), parts[1]);
            crew_number = int.Parse(parts[2]);
            statusType = (CrewStatusType)Enum.Parse(typeof(CrewStatusType),parts[3]);
            cargoWeight = int.Parse(parts[4]);
            lastMessage = DateTime.Parse(parts[5]);
        }

        private int DaysSinceLastMessage(DateTime date)
        {
            return (date - lastMessage).Days;
        }

        public bool NeedsRescue(DateTime date)
        {
            bool NeedsRescue = false;
            if(statusType == CrewStatusType.Deceased || statusType == CrewStatusType.MissingInAction || (statusType == CrewStatusType.Active && DaysSinceLastMessage(date) > 30) || (statusType == CrewStatusType.InCryosleep && DaysSinceLastMessage(date) > 3650))
            {
                return NeedsRescue = true;
            }
            return NeedsRescue;
        }

        public override string ToString()
        {
            return $"{name} ({classType})";
        }

        public string GetStatusReport(DateTime date)
        {
            return $"=== {ToString()} ===\n Crew: {crew_number} ({statusType})\n Last message: {DaysSinceLastMessage(date)} days\n Rescue needed: {(NeedsRescue(date)?"Yes":"No")}";
        }
    }
}
