using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_gyak2
{
    internal class FleetHandler
    {
        List<SpaceShip> shipList;
        DateTime currentTime;
        public int TotalShipCount {  get { return shipList.Count; } }
        public bool HasAnyDeceasedCrew { get
            {
                foreach (SpaceShip ship in shipList)
                {
                    if (ship.StatusType == CrewStatusType.Deceased)
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
            currentTime = DateTime.Parse(lines[0]);
            shipList = new List<SpaceShip>();
            for (int i = 1; i < lines.Length; i++)
            {
                SpaceShip ship = new SpaceShip(lines[i]);
                shipList.Add(ship);
                
            }
        }

        public double AverageCargo(ShipClassType shipClass)
        {
            double weight = 0;
            int cargo_ships = 0;
            foreach (SpaceShip ship in shipList)
            {
                if(ship.ClassType == shipClass)
                {
                    weight += ship.CargoWeight;
                    cargo_ships++;
                }
            }

            if(cargo_ships == 0)
            {
                return 0;
            }
            else
            {
                return weight / cargo_ships;
            }
            
        }

        public SpaceShip[] GetShipsGroupByRisk()
        {
            List<SpaceShip> highRisk = new List<SpaceShip>();
            List<SpaceShip> lowRisk = new List<SpaceShip>();

            foreach (SpaceShip ship in shipList)
            {
                if((ship.ClassType == ShipClassType.Cargo || ship.ClassType == ShipClassType.Rescue)&& ship.NeedsRescue(currentTime) == true)
                {
                    highRisk.Add(ship);
                }
                else
                {
                    lowRisk.Add(ship);
                }
            }

            SpaceShip[] shipsByRisk = new SpaceShip[shipList.Count];
            for(int i = 0; i < shipsByRisk.Length; i++)
            {
                if(i < highRisk.Count)
                {
                    shipsByRisk[i] = highRisk[i];
                }
                else
                {
                    shipsByRisk[i] = lowRisk[i - highRisk.Count];
                }

            }
            return shipsByRisk;

            
        }
        public string GetLargestCrewData(CrewStatusType status)
        {
            SpaceShip BestShip = null;
            foreach (SpaceShip ship in shipList)
            {
                if(ship.StatusType == status)
                {
                    if(BestShip == null || ship.CrewNumber > BestShip.CrewNumber)
                    {
                        BestShip = ship;
                    }
                }
            }
            if(BestShip == null)
            {
                return "";
            }
            else
            {
                return BestShip.GetStatusReport(currentTime);
            }
        }

        public void GenerateReport()
        {
            Console.WriteLine($"Current date is {currentTime}. \nTotal ship count is: {shipList.Count}\n");
            Console.WriteLine("Average cargo by ship types: ");
            foreach (ShipClassType type in Enum.GetValues(typeof(ShipClassType)))
            {
                Console.WriteLine($"  {type}: {AverageCargo(type)}");
            }
            Console.WriteLine($"Detailed info sorted by risk: ");
            SpaceShip[] ship = GetShipsGroupByRisk();
            foreach (SpaceShip sh in ship)
            {
                Console.WriteLine(sh.GetStatusReport(currentTime));

            }
        }

    }
}
