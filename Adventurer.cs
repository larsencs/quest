namespace Quest{

    public class Adventurer
    {
        public string Name {get; set;}
        public int Awesomeness {get; set;}

        Robe ColorfulRobe {get; set;}
        
        public Adventurer(string name, Robe robe)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = robe;
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
            return $"{Name} is wearing a {ColorfulRobe.Colors} robe of length {ColorfulRobe.Length}";
        }
    }
}