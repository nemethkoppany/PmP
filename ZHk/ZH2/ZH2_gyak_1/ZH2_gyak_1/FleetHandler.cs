using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_gyak_1
{
    internal class FleetHandler
    {
        private List<Spaceship> SpaceShips;
        private DateTime CurrentTime;
        public int TotalShipCount { get { return SpaceShips.Count; } }
        public bool HasAnyDeceasedCrew { get {
                foreach (Spaceship ship in SpaceShips)
                {
                    if (ship.CrewStatusType == CrewStatusType.Deceased)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public FleetHandler(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            CurrentTime = DateTime.Parse(lines[0]);
            SpaceShips = new List<Spaceship>();
            for(int i = 1; i < lines.Length; i++)
            {
               Spaceship ship = new Spaceship(lines[i]);
                SpaceShips.Add(ship);
            }

            
        }

        public double AverageCargo(ShipClassType shipClass)
        {
            int numberofCargo = 0;
            double totalCargo = 0;
            foreach (Spaceship ship in SpaceShips)
            {
                if(ship.ShipClassType == shipClass)
                {
                    numberofCargo++;
                    totalCargo+=ship.CargoWeight;
                }
                
            }
            if(numberofCargo == 0)
            {
                return 0;
            }
            else
            {
                return totalCargo / numberofCargo;
            }
            
        }

        public Spaceship[] GetShipsGroupByRisk()
        {
            List<Spaceship> highRisk = new List<Spaceship>();
            List<Spaceship> lowRisk = new List<Spaceship>();

            foreach (Spaceship sh in SpaceShips)
            {
                if((sh.ShipClassType == ShipClassType.Cargo || sh.ShipClassType == ShipClassType.Research)&& sh.NeedsRescue(CurrentTime))
                {
                    highRisk.Add(sh);
                }
                else
                {
                    lowRisk.Add(sh);
                }
            }

            Spaceship[] ships = new Spaceship[SpaceShips.Count];
            for(int i = 0; i < ships.Length; i++)
            {
                if (i < highRisk.Count)
                {
                    ships[i] = highRisk[i];
                }
                else
                {
                    ships[i]  = lowRisk[i - highRisk.Count];
                }
            }
            return ships;
        }

        public string GetLargestCrewData(CrewStatusType status)
        {
            Spaceship Bestship = null;

            foreach (Spaceship sh in SpaceShips)
            {
                if(sh.CrewStatusType == status)
                {
                    if(Bestship == null || sh.Crew_number > Bestship.Crew_number)
                    {
                        Bestship = sh;
                    }
                }
            }
            if(Bestship == null)
            {
                return "";
            }
            else
            {
                return Bestship.GetStatusReport(CurrentTime);
            }
        }

        public void GenerateReport()
        {
            Console.WriteLine($"Current date is {CurrentTime}. \nTotal ship count is: {SpaceShips.Count}\n");
            Console.WriteLine("Average cargo by ship types: ");
            foreach (ShipClassType type in Enum.GetValues(typeof(ShipClassType)))
            {
                Console.WriteLine($"  {type}: {AverageCargo(type)}");
            }
            Console.WriteLine($"Detailed info sorted by risk: ");
            Spaceship[] ship = GetShipsGroupByRisk();
            foreach(Spaceship sh in ship)
            {
                Console.WriteLine(sh.GetStatusReport(CurrentTime));
                
            }
        }

    }
}
