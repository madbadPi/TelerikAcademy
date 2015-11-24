using System;

class PrintAllPossibleCardsFromDeck
{
    static void Main(string[] args)
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Ace", "Jack", "Queen", "King" };
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (cards[i])
                {
                    case "2":
                        Console.Write("2 of ");
                        break;
                    case "3":
                        Console.Write("3 of ");
                        break;
                    case "4":
                        Console.Write("4 of ");
                        break;
                    case "5":
                        Console.Write("5 of ");
                        break;
                    case "6":
                        Console.Write("6 of ");
                        break;
                    case "7":
                        Console.Write("7 of ");
                        break;
                    case "8":
                        Console.Write("8 of ");
                        break;
                    case "9":
                        Console.Write("9 of ");
                        break;
                    case "10":
                        Console.Write("10 of ");
                        break;
                    case "Ace":
                        Console.Write("Ace of ");
                        break;
                    case "Jack":
                        Console.Write("Jack of ");
                        break;
                    case "Queen":
                        Console.Write("Queen of ");
                        break;
                    case "King":
                        Console.Write("King of ");
                        break;
                }
                switch (suits[j])
	            {
		            case "Clubs":
                        Console.Write("Clubs\n");
                        break;
                    case "Diamonds":
                        Console.Write("Diamonds\n");
                        break;
                    case "Hearts":
                        Console.Write("Hearts\n");
                        break;
                    case "Spades":
                        Console.Write("Spades\n");
                        break;
	            }                
            }
        }
    }
}
