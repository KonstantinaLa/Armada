using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armada.Models
{
    public class Crew
    {
        public int CrewId { get; set; }
        public int Number { get; set; }
        public string Specialty { get; set; }

        public Admiral Admiral { get; set; }

    }
}