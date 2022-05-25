using System;

namespace Quest
{
    public class Prize
    {
        private static string _text;

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adventurer)
        {
            if(adventurer.Awesomeness > 0)
            {
                for(int i = 0; i < adventurer.Awesomeness; i++)
                {
                    Console.WriteLine(_text);
                }

            }
            else if(adventurer.Awesomeness <= 0)
            {
                Console.WriteLine("You get nothing! Good day, sir!");
            }
        }
    }
}