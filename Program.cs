using System.Runtime.InteropServices;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string replay = "yes";
            Random rand = new Random();//makes and rolls the dice


            Console.WriteLine("welcome to dicejack");
            Console.WriteLine("the rules are, the closest to 21 wins, if you go over it you loose");
            Console.WriteLine("if the dealer gets over 17 he stops");
            Console.WriteLine("you can use yes, ye, y to continue");
            Console.WriteLine("and you can use stop, no, n to stop");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("shall we play?");
            Console.WriteLine("yes? no?");
            string play = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------");
            while (replay == "yes" || replay == "play" || replay == "ye" || replay == "y" || replay == "continue" || replay == "c")
            {
                int playersum = 0;
                int dealersum = 0;
                string dealerplay = "yes";
                if (play == "stop" || play == "no" || play == "n" || replay == "stop" || replay == "no" || replay == "n")
                {
                    replay = "n";
                    play = "n";
                    dealerplay = "n";
                    break;
                }
                while (play == "yes" || play == "play" || play == "ye" || play == "y" || play == "continue" || play == "c")
                {
                    play = "yes";
                            int randomnum = rand.Next(1, 14);
                            int randomnumdealer = rand.Next(1, 14);
                    if (randomnum >= 10)
                    {
                        Console.WriteLine("you got " + randomnum + " it turn into a 10");
                        randomnum = 10;
                        playersum += randomnum;
                    }
                    if (randomnum < 10)
                    {
                        playersum += randomnum;
                    }

                    //--------------------------------------------------------------------------------------------------------------------------------------

                    if (playersum > 21)
                    {
                        Console.WriteLine("you got " + randomnum + " with a total of " + playersum + " witch is over 21");
                        Console.WriteLine("you lost");
                        Console.WriteLine("Restart?");
                        replay = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------------------------------");

                        break;
                    }
                    if (playersum == 21)
                    {
                        Console.WriteLine("you got " + randomnum + " with a total of " + playersum + " witch is 21");
                        Console.WriteLine("you stopped playing");
                        play = "n";
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    }

                    //--------------------------------------------------------------------------------------------------------------------------------------
                    if (dealerplay == "yes" || dealerplay == "play" || dealerplay == "ye" || dealerplay == "y" || dealerplay == "continue" || dealerplay == "c")
                    {
                        if (randomnumdealer >= 10)
                        {
                            randomnumdealer = 10;
                            dealersum += randomnumdealer;
                            Console.WriteLine("the dealer got " + randomnumdealer + " witch is over 10 witch makes it 10, dealer has a total of " + dealersum);
                            Console.WriteLine("---------------------------------------------------------------------");
                        }
                        if (randomnumdealer < 10)
                        {
                            dealersum += randomnumdealer;
                        }
                        if (dealersum > 21)//cheak if dealer is over 21
                        {
                            Console.WriteLine("the dealer got " + randomnumdealer + " with a total of " + dealersum + " witch is over 21");
                            Console.WriteLine("you win");
                            Console.WriteLine("Restart?");
                            replay = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------------------------");

                            break;
                        }

                        if (dealersum == 17 || dealersum > 17 && dealerplay != "no")//if dealer sum is over 17 he stops
                        {
                            dealerplay = "no";
                            Console.WriteLine("you got " + randomnum + " with a total of " + playersum);
                            Console.WriteLine("the dealer got " + randomnumdealer + " with a total of " + dealersum + " witch is over 17");
                            Console.WriteLine("dealer stops playing");

                            Console.WriteLine("continue?");
                            play = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------------------------");
                        }
                        if (dealersum == 17 || dealersum > 17 && dealerplay == "no")//if dealer sum is over 17 he stops
                        {
                            dealerplay = "no";
                            Console.WriteLine("you got " + randomnum + " with a total of " + playersum);
                            Console.WriteLine("dealer stoped playing already");

                            Console.WriteLine("continue?");
                            play = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------------------------");
                        }
                        else//asks if you continue
                        {
                                Console.WriteLine("you got " + randomnum + " with a total of " + playersum);
                                Console.WriteLine("the dealer got " + randomnumdealer + " with a total of " + dealersum);

                                Console.WriteLine("continue?");
                                play = Console.ReadLine();
                                Console.WriteLine("---------------------------------------------------------------------");

                            
                        }
                    }
                }
//--------------------------------------------------------------------------------------------------------------------------------------
                while (play == "stop" || play == "no" || play == "n")//cheaks if player wrote no
                {
                    while (dealerplay == "yes" || dealerplay == "y" || dealerplay == "ye" || play == "continue" || play == "c" && playersum != 0)
                    {
                            int randomnumdealer = rand.Next(1, 7);
                        if (randomnumdealer > 10)
                        {
                            randomnumdealer = 10;
                            dealersum += randomnumdealer;
                            Console.WriteLine("the dealer got " + randomnumdealer + " witch is over 10 witch makes it 10, dealer has a total of " + dealersum);
                        }
                        if (randomnumdealer < 10)
                        {
                            dealersum += randomnumdealer;
                            Console.WriteLine("the dealer got " + randomnumdealer + " with a total of " + dealersum);
                        }
                            Console.WriteLine("---------------------------------------------------------------------");

                        //dealer plays
                        if (dealersum > 21)//cheak if dealer is over 21
                        {
                            Console.WriteLine("the dealer got " + randomnumdealer + " with a total of " + dealersum + " witch is over 21");
                            Console.WriteLine("you win");
                            Console.WriteLine("Restart?");
                            replay = Console.ReadLine();
                            if (replay == "yes" || play == "play" || play == "ye" || play == "y" || play == "continue" || play == "c")
                            {
                                play = "y";
                            }
                            Console.WriteLine("---------------------------------------------------------------------");

                            break;
                        }
                        if (dealersum == 17 || dealersum > 17)
                                    {
                                        dealerplay = "no";
                                    Console.WriteLine("---------------------------------------------------------------------");
                                    Console.WriteLine("you stopped playing at " + playersum);
                                    Console.WriteLine("the dealer got " + randomnumdealer + " with a total of " + dealersum + " witch is over 17");
                                    Console.WriteLine("dealer stops playing");
                                    Console.WriteLine("---------------------------------------------------------------------");

                                    }
                    }
//--------------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine("you stopped with " + playersum + " and the dealer had " + dealersum);
                    if (playersum > dealersum)//if player has more the player wins
                    {
                        Console.WriteLine("you won!");
                        Console.WriteLine("Restart?");
                       play = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    }
                    if (playersum == dealersum)
                    {
                        Console.WriteLine("you and the dealer got the same number, both win and lose");
                        Console.WriteLine("Restart?");
                        play = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    }
                            if (dealersum > playersum)//if dealer has more than player loses
                            {
                                Console.WriteLine("you lost!");
                                Console.WriteLine("Restart?");
                                play = Console.ReadLine();
                                Console.WriteLine("---------------------------------------------------------------------");
                                break;
                            }

                }
//--------------------------------------------------------------------------------------------------------------------------------------
                if (playersum == 0)
                {
                    Console.WriteLine("Fuck you");
                    break;
                }

            }
        }
    }
}
