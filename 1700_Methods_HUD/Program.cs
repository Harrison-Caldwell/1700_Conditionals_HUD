using System;

namespace _1700_Methods_HUD
{
    class Program
    {
        static float Score;
        static float Health;
        static int Lives;
        static float ScoreMultiplier;
        static string firstName;
        static string lastName;
        static string fullName;
        static float enemyKillValue;
        static int healHealth;
        static float Banana;
        static int baseHealth;
        static float damage;
        static float enemieskilled;
        static float pointgain;
        static int Weapon;
        static string EquippedWeapon;
        static string HealthStatus;
        static float Shields;
        static int Regen;
        




        static void ShowHUD()
        {
            HPStatus();
            Console.WriteLine("==============");
            Console.WriteLine("Banana Brain Studios Presents: ");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Status: " + HealthStatus);
            Console.WriteLine("You Regen " + Regen + " Shields");
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);
            Console.WriteLine("Current Weapon: " + EquippedWeapon);
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

            {
                damage = (rnd.Next(10, 30));
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Damage Taken: " + damage);
                Console.ResetColor();
                Console.WriteLine("==============");
            }
            
        }

        static void TakeDamage(float damage)
        {
            if (Shields > 0)
            {
                TakeShieldDamage(damage);
            }
            else if (Shields <= 0)
            {
                TakeHealthDamage(damage);
            }

        }

        static void TakeShieldDamage(float damage)
        {
            Shields = Shields - damage;
            Spillover(damage);
        }

        static void TakeHealthDamage(float damage)
        {
            Health = Health - damage;
            if (Health <= 0)
            {
                Die();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You Died");
                Console.ResetColor();
                if (Lives <= 0)
                {
                    Lives = 0;
                    Console.WriteLine("GAME OVER!!!");
                }
            }
        }

        static void Spillover(float damage)
        {
            if (Shields < 0)
            {
                Health = Health + Shields;
            }
            if (Shields <= 0)
            {
                Shields = 0;
            }

        }

        static void heal(int healHealth)
        {
            Health = Health + healHealth;
            if (Health >= baseHealth)
            {
                Health = baseHealth;
            }
        }

        static void ShieldRegen(int Regen)
        {
            Regen = 10;
            Shields = Shields + Regen;
            if (Shields >= 100)
            {
                Shields = 100;
            }
        }

        
        
        
        static void Pointsgained()
        {
            Random rnd = new Random();

            {
                enemieskilled = (rnd.Next(1, 3));
                pointgain = (enemieskilled * enemyKillValue) * ScoreMultiplier;
            }

            Console.WriteLine("==============");
            Console.WriteLine("Enemies Killed: " + enemieskilled);
            Console.WriteLine("Points Gained: " + (enemieskilled * enemyKillValue) * ScoreMultiplier);
            Console.WriteLine("==============");


        }

        static void SelectWeapon()
        {
            Random rnd = new Random();
            {
                Weapon = (rnd.Next(0, 6));
            }
        }

        static void ChangeWeapon(int Weapon)
        {
            SelectWeapon();

            if (Weapon == 0)
            {
                EquippedWeapon = "FlingingPoo";
            }
            else if (Weapon == 1)
            {
                EquippedWeapon = "Stick";
            }
            else if (Weapon == 2)
            {
                EquippedWeapon = "Rock";
            }
            else if (Weapon == 3)
            {
                EquippedWeapon = "Vine";
            }
            else if (Weapon == 4)
            {
                EquippedWeapon = "Fist";
            }
            else if (Weapon == 5)
            {
                EquippedWeapon = "AK-47";
            }
            
            
        }


        static void HPStatus()
        {
            if (Health >= 150)
            {
                HealthStatus = "Perfect";
            }
            else if (Health > 100)
            {
                HealthStatus = "Happy";
            }
            else if (Health > 50)
            {
                HealthStatus = "Hurt";
            }
            else if (Health > 0)
            {
                HealthStatus = "Critical";
            }


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
                Shields = 100f;
                Regen = 10;

                ChangeWeapon(Weapon);
                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("Go get your bananas back from the aliens " + fullName);
                Console.WriteLine("--------------");

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take one hit to the chest");
                Console.WriteLine("--------------");



                ShieldRegen(Regen);
                Pointsgained();
                calcDamage();
                TakeDamage(damage);
                AddScore(pointgain);
                




                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take two hits, find a new weapon and a Banana");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
                AddBanana();
                calcDamage();
                TakeDamage(damage);

                calcDamage();
                TakeDamage(damage);

                Pointsgained();
                AddScore(pointgain);
                ChangeWeapon(Weapon);
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take three hits");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
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
                Console.WriteLine("You find another banana, taking one hit in the process and find a new weapon");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
                AddBanana();
                calcDamage();
                TakeDamage(damage);

                ChangeWeapon(Weapon);


                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take three hits");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
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
                Console.WriteLine("You find a monkey biscuit that heals some of your health and find another banana. You also find a new weapon");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
                heal(healHealth);
                AddBanana();
                ChangeWeapon(Weapon);
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You take two shots and find a new weapon");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
                calcDamage();
                TakeDamage(damage);
                calcDamage();
                TakeDamage(damage);
                Pointsgained();
                AddScore(pointgain);
                ChangeWeapon(Weapon);
                

                ShowHUD();

                Console.ReadKey(true);

                Console.WriteLine("--------------");
                Console.WriteLine("You find your last 2 Bananas");
                Console.WriteLine("--------------");

                ShieldRegen(Regen);
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
