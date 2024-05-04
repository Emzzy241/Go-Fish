using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GoFish.Models;

namespace GoFishTests.Models
{
    [TestClass]
    public class GameTests
    {
        // Test1. Test to Create Instance of Game class
        [TestMethod]
        public void GameConstructor_CreatesInstanceOfGame_Game()
        {
            // Arrange
            Game newGame = new Game("Dimon vs Weill");

            // Assert
            Assert.AreEqual(typeof(Game), newGame.GetType());
        }

        // Test2. Test to get name of Game
        [TestMethod]
        public void GetGameName_ReturnsNameOfGameInstance_Game()
        {
            // Arrange
            Game newGame = new Game("Dynasty vs Godwin");
            string expectedGameName = "Dynasty vs Godwin";

            // Act
            string actualGameName = newGame.GameName;

            // Assert
            Assert.AreEqual(expectedGameName, actualGameName);
        }

        [TestMethod]
        public void SetGameName_SetsNameOfGameInstance_Void()
        {
            // Arrange
            Game newGame = new Game("Dynasty vs Godwin");
            string expectedGameName = "Lori Grenier vs Mr Wonderful";

            // Act
            newGame.GameName = "Lori Grenier vs Mr Wonderful";

            // Assert
            Assert.AreEqual(expectedGameName, newGame.GameName);
        }
        
    }   
}