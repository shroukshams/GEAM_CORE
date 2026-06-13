using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace GymMangement.DAL.Models
{
    internal class baseEntity
    {
        public int ID { get; set; }
        public TimeOnly createdAt { get; set; }
        public TimeOnly updatedAt { get; set; }
    }
}
