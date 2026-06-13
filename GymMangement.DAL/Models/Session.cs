using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.Models
{
    internal class Session:baseEntity
    {
        public string Description { get; set; } = default!;
        public int Capacity  { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
     
    }
}
