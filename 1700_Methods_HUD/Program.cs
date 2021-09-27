using System;

namespace _1700_Methods_HUD
{
    class Program
    {
        static float Score;
        static int Health;
        static int Shields;
        static int Lives;
        static float ScoreMultiplier;
        static int Headshot;
        static int Bodyshot;
        static string firstName;
        static string lastName;
        static string fullName;
        static float enemyKill;
        static int healHealth;
        static int healShields;
        static float Banana;
        static int baseHealth;
        static int baseShields;




        static void ShowHUD()
        {
            Console.WriteLine("Banana Brain Studios Presents: ");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

        }

        static void AddBanana()
        {
            ScoreMultiplier = ScoreMultiplier + Banana;
        }

        static void Die()
        {
            Shields = baseShields;
            Health = baseHealth;
            Lives = Lives - 1;

        }

        static void AddScore(int Score)
        {
            
            Score =(int) (Score + enemyKill);
        }

      

        static void Main(string[] args)
        {
            {
                
                
               
                
                baseShields = 150;
                baseHealth = 100;
                Banana = 0.75f;
                healShields = 50;
                healHealth = 25;
                enemyKill = 50.0f;
                firstName = "Monkey";
                lastName = "Lad";
                fullName = firstName + " " + lastName;
                Headshot = 50;
                Bodyshot = 25;
                ScoreMultiplier = 1.0f;
                Lives = 5;
                Shields = 150;
                Health = 100;
                Score = 0.0f;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("Go get your bananas back from the aliens " + fullName);
                Console.WriteLine(" ");

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill two aliens and take one hit to the chest");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                Score = (Score + enemyKill + enemyKill * ScoreMultiplier);
                Shields = Shields - Bodyshot;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill one alien and you take two hits to the head, you also find one of your bananas");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddBanana();
                Score = (Score + enemyKill * ScoreMultiplier);
                Shields = Shields - Headshot - Headshot;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You take one shot to the body and two shots to the head and die, losing a life");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                Die();


                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill three enemies and you find another banana taking one shot to the head in the process");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddBanana();
                AddScore(3);
                Score = Score * ScoreMultiplier;
                Shields = Shields - Headshot;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill one enemy and take two shots to the head and one to the body");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                Score = Score + enemyKill;
                Shields = Shields - Headshot;
                Shields = Shields - Headshot;
                Health = Health - Bodyshot;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You find a monkey biscuit that heals some of your health and find another banana");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                Health = Health + healHealth;
                AddBanana();
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You find a Monkey shield that repairs some of your shields and kill one enemy");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                Shields = Shields + healShields;
                Score = Score + enemyKill;
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You find your last 2 Bananas and kill three enemies guarding them");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddBanana();
                AddBanana();
                Score = Score + enemyKill;
                Score = Score + enemyKill;
                Score = Score + enemyKill;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("YOU WIN");
                Console.WriteLine("ENJOY YOUR BANANAS");
                Console.WriteLine(" ");

                Console.ReadKey(true);
            }
        }
    }
}
