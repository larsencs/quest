using System;
using System.Collections.Generic;

namespace Quest
{
    class Program
    {
        static public void Main(string[] args)
        {

            Prize prize = new Prize("You win a set of steak knives");
            List<string> colors = new List<string>()
            {
                "red",
                "blue",
                "green",
                "orange"
            };
            Robe robe = new Robe{Colors=colors, Length=2};
            Hat hat = new Hat{ShininessLevel = 2};
            Console.Write("Enter your name: ");
            Adventurer theAdventurer = new Adventurer(Console.ReadLine(), robe, hat);
            Console.WriteLine(theAdventurer.GetDescription());

            PlayGame(theAdventurer);
            prize.ShowPrize(theAdventurer);
            Console.WriteLine();
            Console.Write("Would you like to play again? Yes/No: " );
            string answer = Console.ReadLine();

            while(answer.ToUpper() != "NO")
            {
                PlayGame(theAdventurer);
                Console.WriteLine();
                Console.Write("Would you like to play again? Yes/No: " );
                answer = Console.ReadLine();
            }

    }

    public static void PlayGame(Adventurer theAdventurer)
    {
        int minAwesomeness = 0;
        int maxAwesomeness = 100;
        List<Challenge> challenges = ChallengeList();


            foreach(Challenge challenge in challenges)
            {
                challenge.RunChallenge(theAdventurer);
            }

            if(theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("You did it! You are truly awesome!");
                theAdventurer.Successes++;
            }
            else if(theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me.");
            }
            else
            {
                Console.WriteLine("I guess you did ...ok? ...sorta. Still, you should get out of my sight.");
            }


    }

    public static void CreateCharacter(string name)
    {


    }

    public static List<Challenge> ChallengeList()
    {
            Challenge twoPlusTwo = new Challenge("2+2", 4, 10);
            Challenge theAnswer = new Challenge("What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge("What is the current second?", DateTime.Now.Second, 50);
            Challenge swallow = new Challenge("What is the airspeed velocity of an unladen swallow?", 24, 100);
            Challenge fingers = new Challenge("How many fingers am I holding up?", 0, 10);

            int randomNumber = new Random().Next() %10;

            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);
            Challenge favoriteBeatle = new Challenge(
            @"Who's your favorite Beatle?
            1) John
            2) Paul
            3) George
            4) Ringo
                ",
                4, 20
            );

            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                swallow,
                 fingers
            };

            List<int> indexes = new List<int>();
            List<Challenge> randomChallenges = new List<Challenge>();

            Random random = new Random();
            

            while(randomChallenges.Count < 5)
            {
                int index = random.Next(0, challenges.Count);
                if(!indexes.Contains(index))
                {
                    indexes.Add(index);
                    randomChallenges.Add(challenges[index]);
                }
                
            }

            
            return randomChallenges;

    }

}

}