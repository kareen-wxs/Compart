using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Finished_assembly
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string PURPOSE { get; set; }
        public string BRAND { get; set; }

        public List <CPU> CPU { get; set; }
        
        public List <Matplata> Matplata { get; set; }
        
        public List <GPU> GPU { get; set; }
        
        public List <BP> BP { get; set; }

        public List <Case> Case { get; set; }

        public List <ColvoMemory> ColvoMemory { get; set; }

        public List <Cooler> Cooler { get; set; }

        public List <CoolingSystem> CoolingSystem { get; set; }

        public List <NetworkCard> NetworkCard { get; set; }

        public List <RAM> RAM { get; set; }

        public List <TypeOfMemory> TypeOfMemory { get; set; }

        public List <VoiceCard> VoiceCard { get; set; }
        
        public List <DVD> DVD{ get; set; }

    }
}