using System;
using System.Collections.Generic;

namespace Armada.Entities
{
    public class Mission
    {
        public int MissionId { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsSuccess { get; set; }
        public Status Status { get; set; }

        //Navigation Properties
        public virtual ICollection<Admiral> Admirals { get; set; }
        public virtual ICollection<Planet> Planets { get; set; }

        public Mission()
        {
            Planets = new HashSet<Planet>();
            Admirals = new HashSet<Admiral>();
        }
    }
}