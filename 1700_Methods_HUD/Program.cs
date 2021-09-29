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
        static float enemyKillValue;
        static int healHealth;
        static float Banana;
        static int baseHealth;
        static int damage;
        static float enemieskilled;
        static float pointgain;




        static void ShowHUD()
        {
            Console.WriteLine("==============");
            Console.WriteLine("Banana Brain Studios Presents: ");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);
            Console.WriteLine("==============");

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

        static void AddScore(float enemyKillValue)
        {

            Score = Score + pointgain;
      
        }

        static void calcDamage()
        {
            Random rnd = new Random();

            for(int j = 0; j < 1; j++)
            {
                damage = (rnd.Next(10, 30));
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Damage Taken: " + damage);
                Console.ResetColor();
                Console.WriteLine("==============");
            }
            
        }

        static void TakeDamage(int damage)
        {
            
            Health = Health - damage;
            if(Health <= 0)
            {
                Die();
            }
        }

        static void heal(int healHealth)
        {
            Health = Health + healHealth;
        }

        
        
        
        static void Pointsgained()
        {
            Random rnd = new Random();

            for (int j = 0; j < 1; j++)
            {
                enemieskilled = (rnd.Next(1, 3));
                pointgain = (enemieskilled * enemyKillValue) * ScoreMultiplier;
            }

            Console.WriteLine("==============");
            Console.WriteLine("Enemies Killed: " + enemieskilled);
            Console.WriteLine("Points Gained: " + (enemieskilled * 50f) * ScoreMultiplier);
            Console.WriteLine("==============");


        }


      

        static void Main(string[] args)
        {
            {

                
                
               
                
                baseHealth = 150;
                Banana = 0.75f;
                healHealth = 25;
                enemyKillValue = 50.0f;
                firstName = "Monkey";
                lastName = "Lad";
                fullName = firstName + " " + lastName;
                ScoreMultiplier = 1.0f;
                Lives = 5;
                Health = 150;
                Score = 0.0f;

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("Go get your bananas back from the aliens " + fullName);
                Console.WriteLine("--------------");

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take one hit to the chest");
                Console.WriteLine("--------------");


                // damage = ???
                //TakeDamage(damage);
                Pointsgained();
                calcDamage();
                TakeDamage(damage);
                AddScore(pointgain);

                // pointsGained = ???
                // scoreMultiplier = ???
                // AddScore(pointsGained, scoreMultiplier);


                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take two hits to the head, you also find one of your bananas");
                Console.WriteLine("--------------");

                AddBanana();
                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                Pointsgained();
                AddScore(pointgain);
                 // incorrect (only apply to incoming points)

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take one shot to the body and two shots to the head");
                Console.WriteLine("--------------");

                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                Pointsgained();
                AddScore(pointgain);


                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You find another banana, taking one shot to the head in the process");
                Console.WriteLine("--------------");

                AddBanana();
                calcDamage();
                TakeDamage(damage);


                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take two shots to the head and one to the body");
                Console.WriteLine("--------------");

                Pointsgained();
                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                AddScore(pointgain);

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You find a monkey biscuit that heals some of your health and find another banana");
                Console.WriteLine("--------------");

                heal(healHealth);
                AddBanana();
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take two shots");
                Console.WriteLine("--------------");
                
                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                Pointsgained();
                AddScore(pointgain);
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You find your last 2 Bananas");
                Console.WriteLine("--------------");

                AddBanana();
                AddBanana();

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("----------------------------");
                Console.WriteLine("----------------------------");
                Console.WriteLine("YOU WIN");
                Console.WriteLine("ENJOY YOUR BANANAS");
                Console.WriteLine("----------------------------");
                Console.WriteLine("----------------------------");

                Console.ReadKey(true);
            }
        }
    }
}
