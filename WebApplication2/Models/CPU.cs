using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class CPU
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ushort Price { get; set; }

        public virtual string TitleImagePath { get; set; }

        public string Desc { get; set; }

        public string Lineika { get; set; }

        public string Socket { get; set; }

        public string YadroName { get; set; }

        public ushort YadroQuantity { get; set; }

        public ulong YadroCapacity { get; set; }

        public List<Finished_assembly> Finished_assembly { get; set; }
    }

}
