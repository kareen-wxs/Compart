﻿using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class TypeOfMemory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ushort Price { get; set; }

        public virtual string TitleImagePath { get; set; }

        public string Desc { get; set; }

        public bool HddOrSsd { get; set; }

        public List<Finished_assembly> Finished_assembly { get; set; }
    }
}
