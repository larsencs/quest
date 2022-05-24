namespace Quest{

    public class Adventurer
    {
        public string Name {get;}
        public int Awesomeness {get; set;}
        
        public Adventurer(string name)
        {
            this.Name = name;
            this.Awesomeness = 50;
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
    }
}