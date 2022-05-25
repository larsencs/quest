using System;
using System.Collections.Generic;

namespace Quest{

    public class Adventurer
    {
        public string Name {get; set;}
        public int Awesomeness {get; set;}
        public int Successes {get; set;}

        Robe ColorfulRobe {get;}
        Hat AdventurerHat {get;}
        
        public Adventurer(string name, Robe robe, Hat hat)
        {
            Name = name;
            Awesomeness = (Successes * 10) + 50;
            ColorfulRobe = robe;
            AdventurerHat = hat;
            
        }

        public string GetAdventurerStatus()
        {
            string status = "okay";

            if(Awesomeness >= 75)
            {
                status = "great";
            }
            else if(Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "barely hanging on";
            }
            else if(Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name} is {status}";
        }

        public string GetDescription()
        {
            string colors = "";
            for(int i = 0; i< ColorfulRobe.Colors.Count; i++)
            {
                if(i == 0)
                {
                    colors += $"{ColorfulRobe.Colors[i]}";
                }
                else if(i == ColorfulRobe.Colors.Count-1)
                {
                    colors += $", and {ColorfulRobe.Colors[i]}";
                }
                else
                {
                    colors += $", {ColorfulRobe.Colors[i]}";
                }
            }

            return $"{Name} is wearing a {colors} color robe of length {ColorfulRobe.Length}, as well as a {AdventurerHat.ShininessDescription()} hat.";
        }
    }
}