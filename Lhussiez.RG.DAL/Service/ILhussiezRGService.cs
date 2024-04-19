using Lhussiez.RG.DAL.Model;

namespace Lhussiez.RG.DAL.Service
{
    public interface ILhussiezRGService
    {
        Espion AddEspion(string nom, string nomdecode);
        Mission AddMission(string ville, int annee);
        List<Espion> GetEspions();
        List<Mission> GetMissions();
        List<Mission> GetEspionMission(Espion espion);
        void AddMissionToEspion(Espion espion, Mission mission);
        Espion GetEspionsByVille(string ville);
    }
}