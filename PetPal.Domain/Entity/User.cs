using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPal.Domain.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PetPal.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

    }
}
