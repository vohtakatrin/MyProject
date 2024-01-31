using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Welcome to website!");
Console.WriteLine("Proof that you are not a robot.");
string[] verify = { "A3445", "98722", "98zZ2", "9rN99", "56iO83", "34zE34", "37Mo07" };
Random rnd = new Random();
int randomIndex = rnd.Next(0, verify.Length);

Console.WriteLine($"Please write, what do you see here {verify[randomIndex]}");
string userGuess = Console.ReadLine();
if (userGuess == verify[randomIndex])
{
    Console.WriteLine("Congratulations, you are not a robot!");
    Console.WriteLine("Now, please enter your full name:");
    string userName = Console.ReadLine();

    Console.WriteLine("Please enter your age:");
    string userAgeInput = Console.ReadLine();
    bool isAgeNumber = Int32.TryParse(userAgeInput, out int userAgeNum);

    if (isAgeNumber)
    {
        if (userAgeNum >= 18)
        {
            Console.WriteLine("Now please create a strong password:");
            string userPassword = Console.ReadLine();
            Console.WriteLine("Congratulations, account created successfully!");

            // Store user information in an array
            string[] data = { userName, userAgeNum.ToString(), userPassword };

            // Display user account information
            Console.WriteLine($"Your account information: Name - {data[0]}, Age - {data[1]}, Password - {data[2]}");

            string[] choice = new string[4];
            choice[0] = "Play with PseudoRandom";
            choice[1] = "Find out what day of the week today";
            choice[2] = "Make a choice";
            choice[3] = "Accept for uni";
            Console.WriteLine($"In our website you  can: |{choice[0]}|{choice[1]}|{choice[2]}|{choice[3]}|");
            Console.WriteLine("Please choose:What do you want to do?");
            string userChoice = Console.ReadLine();
            if (userChoice == choice[0])
            {
                Console.WriteLine("You choose to play with PseudoRandom.");
                Random rnddd = new Random();
                int cpuRandom;

                bool loopActive = true; //bool - true or false

                while (loopActive)
                {
                    cpuRandom = rnddd.Next(1, 4);
                    //Console.WriteLine($"cpu has generated {cpuRandom}");      //CHEAT
                    Console.WriteLine("Make a guess. Enter a number 1-3");
                    int userGuessPseudo = Int32.Parse(Console.ReadLine());    //Konsool loeb string formaadis, meie parsime numbriks

                    if (userGuessPseudo == cpuRandom)
                    {
                        Console.WriteLine("Congratulations, your  guess true");
                        loopActive = false; //Kui tulemus true, lõpetame tsükli - 1 variant
                                            //break; //Kui tulemus true, lõpetame tsükli   - 2 variant
                    }
                    else
                    {
                        Console.WriteLine("Noot good guess, try again");
                    }

                }
                Console.WriteLine("Game ended");


            }
            else if (userChoice == choice[1])
            {
                Console.WriteLine("You choose to find out what day of the week today is.");
                int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6

                switch (weekDay) //väärtus, mida kontrollitakse
                {
                    case 0:       //case 0: == if(weekDay == 0)
                        Console.WriteLine("It's Sunday");
                        break; //Selleks, et vältida liigset kontrolli
                    case 1:
                        Console.WriteLine("It's Monday");
                        break;
                    case 2:
                        Console.WriteLine("It's Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("It's Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("It's Thursday");
                        break;
                    case 5:
                        Console.WriteLine("It's Friday");
                        break;
                    case 6:
                        Console.WriteLine("It's Saturday");
                        break;
                    default:
                        Console.WriteLine("Oops. Your calendar must be broken.");
                        break;
                }
                Console.WriteLine("Have a nice day!");

            }
            else if (userChoice == choice[2])
            {
                Console.WriteLine("You chose to make a choice.");
                Console.WriteLine("Please write things between which you need to make a choice:");
                string choiceData = Console.ReadLine();

                // Split the input string into an array of choices
                Random ch = new Random();
                string[] cchoice = choiceData.Split(',');
                int randomIndexx = ch.Next(0, cchoice.Length);

                if (cchoice.Length > 0)
                {
                    Console.WriteLine($"Have a nice evening with your choice: {cchoice[randomIndexx].Trim()}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please provide at least one choice.");
                }
            }
            else if (userChoice == choice[3]) 
            {
                Console.WriteLine("You choose to accept for uni.");
                //Math >= 90; Biology >=90; Chemistry >=90;


                int math, biology, chemistry;
                Console.WriteLine("Enter yout Math exam result(points):");
                math = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter yout Biology exam result(points):");
                biology = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter yout Chemistry exam result(points):");
                chemistry = Int32.Parse(Console.ReadLine());



                if (math >= 90 && biology >= 90 && chemistry >= 90)
                {
                    Console.WriteLine("Congratulations! You got accepted");
                }
                else
                {
                    Console.WriteLine("Your application cannot be approved.Bye.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
            }

        }
        else
        {
            Console.WriteLine("You are too young, sorry.");
        }
    }
    else
    {
        Console.WriteLine("Age should be a number. Try again.");

    }
}
else
{
    Console.WriteLine("Sorry, the verification failed. You might be a robot.");
}