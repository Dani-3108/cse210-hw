using System;

//Exceeds requirements: I created a list containing 8 different scriptures with single verses and two verses, and allowing the program to choose a random scripture to memorize i used the random for that.
//Author Daniel Osorio

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("Mosiah", 2, 41),
            "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God."
        ));

        scriptures.Add(new Scripture(new Reference("3 Nephi", 11, 10, 11),
            "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. " +
            "And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, " +
            "and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning."
        ));

        scriptures.Add(new Scripture(new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; " +
            "and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, " +
            "and have faith in me, then will I make weak things become strong unto them."
        ));

        scriptures.Add(new Scripture(new Reference("Mosiah", 14, 4, 5),
            "Surely he has borne our griefs, and carried our sorrows; yet we did esteem him stricken, smitten of God, and afflicted. " +
            "But he was wounded for our transgressions, he was bruised for our iniquities; the chastisement of our peace was upon him; and with his stripes we are healed."
        ));

        scriptures.Add(new Scripture(new Reference("Alma", 48, 17),
            "Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, " +
            "behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men."
        ));

        scriptures.Add(new Scripture(new Reference("Alma", 38, 5),
            "And now my son, Shiblon, I would that ye should remember, that as much as ye shall put your trust in God " +
            "even so much ye shall be delivered out of your trials, and your troubles, and your afflictions, and ye shall be lifted up at the last day."
        ));

        scriptures.Add(new Scripture(new Reference("Alma", 38, 12),
            "Use boldness, but not overbearance; and also see that ye bridle all your passions, that ye may be filled with love; see that ye refrain from idleness."
        ));

        scriptures.Add(new Scripture(new Reference("Alma", 53, 20),
            "And they were all young men, and they were exceedingly valiant for courage, and also for strength and activity; " +
            "but behold, this was not all—they were men who were true at all times in whatsoever thing they were entrusted."
        ));

        Random random = new Random();
        int index = random.Next(0, scriptures.Count);
        Scripture firstScripture = scriptures[index];

        Console.Clear();
        Console.WriteLine(firstScripture.GetDisplayText());
        Console.WriteLine();

        string userInput = "";
        while (userInput != "quit" && !firstScripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue  or type 'quit' to end the program: ");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                firstScripture.HideRandomWords(1);
                Console.Clear();
                Console.WriteLine(firstScripture.GetDisplayText());
            }
        }
    }
}