using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armada.Models
{
    public class Admiral
    {
        public int AdmiralId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime EnlistmentDate { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public AdmiralSpeciality Speciality { get; set; }
        //public EmperorSpecies Species { get; set; }

        public virtual ICollection<Mission> Missions { get; set; }

        //public Empire Empire { get; set; }
        
        public Crew Crew { get; set; }

    }
}