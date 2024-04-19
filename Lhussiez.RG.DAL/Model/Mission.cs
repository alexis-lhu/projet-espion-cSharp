using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhussiez.RG.DAL.Model
{
    public class Mission
    {
        public int Id { set; get; }

        public string Ville { get; set; }

        public int Année { get; set; }

        public Espion? Espion { get; set; }
        public int? EspionId { get; set; }
        public Mission() { }

        public Mission(string ville, int annee) 
        {
            this.Ville = ville;
            this.Année = annee;
        }

    }
}
