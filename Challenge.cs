using System;

namespace Quest{
    
    public class Challenge
    {
        private string _text;
        private int _correctAnswer;
        private int _awesomenessChange;

        public Challenge(string text, int correctAnswer, int awesomenessChange)
        {
            this._text = text;
            this._correctAnswer = correctAnswer;
            this._awesomenessChange = awesomenessChange;
        }

        public void RunChallenge(Adventurer adventurer)
        {
            Console.Write($"{_text}: ");
            string answer = Console.ReadLine();

            int numAnswer;
            bool isNumber = int.TryParse(answer, out numAnswer);

            Console.WriteLine();

            if(isNumber && numAnswer == _correctAnswer)
            {
                Console.WriteLine("Well Done!");

                adventurer.Awesomeness += _awesomenessChange;
            }
            else
            {
                Console.WriteLine("You have failed the challenge. There will be consequences.");
                adventurer.Awesomeness -= _awesomenessChange;
            }


            //Wouldn't a toString be better here?
            Console.WriteLine(adventurer.GetAdventurerStatus());
            Console.WriteLine();

        }
    }
}