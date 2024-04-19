using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhussiez.RG.DAL.Model
{
    public class Espion
    {
        public int Id { set; get; }

        [MaxLength(30)]
        public string Nom { get; set; }

        [MaxLength(50)]
        public string NomDeCode { get; set; }

        public List<Mission> Missions { get; set; }

        public Espion() { }

        public Espion(string nom, string nomdecode)
        {
            this.Nom = nom;
            this.NomDeCode = nomdecode;
        }

        public Espion(string nom, string nomdecode, List<Mission> missions) 
        {
            this.Nom = nom;
            this.NomDeCode = nomdecode;
            this.Missions = missions;
        }
    }
}
