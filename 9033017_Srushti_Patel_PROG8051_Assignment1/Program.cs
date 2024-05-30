using System;

class Program
{
    static void Main(string[] args)
    {
        string petType = "";
        string petName = "";

        int hunger = 5;
        int happiness = 5;
        int health = 8;

        // Pet Creation

        while (true)
        {

            Console.WriteLine("\nPlease choose a type of pet:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.WriteLine("\nUser input:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)


            {
                case 1:
                    petType = "Cat";
                    break;
                case 2:
                    petType = "Dog";
                    break;
                case 3:
                    petType = "Rabbit";
                    break;
                default:

                    Console.WriteLine("\nInvalid choice. Please try again.");
                    continue;
            }
            break;

        }

        Console.WriteLine($"\nYou've chosen a {petType}.What would you like to name your pet?");


        Console.WriteLine("\nUser input:");

        petName = Console.ReadLine();

        Console.WriteLine("\n");
        Console.WriteLine($"Welcome,{petName}! Let's take good care of him.");



        //Enhanced Interaction Logic:


        while (true)
        {

            if (hunger >= 6)
            {
                health--;

                Console.WriteLine($"\nYour {petName} is very hungry! Health is deterioration.");
            }
            if (happiness <= 4)
            {
                health--;

                Console.WriteLine($"\nYour {petName} is very unhappy! Health is deterioration.");
            }

            //Pet Care Actions


            Console.WriteLine("\nMain menu:");
            Console.WriteLine($"1. Feed {petName}");
            Console.WriteLine($"2. Play with {petName}");
            Console.WriteLine($"3. Let's {petName} Rest");
            Console.WriteLine($"4. Check {petName}'s Status");
            Console.WriteLine("5. Exit");


            Console.Write("\nUser input:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (hunger > 1)
                {
                    hunger -= 1;
                }
                if (health < 10)
                {
                    health += 1;
                }

                Console.WriteLine($"\nYou fed {petName}.His Hunger decreases and health improves slightly.");
            }

            else if (choice == "2")
            {
                if (hunger >= 8)
                {

                    Console.WriteLine($"\n{petName} won't play with you until you feed him!");
                }
                else if (health <= 2)
                {

                    Console.WriteLine($"\n{petName} is too unhealthy to play!");
                }
                else if (happiness >= 9)
                {
                    Console.WriteLine($"\n{petName} has been playing for long time.Time to rest!");
                }
                else
                {
                    if (happiness < 10)
                    {
                        happiness += 1;
                    }

                    if (hunger < 10)
                    {
                        hunger += 1;
                    }
                    Console.WriteLine($"you played with {petName}. his Happiness increases,but he's a bit hungries.");
                }

            }

            else if (choice == "3")
            {
                if (happiness <= 2)
                {
                    Console.WriteLine($"Your {petName} is too unhappy to rest!");
                }
                else
                {
                    if (health < 10)
                    {
                        health += 1;
                    }
                    if (happiness > 1)
                    {
                        happiness -= 1;
                    }
                    Console.WriteLine($"Your {petName} is resting. Health increased,Happiness decreased.");
                }
            }

            // Pet Status Monitoring

            else if (choice == "4")
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{petName}'s status:");
                Console.WriteLine($"Hunger: {hunger}");
                Console.WriteLine($"Happiness: {happiness}");
                Console.WriteLine($"Health: {health}");

                // Warning for critical condition

                if (hunger == 1)
                {
                    Console.WriteLine($"\nWarning: Your {petName} is not hungry!");
                }
                else if (hunger == 9)
                {
                    Console.WriteLine($"\nWarning: Your {petName} is starving! Time to eat.");
                }


                if (happiness == 3)
                {
                    Console.WriteLine($"\nWarning: Your {petName} is very unhappy. He want to play with you!");
                }
                else if (happiness == 10)
                {

                    Console.WriteLine($"\nWarning: Your {petName} feels depressed. He want to play with you!");
                }




            }

            else if (choice == "5")
            {
                Console.WriteLine($"\nThank you for playing with {petName}, Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. please try again.");
            }




        }
    }

}