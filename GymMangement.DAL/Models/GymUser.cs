using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.Models
{
    internal class GymUser : baseEntity

    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string phonenumber { get; set; } = default!;
        public DateOnly dateofBirth { get; set; } = default!; 
        public string phoneNumber { get; set; }= default!;
        public Enums.Gender Gender { get; set; }
        public Adress Address { get; set; } = default!;
    }
    [Owned]
    public class Adress
    {
        public string Street { get; set; }= default!;
        public string City { get; set; }=default!;
        public int number { get; set; } = default!;
    }
}
