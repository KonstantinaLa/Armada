using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armada.Models
{
    public class Empire
    {
        public int EmpireId { get; set; }
        public string Name { get; set; }
        public string Trait { get; set; }
        public int ControlledSystems { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        //Navigation Properties

        public int? EmperorId { get; set; }
        public virtual Emperor Emperor { get; set; }
        public virtual ICollection<Admiral> Admirals { get; set; }
    }
}