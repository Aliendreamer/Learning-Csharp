using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{

    class Deck
    {
        

    }



    class Program
    {
        static void Main(string[] args)
        {

            //input

            Console.WriteLine("Choose game:");
            Console.WriteLine("1== belot");
            Console.WriteLine("2==sentase");
            Console.WriteLine("3==bridge");
            int gameChoice = int.Parse(Console.ReadLine());

             //logic teste karti 4te boi 

                   string colors = "\\u2663\\u2660\\u2666\\u2665";
                   colors = System.Text.RegularExpressions.Regex.Unescape(colors);

                   Random rng = new Random();

                   string[] cardsNum = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

                  List <string> cardDeck =new List<string>(cardsNum);

            switch (gameChoice)
            {
                case 1:
                    cardDeck.RemoveRange(0, 5);
                    break;
                case 2:
                    cardDeck.RemoveRange(0, 6);
                    break;
                case 3:
                    cardDeck.Equals(cardDeck);
                    break;

                default:
                    Console.WriteLine("Wrong choice of game");
                    break;
            }



           StringBuilder CardsAllColors = new StringBuilder();
      
           foreach (var index in cardDeck)
                
           {
                CardsAllColors.Append(index).Append(colors[0]).Append(' ').ToString();
                CardsAllColors.Append(index).Append(colors[1]).Append(' ').ToString();
                CardsAllColors.Append(index).Append(colors[2]).Append(' ').ToString();
                CardsAllColors.Append(index).Append(colors[3]).Append(' ').ToString();
           }





            string[] Shuffleme = CardsAllColors.ToString().Split(' ');
            
            List<string> ShuffledDeck = new List<string>();

            foreach (string f in Shuffleme)
            {
                if (f.Length !=0)
                {
                    ShuffledDeck.Add(f);
                }
                else
                {
                    continue;
                }
                
            }
            // 3те различни типа тестета тествани и работят TO DO  разбъркване с Random

            int number = ShuffledDeck.Count;
            int card = 0;


            for (int first=0;first<number;first++)
            {

                card++;
                int second=rng.Next(ShuffledDeck.Count);
                string  temp = ShuffledDeck[first];
                ShuffledDeck[first] =ShuffledDeck[second];
                ShuffledDeck[second] = temp;
                
            }
            
            // shuffle raboti s vsqko razlichno teste ostana to draw hand


            if(gameChoice==1)
            {

                while(ShuffledDeck.Count>0)
                {





                }



            }
            else if(gameChoice==2)
            {

            }
            else if(gameChoice==3)
                {

            }
            else
            {
                Console.WriteLine("no such game");
            }




        }
    }
}
