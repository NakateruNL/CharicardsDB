/* A Program designed for Charicards, to register, manage and much more. 
The current features are: register an order, check statistics such as current profit available boosters, last order, (more coming soon) (multiple selling platforms)
All orders will be printed into a text document, most info will be stored into a .txt text file. */

using System;
using System.IO;

namespace CHRDB
{
    class Program
    {
        static void Main(string[] args)
        {
            char space = '\n'; // Just a new line quickly

            /* The main text, prints 'Charicards' in ASCII art. Centered with spaces. */

            Console.ForegroundColor = ConsoleColor.DarkRed; // Console Color (Currently Red; can be edited soon) <--------

            Console.WriteLine(@"                                    ____ _                _                   _     ");
            Console.WriteLine(@"                                   / ___| |__   __ _ _ __(_) ___ __ _ _ __ __| |___ ");
            Console.WriteLine(@"                                  | |   | '_ \ / _` | '__| |/ __/ _` | '__/ _` / __|");
            Console.WriteLine(@"                                  | |___| | | | (_| | |  | | (_| (_| | | | (_| \__ \");
            Console.WriteLine(@"                                   \____|_| |_|\__,_|_|  |_|\___\__,_|_|  \__,_|___/");
            Console.WriteLine(@"                                                                                    ");

            Console.WriteLine(space); // New line

            int Number; // Parses 'Choice' into a Number in the 'while' loop
            string Choice = string.Empty; // Making sure that string is empty
            DateTime today = DateTime.Today; // Obtain current system time (Time seems to be stuck on 00:00:00) <--------

            do // The menu itself (do -> while)
            {
                Console.ForegroundColor = ConsoleColor.Red; // Text color red

            MainMenu: // Stupid label to return 
                string Menu1 = " [1] Add sold product"; // Marktplaats done
                string Menu2 = " [2] Check statistics";
                string Menu3 = " [3] Exit the programm"; // Exit tool

                Console.SetCursorPosition((Console.WindowWidth - Menu1.Length) / 2, Console.CursorTop); // Center the string
                Console.WriteLine(Menu1);
                Console.SetCursorPosition((Console.WindowWidth - Menu2.Length) / 2, Console.CursorTop); // Center the string
                Console.WriteLine(Menu2);
                Console.SetCursorPosition((Console.WindowWidth - Menu3.Length) / 2, Console.CursorTop); // Center the string
                Console.WriteLine(Menu3);
                Console.WriteLine(space);

                string option = "Enter your option :: ";
                Console.SetCursorPosition((Console.WindowWidth - option.Length) / 2, Console.CursorTop); // Center the string
                Console.Write(option);

                Choice = Console.ReadLine(); // Input option

                if (Choice == "3")
                {
                    Environment.Exit(0); // Close enviroment
                }
                else if (Choice == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red; // Config soon
                    Console.WriteLine("Great you sold a product!");
                    Console.WriteLine("Where did you sell it?");
                    Console.WriteLine("[1] Marktplaats");
                    Console.WriteLine("[2] Discord");
                    Console.WriteLine("[3] Other");
                    Console.WriteLine("\nPlease choose an option :: ");

                    string Method = Console.ReadLine(); // these two line convert string -> integer
                    int Option1 = Convert.ToInt32(Method);

                    if (Option1 == 1)
                    {
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("How many orders do you want to register: ");
                            string Option = Console.ReadLine();
                            int Options = Convert.ToInt32(Option);

                            for (int i = 0; i < Options; i++)
                            {
                                Console.Clear();
                                StreamWriter Marktplaats = new StreamWriter("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Customer.txt", true); // open the txt customers
                                string user, name, id, city, boosters, profit;
                                Console.WriteLine("What is the buyers username: ");
                                user = Console.ReadLine();
                                Console.WriteLine("What is the buyers first and lastname: ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is the buyers city: ");
                                city = Console.ReadLine();
                                Console.WriteLine("What is the buyers Marktplaatd-id: ");
                                id = Console.ReadLine();
                                Console.WriteLine("How many boosters did you sell: ");
                                boosters = Console.ReadLine();
                                Console.WriteLine("How many money did you make: ");
                                profit = Console.ReadLine();
                                int intprofit = Convert.ToInt32(profit);

                                string totalProfit;

                                StreamReader Profit = new StreamReader("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Profit.txt");
                                totalProfit = Profit.ReadLine();
                                int totalProfitWriter = Convert.ToInt32(totalProfit);
                                totalProfitWriter = totalProfitWriter + intprofit;
                                Marktplaats.WriteLine("");
                                Profit.Close();

                                StreamWriter ProfitWriter = new StreamWriter("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Profit.txt");
                                ProfitWriter.WriteLine(totalProfitWriter);
                                ProfitWriter.Close();

                                Marktplaats.WriteLine("[------------------------------------------------]"); // Order Label
                                Marktplaats.WriteLine("Platform: Marktplaats");
                                Marktplaats.WriteLine("You sold " + boosters + " boosters on " + today);
                                Marktplaats.WriteLine("Username: " + user);
                                Marktplaats.WriteLine("City: " + city);
                                Marktplaats.WriteLine("Marktplaats-id: " + id);
                                Marktplaats.WriteLine("You made a total of €" + profit + " on this order!");
                                Marktplaats.WriteLine("All time profit: " + totalProfitWriter);
                                Marktplaats.WriteLine("[------------------------------------------------]");
                                Marktplaats.WriteLine("\n");
                                Marktplaats.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\nException: " + e.Message); // throws error message
                        }
                        finally
                        {
                            Console.WriteLine("Success!");
                        }

                        // Pops up the return menu

                        Console.Clear();
                        Console.WriteLine("Do you want to return to the menu?");
                        string returnMenu;
                        Console.WriteLine("[1] Return");
                        Console.WriteLine("[2] Quit");
                        Console.WriteLine("\nPlease choose an option :: ");
                        returnMenu = Console.ReadLine(); // Read input

                        if (returnMenu == "1")
                        {
                            Console.Clear();
                            goto MainMenu; // Labelized
                        }
                        else if (returnMenu == "2")
                        {
                            Environment.Exit(0); // Exit
                        }
                    }
                    else if (Option1 == 2)
                    {
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("How many orders do you want to register: ");
                            string OptionDiscord = Console.ReadLine();
                            int OptionsDiscord = Convert.ToInt32(OptionDiscord);

                            for (int i = 0; i < OptionsDiscord; i++)
                            {
                                Console.Clear();
                                StreamWriter Discord = new StreamWriter("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Customer.txt", true); // open the txt customers
                                string userDiscord, idDiscord, cityDiscord, boostersDiscord, profitDiscord;
                                Console.WriteLine("What is the buyers username: ");
                                userDiscord = Console.ReadLine();
                                Console.WriteLine("What is the buyers city: ");
                                cityDiscord = Console.ReadLine();
                                Console.WriteLine("What is the buyers Discord-id: ");
                                idDiscord = Console.ReadLine();
                                Console.WriteLine("How many boosters did you sell: ");
                                boostersDiscord = Console.ReadLine();
                                Console.WriteLine("How many money did you make: ");
                                profitDiscord = Console.ReadLine();
                                int intprofitDiscord = Convert.ToInt32(profitDiscord);

                                string totalProfitDiscord;

                                StreamReader ProfitDiscord = new StreamReader("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Profit.txt");
                                totalProfitDiscord = ProfitDiscord.ReadLine();
                                int totalProfitWriterDiscord = Convert.ToInt32(totalProfitDiscord);
                                totalProfitWriterDiscord = totalProfitWriterDiscord + intprofitDiscord;
                                Discord.WriteLine("");
                                ProfitDiscord.Close();

                                StreamWriter ProfitWriterDiscord = new StreamWriter("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Profit.txt");
                                ProfitWriterDiscord.WriteLine(totalProfitWriterDiscord);
                                ProfitWriterDiscord.Close();

                                Discord.WriteLine("[------------------------------------------------]"); // Order Label
                                Discord.WriteLine("Platform: Discord");
                                Discord.WriteLine("You sold " + boostersDiscord + " boosters on " + today);
                                Discord.WriteLine("Username: " + userDiscord);
                                Discord.WriteLine("City: " + cityDiscord);
                                Discord.WriteLine("Discord-id: " + idDiscord);
                                Discord.WriteLine("You made a total of €" + profitDiscord + " on this order!");
                                Discord.WriteLine("All time profit: " + totalProfitWriterDiscord);
                                Discord.WriteLine("[------------------------------------------------]");
                                Discord.WriteLine("\n");
                                Discord.Close();

                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\nException: " + e.Message); // throws error message
                        }
                        finally
                        {
                            Console.WriteLine("Success!");
                        }

                        Console.Clear();
                        Console.WriteLine("Do you want to return to the menu?");
                        string returnMenu;
                        Console.WriteLine("[1] Return");
                        Console.WriteLine("[2] Quit");
                        Console.WriteLine("\nPlease choose an option :: ");
                        returnMenu = Console.ReadLine(); // Read input

                        if (returnMenu == "1")
                        {
                            Console.Clear();
                            goto MainMenu; // Labelized
                        }
                        else if (returnMenu == "2")
                        {
                            Environment.Exit(0); // Exit
                        }
                    }

                }
                else if (Choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("[1] Check total profit"); // Current options
                    Console.WriteLine("[2] Check last sold booster");
                    Console.WriteLine("[3] ???"); // soontm
                    Console.WriteLine("[4] ???"); // soontm
                    Console.WriteLine("\nChoice your option :: ");

                    string statsChoice = Console.ReadLine();

                    if (statsChoice == "1")
                    {
                        Console.Clear();
                        StreamReader totalProfit = new StreamReader("C:\\Users\\Avoidy\\source\\repos\\CHRDB\\CHRDB\\Profit.txt");
                        string totalProfitCheck = totalProfit.ReadLine();
                        Console.WriteLine("You have currently " + totalProfitCheck + " euro profit! Congratulations");
                        totalProfit.Close();

                        Console.WriteLine("\n Press any key to continue!");
                        Console.ReadKey(); // Awaits keypress!
                        Console.Clear();
                        Console.WriteLine("Do you want to return to the menu?");
                        string returnMenu;
                        Console.WriteLine("[1] Return");
                        Console.WriteLine("[2] Quit");
                        Console.WriteLine("\nPlease choose an option :: ");
                        returnMenu = Console.ReadLine(); // Read input

                        if (returnMenu == "1")
                        {
                            Console.Clear();
                            goto MainMenu; // Labelized
                        }
                        else if (returnMenu == "2")
                        {
                            Environment.Exit(0); // Exit
                        }
                        else
                        {
                            Console.WriteLine("That's not an option. Closing program!");
                        }
                    }
                }

                break;
            } while (Int32.TryParse(Choice, out Number));

        }
    }

}
