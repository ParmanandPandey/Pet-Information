using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Information.DataAccess.Entities
{
    public class Pet
    {
        public int PetId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
