using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_gyak_1
{
    internal class Spaceship
    {
        string Name { get; }
        ShipClassType ShipClassType { get; }
        int Crew_number { get; }
        CrewStatusType CrewStatusType { get; }
        int CargoWeight { get; }
        DateTime LastMessage { get; }

        public Spaceship(string output)
        {
            string[] output_parts = output.Split(";");
            Name = output_parts[0];
            ShipClassType = (ShipClassType)Enum.Parse(typeof(ShipClassType), output_parts[1]);
            Crew_number = int.Parse(output_parts[2]);
            CrewStatusType = (CrewStatusType)Enum.Parse(typeof(CrewStatusType), output_parts[3]);
            CargoWeight = int.Parse(output_parts[4]);
            LastMessage = DateTime.Parse(output_parts[5]);

        }

        private int DaysSinceLastMessage(DateTime date)
        {

            int lastMessage = Math.Max(0,(date-LastMessage).Days);

           return lastMessage;
        }

        public bool NeedsRescue(DateTime date)
        {
            bool sendRescue = false;
            if (CrewStatusType == CrewStatusType.MissingInAction || CrewStatusType == CrewStatusType.Deceased || (CrewStatusType == CrewStatusType.Active && (DaysSinceLastMessage(date)) > 30) || (CrewStatusType == CrewStatusType.InCryosleep && (DaysSinceLastMessage(date)) > 3650))
            {
                sendRescue = true;
            }

            return sendRescue;
        }
        public override string ToString()
        {
            return $"{Name} ({ShipClassType})";
        }

        public string GetStatusReport(DateTime date)
        {
            return ($"=== {ToString()} === \n Crew:{Crew_number} ({CrewStatusType}) \n Last message: {DaysSinceLastMessage(date)} days \n Rescue needed: {(NeedsRescue(date)?"Yes":"No")}");
        }
    }
}
