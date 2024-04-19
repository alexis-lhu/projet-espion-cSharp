using Lhussiez.RG.DAL.DAL;
using Lhussiez.RG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lhussiez.RG.DAL.Service
{
    public class LhussiezRGService : ILhussiezRGService
    {
        private ILhussiezDbContext _lhussiezDbContext;

        public LhussiezRGService(ILhussiezDbContext lhussiezDbContext)
        {
            _lhussiezDbContext = lhussiezDbContext;
        }

        public Espion AddEspion(string nom, string nomdecode)
        {
            return _lhussiezDbContext.AddEspion(nom, nomdecode);
        }

        public Mission AddMission(string ville, int annee)
        {
            return _lhussiezDbContext.AddMission(ville, annee);
        }
        public List<Espion> GetEspions()
        {
            return _lhussiezDbContext.GetEspions();
        }
        public List<Mission> GetMissions()
        {
            return _lhussiezDbContext.GetMissions();
        }
        public List<Mission> GetEspionMission(Espion espion)
        {
            return _lhussiezDbContext.GetEspionMission(espion); 
        }
        public void AddMissionToEspion(Espion espion, Mission mission) => _lhussiezDbContext.AddMissionToEspion(espion, mission);

        public Espion GetEspionsByVille(string ville)
        {
            Mission missionEspion = (Mission)this._lhussiezDbContext.GetMissions().Where(mission => mission.Ville == ville);
            int idmissionespion = missionEspion.Id;
            Espion espionVille = (Espion)this._lhussiezDbContext.GetEspions().Where(espion => espion.Id == idmissionespion);
            return espionVille;
        }
    }
}
