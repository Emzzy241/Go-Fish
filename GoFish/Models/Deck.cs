using GoFish.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GoFish.Models
{
    // public class Deck
    // {
     
    //     private List<object> cards = new List<object>();
    //     private string[] Suits = { "♠", "♦", "♣", "♥" };
    //     private string[] Values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    //     // The idea of this function is to help in mapping the Suits with a value,
    //     // this helps in showing both Values and Suits on a single card... it maps them both.
    //     public void InitializeDeck()
    //     {
    //         // Looping through the Suits array
    //         for (int i = 0; i < Suits.Length; i++)
    //         {
    //             // Another for-loop for Values
    //             for (int j = 0; j < Values.Length; j++)
    //             {
    //                 // Creating a card object with Value and Suit properties
    //                 var card = new { Value = Values[j], Suit = Suits[i] };
    //                 cards.Add(card);
    //             }
    //         }
    //     }

    // // We use the LINQ to query the list of cards 
    // public int GetNumberOfCards()
    // {
    //     return cards.Count;
    // }

    // public IEnumerable<object> GetDistinctCards()
    // {
    //     return cards.Distinct();
    // }

    // }

    
        public class Deck
        {
            private List<object> cards = new List<object>();
            private string[] Suits = { "♠", "♦", "♣", "♥" };
            private string[] Values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            public void InitializeDeck()
            {
                for (int i = 0; i < Suits.Length; i++)
                {
                    for (int j = 0; j < Values.Length; j++)
                    {
                        var card = new { Value = Values[j], Suit = Suits[i] };
                        cards.Add(card);
                    }
                }
            }

            public int GetNumberOfCards()
            {
                return cards.Count;
            }

            public IEnumerable<object> GetDistinctCards()
            {
                return cards.Distinct();
            }
        }
}