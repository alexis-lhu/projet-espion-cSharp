using Lhussiez.RG.DAL.DAL;
using Lhussiez.RG.DAL.Model;
using Lhussiez.RG.DAL.Service;


namespace Lhussiez.RG.Cli
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var db = new RG.DAL.DAL.LhussiezDbContext();
            var service = new LhussiezRGService(db);

            var espion1 = service.AddEspion("James Bond", "007");
            var espion2 = service.AddEspion("Etienne Divina", "Tortue Géniale");

            var mission1 = service.AddMission("Lille", 2020);
            var mission2 = service.AddMission("Dunkerque", 2017);
            var mission3 = service.AddMission("Calais", 2023);

            service.AddMissionToEspion(espion1, mission1);
            service.AddMissionToEspion(espion1, mission2);
            service.AddMissionToEspion(espion2, mission3);

        }
    }
}