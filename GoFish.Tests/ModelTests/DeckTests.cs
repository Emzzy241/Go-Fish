using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using GoFish.Models;

namespace GoFishTests.ModelTests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void DeckInstanceMethod_CreatesANewDeckOfCards_Voi()
        {
            // Arrange
        Deck deck = new Deck();

        // Act
        deck.InitializeDeck();

        // Assert
        // Assert that the deck contains 52 cards
        Assert.AreEqual(52, deck.GetNumberOfCards());

        // Assert that each card has a unique combination of value and suit
        Assert.AreEqual(52, deck.GetDistinctCards());
        }
    }
}