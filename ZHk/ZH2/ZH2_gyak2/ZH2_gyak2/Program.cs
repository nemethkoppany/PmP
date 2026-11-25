namespace ZH2_gyak2
{
    enum ShipClassType
    {
        Cargo, Military, Research, Mining, Colonial, Rescue
    }

    enum CrewStatusType
    {
        Active = 1, InCryosleep = 2, MissingInAction = 3, Deceased = 4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         FleetHandler handler = new FleetHandler("weyland-yutani.csv");
          handler.GenerateReport();
        }
    }
}
