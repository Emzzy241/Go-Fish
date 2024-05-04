using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GoFish.Models;

namespace GoFishTests.Models
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameConstructor_CreatesInstanceOfGame_Game()
        {
            // Arrange
            Game newGame = new Game();

            // Assert
            Assert.AreEqual(typeof(Game), newGame.GetType());
        }
    }   
}