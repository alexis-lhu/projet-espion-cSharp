using Lhussiez.RG.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lhussiez.RG.DAL.DAL
{
    public class LhussiezDbContext : DbContext, ILhussiezDbContext
    {
        public DbSet<Espion> Espions { get; set; }
        public DbSet<Mission> Missions { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=espioncsharp;Uid=root;Pwd=;";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 32));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        public List<Espion> GetEspions()
        {
            return this.Espions.ToList();
        }

        public List<Mission> GetEspionMission(Espion espion)
        {
            return [.. espion.Missions];
        }

        public List<Mission> GetMissions()
        {
            return this.Missions.ToList();
        }

        public Espion AddEspion(string nom, string nomdecode)
        {
            Espion espion = new Espion(nom, nomdecode);
            this.Espions.Add(espion);
            this.SaveChanges();
            return espion;
        }

        public Mission AddMission(string ville, int annee)
        {
            Mission mission = new Mission(ville, annee);
            this.Missions.Add(mission);
            this.SaveChanges();
            return mission;
        }


        public void AddMissionToEspion(Espion espion , Mission mission)
        {
            List<Mission> missionsEspion = GetEspionMission(espion);
            if (missionsEspion.Count != 0)
            {
                if (!missionsEspion.Contains(mission))
                {
                    espion.Missions.Add(mission);
                    mission.EspionId = espion.Id;
                    this.SaveChanges();
                }
            }
        }

        

    }
}
