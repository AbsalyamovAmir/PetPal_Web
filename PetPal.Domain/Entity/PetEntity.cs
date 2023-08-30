using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPal.Domain.Entity
{
    public class PetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public string OwnerName { get; set; }
        public string Description { get; set; }
    }
}
