using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Choose Your Own Adventure: Lost in the Woods!");

            bool goAhead = KeepGoing("Are you ready to begin? (y/n) ");
            while (goAhead)
            {
            Cyoa(goAhead);
            goAhead = KeepGoing("Would you like to play again ? (y/n) ");
            }
            
        }

        static bool KeepGoing(string message)
        {//method to check if user wants to continue
            bool correctInput = true; //makes sure user puts in a variation of "yes" or "no"
            bool continuer = true;
            do
            {
                Console.Write("\n" + message);
                string confirm = Console.ReadLine().ToLower();
                if (confirm == "n" || confirm == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    continuer = false;
                    correctInput = true;
                    Console.ReadKey();
                }
                else if (confirm == "y" || confirm == "yes")
                {
                    Console.WriteLine("\nOkay!\n");
                    continuer = true;
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't understand.");
                    correctInput = false;
                }
            } while (!correctInput);
            return continuer;
        }

        static void Cyoa(bool play)
        {
            if (play)
            {
                string choice = "1";
                bool badInput = false;
                {
                    Console.WriteLine("You are alone, walking down a forest path. It is a dark and stormy night. \n" +
                        "It was bright and sunny just a few short hours ago, perfect weather to go on a \n" +
                        "lovely stroll through the forest. Unfortunately, the weather turned rough and you got \n" +
                        "turned around. The latest Apple software update has rendered your iPhone all but \n" +
                        "inoperable. You have decided to press on and hopefully make your way out of the \n" +
                        "forest, or at the very least find some shelter.\n" +
                        "\n" +
                        "Up ahead, you can see the path forks in two. The left path appears to open into \n" +
                        "a clearing. You can almost make out light, possibly a campfire of some sort. It could\n" +
                        "just be a trick of the light.\n" +
                        "The path on the right continues on into the forest. \n" +
                        "Thunder rumbles overhead. Your stomach rumbles below. Things aren't looking good.\n");
                        
                    do
                    {
                        if ("12".Contains(choice) || (badInput))
                        {
                            Console.WriteLine("What do you do?\n" +
                            "\n" +
                            "1. Walk down the left path.\n" +
                            "2. Walk down the right path.\n");
                            choice = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nI'm sorry, I didn't understand.");
                            badInput = true;
                        }
                    } while (!"12".Contains(choice));
                    if (choice == "1" || (badInput))
                    {
                        //branch 1
                        Console.WriteLine("You walk down the path, out into the clearing. In the distance,\n" +
                            "there's a small cottage with a light on. Hope! Without a second thought, you \n" +
                            "open the front door and step inside.\n" +
                            "It is sparsely furnished and dimly lit, and it's \"rustic\" in the loosest \n" +
                            "sense of the term, but it's shelter. You haven't even had time to properly \n" +
                            "investigate your surroundings when the aroma of pizza caresses your nostrils.\n" +
                            "There, on the table! A pepperoni pizza, displayed almost as though it was made\n" +
                            "for you to eat it. You carelessly engorge yourself on the pizza pie, musing \n" +
                            "that it is, indeed, amore.\n" +
                            "Suddenly, you hear rustling outside. The owner of the cottage is coming to the \n" +
                            "door. They will not likely take kindly to a stranger breaking in and devouring \n" +
                            "their meal. You frantically scan the cottage for hiding spots. Only two areas \n" +
                            "are large enough to hide a grown and full person: directly behind the door and \n" +
                            "behind the couch. These aren't great options, but neither is breaking and entering.\n");
                        do
                        {
                            if ("12".Contains(choice) || (badInput))
                            {
                                Console.WriteLine("What do you do?\n" +
                                "\n" +
                                "1. Hide behind the door\n" +
                                "2. Hide behind the couch");
                                choice = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("\nI'm sorry, I didn't understand.");
                                badInput = true;
                            }
                        } while (!"12".Contains(choice));
                        if (choice == "1")
                        {
                            //branch 1a
                            Console.WriteLine("You dash to the door just as the mysterious stranger arrives.\n" +
                                "They open the door and you artfully slip in the cranny between \n" +
                                "wall and the open door. You notice that this person is a man, \n" +
                                "slightly shorter than you, and dragging something behind him \n" +
                                "into the cottage. Something about him seems familiar. It doesn't\n" +
                                "take long for you to realize what he's dragging is a body and is\n" +
                                "holding an axe. You stifle a gasp. This man is some kind of \n" +
                                "crazed killer. And you ate his pizza!\n" +
                                "There is nothing to do but wait for the right opportunity to \n" +
                                "make a mad dash out of there. The killer drops the body as he \n" +
                                "sees the empty space on the table where his pizza used to be. \n" +
                                "He flies into a rage, knocking over chairs and throwing kitchen\n" +
                                "appliances to the ground. You can't tell if he's searching for \n" +
                                "you or just insanely angry. \n" +
                                "He slams the door shut and you lock eyes.\n" +
                                "Shia LeBeouf.\n" +
                                "You have no time to react before he raises the axe above his head \n" +
                                "and brings it down, like he has likely done hundreds if not \n" +
                                "thousands of times. Your final thought is unclear, but involves \n" +
                                "the Even Stevens movie and what would happen if you stumbled upon\n" +
                                "Twitty's cottage in the woods.\n" +
                                "\nYou have been killed by Shia LeBeouf.\n");
                            //hide and die
                        }
                        else if (choice == "2")
                        {
                            //branch 1b
                            Console.WriteLine("You duck under the couch as they open the door. You notice\n" +
                                "that this person is a man, slightly shorter than you, and dragging\n" +
                                "something behind him into the cottage. Something about him seems\n" +
                                "familiar. It doesn't take long for you to realize what he's \n" +
                                "dragging is a body and is holding an axe. You stifle a gasp. This \n" +
                                "man is some kind of crazed killer. And you ate his pizza!\n" +
                                "You reach under the couch desperately, hoping for something to aid\n" +
                                "you against this murderer. Your fingers touch cold steel. You pull \n" +
                                "out a pistol. Thinking fast, you leap up and point the gun at this\n" +
                                "stranger. Startled, he looks at you.\n" +
                                "Shia LeBeouf.\n" +
                                "He drops the body and runs at you with the axe. Instinctively, you\n" +
                                "shoot the pistol six times, until you hear a click. Shia crumples \n" +
                                "to the floor. As you stand over him, a look of what can only be \n" +
                                "described as relief has come over his face. You reach down and\n" +
                                "close his eyes.\n" +
                                "\nYou are finally safe from Shia LeBeouf.\n" +
                                "You have won.\n");
                            //attack and live
                        }



                    }
                    else if (choice == "2" || (badInput))
                    {
                        //branch 2
                        Console.WriteLine("You continue down the path. The darkness grows as the path narrows; \n" +
                            "trees growing closer and closer together. It eventually gets so dark \n" +
                            "you can hardly see your hand in front of your face. \n" +
                            "As you proceed further into the stygian blackness, you hear a rustling \n" +
                            "in the underbrush a few yards back. Actually, \"rustling\" is too \n" +
                            "delicate a term. \"Crashing\" is closer to the truth. Your rudimentary \n" +
                            "knowledge of forest fauna would indicate only large creatures crash \n" +
                            "through the underbrush. Your feet are frozen to the forest floor.");
                        if ("12".Contains(choice))
                        {
                            Console.WriteLine("What do you do?\n" +
                            "\n" +
                            "1. Fight. Stay put and see what happens. You can take it.\n" +
                            "2. Flight. Get moving and put distance between you and whatever that is.\n");
                            choice = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nI'm sorry, I didn't understand.");
                            badInput = true;
                        }
                        if (choice == "1")
                        {
                            //branch 2a
                            Console.WriteLine("You're willing to take the chance. You plant your feet and \n" +
                                "wait for whatever is out there to emerge. Cold sweat drips down\n" +
                                "your face as the sound grows closer and louder. You hold your breath.\n" +
                                "Suddenly, silence.\n" +
                                "Just as suddenly, a man bursts out of the black and onto the path.\n" +
                                "Shia LeBeouf.\n" +
                                "He runs at you like a feral beast, brandishing an axe. You see blood\n" +
                                "on his face - my God, there's blood everywhere - and a crazed glint \n" +
                                "in his Hollywood eyes as he sprints. You are so terrified you have \n" +
                                "lost control of your body. Shia rears back with the axe, still in \n" +
                                "a full sprint, as though he has done this dozens of times.\n" +
                                "And then, darkness. Less than darkness. Nothing.\n" +
                                "\nYou have been killed by Shia LeBeouf.\n");
                            //Shia finds and kills you
                        }
                        else if (choice == "2")
                        {
                            //branch 2b
                            Console.WriteLine("You're not taking any chances. You step quicker, attempting\n" +
                                "to navigate through the branches and brambles, avoiding whatever \n" +
                                "is behind you. Boy, are there a lot of branches and brambles.\n" +
                                "You take a cursory glance behind you, to check if the coast is \n" +
                                "clear, when you spot him.\n" +
                                "Shia LeBeouf.\n" +
                                "He's following you, about thirty feet back. He gets down on all \n" +
                                "fours and breaks into a sprint. He's gaining on you.\n" +
                                "He's almost upon you now, and you can see there's blood on his \n" +
                                "face. My God, there's blood everywhere!\n" +
                                "You run as fast as you can, but there's no use. He's wielding a \n" +
                                "razor-sharp axe, which he raises above his head as he bellows an \n" +
                                "inhuman shriek. The last thing you see is his maniacal gaze, \n" +
                                "unblinking, as he swings the axe.\n" +
                                "\nYou have been killed by Shia LeBeouf.\n");
                            //Shia follows and kills you
                        }
                    }
                }
            }
        }
    }
}
