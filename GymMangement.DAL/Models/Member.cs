using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.Models
{
    internal class Member : GymUser
    {
        public string? photo { get; set; }
        public string? HealthRecord { get; set; }
        //JionDate ==createdAt

    }
}
