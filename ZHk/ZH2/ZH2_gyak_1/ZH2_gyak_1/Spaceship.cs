using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_gyak_1
{
    internal class Spaceship
    {
        public string Name { get { return name; } }
        public ShipClassType ShipClassType { get { return shipClassType; } }
        public int Crew_number { get { return crew_number; } }
        public CrewStatusType CrewStatusType { get { return crewStatusType; } }
        public int CargoWeight { get { return cargoweight; } }
        public DateTime LastMessage { get { return lastmessage; } }

        private string name;
        private ShipClassType shipClassType;
        private int crew_number;
        private CrewStatusType crewStatusType;
        private int cargoweight;
        private DateTime lastmessage;

        public Spaceship(string output)
        {
            string[] output_parts = output.Split(";");
            name = output_parts[0];
            shipClassType= (ShipClassType)Enum.Parse(typeof(ShipClassType), output_parts[1]);
            crew_number = int.Parse(output_parts[2]);
            crewStatusType= (CrewStatusType)Enum.Parse(typeof(CrewStatusType), output_parts[3]);
            cargoweight = int.Parse(output_parts[4]);
            lastmessage = DateTime.Parse(output_parts[5]);

            

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
            return ($"=== {ToString()} === \n Crew: {Crew_number} ({CrewStatusType}) \n Last message: {DaysSinceLastMessage(date)} days \n Rescue needed: {(NeedsRescue(date)?"Yes":"No")}");
        }
    }
}
