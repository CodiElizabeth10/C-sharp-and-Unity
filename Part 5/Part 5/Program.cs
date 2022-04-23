using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myAmiibos = new List<string>() {
                "Link", "Link", "King Dedede",
                "Jigglypuff", "King Dedede", "King Dedede",
                "Jigglypuff", "Marth", "Jigglypuff",
                "Cloud", "King Dedede", "Jigglypuff" };

            invalidAmiibo = true;
            while (invalidAmiibo)
            {
                printFancyList(myAmiibos, "My Amiibos");

                Console.Write("Search for an Amiibo in my list!  ");
                string amiibo = Console.ReadLine();

                // Initializing variables
                List<int> amiiboIndecies = new List<int>();
                int currentIndex = 0;
                int amiiboPosition;

                // Keep checking for the Amiibo until we can't find any more of them.
                do
                {
                    amiiboPosition = myAmiibos.IndexOf(amiibo, currentIndex);
                    if (amiiboPosition >= 0)
                    {
                        currentIndex = amiiboPosition;
                        amiiboIndecies.Add(currentIndex);
                        currentIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true);

                // If there is an index in the List, write it and exit the loop.
                if (amiiboIndecies.Count > 0)
                {
                    invalidAmiibo = false;
                    Console.Write("That Amiibo is in position ");

                    // This for loop just makes the sentence structure for two or more Amiibos.
                    if (amiiboIndecies.Count >= 2)
                    {
                        for (int i = 0; i < amiiboIndecies.Count; i++)
                        {
                            if (i == amiiboIndecies.Count - 1)
                            {
                                Console.Write("and " + amiiboIndecies[i]);
                            }
                            else if (i == amiiboIndecies.Count - 2)
                            {
                                Console.Write(amiiboIndecies[i] + " ");
                            }
                            else
                            {
                                Console.Write(amiiboIndecies[i] + ", ");
                            }
                        }
                    }
                    else
                    {
                        Console.Write(amiiboIndecies[0]);
                    }

                    Console.WriteLine(" of the list\n");
                }
                else
                {
                }
    }
}
