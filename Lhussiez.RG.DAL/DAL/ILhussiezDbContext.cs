using Lhussiez.RG.DAL.Model;

namespace Lhussiez.RG.DAL.DAL
{
    public interface ILhussiezDbContext
    {
        List<Espion> GetEspions();
        List<Mission> GetMissions();
        Espion AddEspion(string nom, string nomdecode);
        Mission AddMission(string ville, int annee);
        List<Mission> GetEspionMission(Espion espion);
        void AddMissionToEspion(Espion espion, Mission mission);
    }

}