using System;

namespace _1700_Methods_HUD
{
    class Program
    {
        static float Score;
        static int Health;
        static int Lives;
        static float ScoreMultiplier;
        static string firstName;
        static string lastName;
        static string fullName;
        static float enemyKill;
        static int healHealth;
        static float Banana;
        static int baseHealth;
        static int Damage;




        static void ShowHUD()
        {
            Console.WriteLine("Banana Brain Studios Presents: ");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

        }

        static void AddBanana()
        {
            ScoreMultiplier = ScoreMultiplier + Banana;
        }

        static void Die()
        {
            Health = baseHealth;
            Lives = Lives - 1;

        }

        static void AddScore()
        {

            Score = Score + enemyKill;
      
        }

        static void calcDamage()
        {
            Random rnd = new Random();

            for(int j = 0; j < 1; j++)
            {
                
                Damage = (rnd.Next(10, 30));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Damage Taken: " + Damage);
                Console.ResetColor();
                
            }
            
        }

        static void takeDamage()
        {
            calcDamage();
            Health = Health - Damage;
            if(Health <= 0)
            {
                Die();
            }
        }

        static void heal()
        {
            Health = Health + healHealth;
        }


      

        static void Main(string[] args)
        {
            {

                
                
               
                
                baseHealth = 150;
                Banana = 0.75f;
                healHealth = 25;
                enemyKill = 50.0f;
                firstName = "Monkey";
                lastName = "Lad";
                fullName = firstName + " " + lastName;
                ScoreMultiplier = 1.0f;
                Lives = 5;
                Health = 150;
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

                takeDamage();
                AddScore();
                AddScore();

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill one alien and you take two hits to the head, you also find one of your bananas");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddBanana();
                AddScore();
                takeDamage();
                takeDamage();
                Score = Score * ScoreMultiplier;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You take one shot to the body and two shots to the head");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                takeDamage();
                takeDamage();
                takeDamage();


                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill three enemies and you find another banana taking one shot to the head in the process");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddBanana();
                AddScore();
                AddScore();
                AddScore();
                Score = Score * ScoreMultiplier;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You kill one enemy and take two shots to the head and one to the body");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddScore();
                takeDamage();
                takeDamage();
                takeDamage();

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You find a monkey biscuit that heals some of your health and find another banana");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                heal();
                AddBanana();
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You find a Monkey shield that repairs some of your shields and kill one enemy");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddScore();
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine(" ");
                Console.WriteLine("You find your last 2 Bananas and kill three enemies guarding them");
                Console.WriteLine(" ");
                Console.WriteLine("--------------");

                AddBanana();
                AddBanana();
                AddScore();
                AddScore();
                AddScore();

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
