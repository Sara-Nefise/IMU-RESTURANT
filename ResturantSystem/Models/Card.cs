using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantSystem.Models
{
    public class Card
    {
        public string Id { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
    }
}
