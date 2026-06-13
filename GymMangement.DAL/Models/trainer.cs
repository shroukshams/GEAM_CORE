using GymMangement.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.Models
{
    internal class trainer : GymUser
    {
        //hireDate == createdAt
        public specialty? specialty { get; set; }
    }
}
