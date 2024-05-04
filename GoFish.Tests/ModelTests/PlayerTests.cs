using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using GoFish.Models;

namespace GoFishTests.ModelTests
{
    [TestClass]
    public class PlayerTests : IDisposable
    {
        public void Dispose()
        {
            Player.ClearAllPlayers();
        }

        // Test1. Test to determine whether an Instance of player can be created
        [TestMethod]
        public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
        {
            // Arrange
            Player newPlayer = new Player("Samuel");

            // Assert
            Assert.AreEqual(typeof(Player), newPlayer.GetType());
        }

        // Test2. Test to get name of player
        [TestMethod]
        public void GetName_ReturnsNameOfPlayerInstance_String()
        {
            // Arrange
            Player newPlayer = new Player("Dynasty");
            string expectedName = "Dynasty";

            // Act
            string actualName = newPlayer.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
            
        }

        // Test3. Test to set Name of Player
        [TestMethod]
        public void SetName_SetsNameOfPlayerInstance_Void()
        {
            // Arrange
            Player newPlayer = new Player("Emazon");
            
            // Act
            newPlayer.Name = "Dynasty";

            // Assert
            Assert.AreEqual("Dynasty", newPlayer.Name);
        }

        // Test4. Test to return all Player Instances
        [TestMethod]
        public void GetAllPlayers_ReturnsAllPlayers_Player()
        {
            // Arrange
            Player newPlayer1 = new Player("Dynasty");
            Player newPlayer2 = new Player("Emazon");
            List<Player> expectedPlayerList = new List<Player>(){newPlayer1, newPlayer2};

            // Act
            List<Player> actualPlayerList = Player.GetAllPlayers();

            // Assert
            CollectionAssert.AreEqual(expectedPlayerList, actualPlayerList);


        }

        // Test5. Test to remove all Player Instances
        [TestMethod]
        public void ClearAllPlayers_RemovesAllInstancesOfPlayer_Void()
        {
            // Arrange
            Player newPlayer1 = new Player("Dynasty");
            Player newPlayer2 = new Player("Emazon");
            List<Player> expectedPlayerList = new List<Player>(){};

            // Act
            Player.ClearAllPlayers();
            List<Player> actualPlayerList = Player.GetAllPlayers();

            // Assert
            CollectionAssert.AreEqual(expectedPlayerList, actualPlayerList);
        }

        // Test6. Test to determine the Id of each Playyer Instance
        [TestMethod]
        public void GetId_ReturnsIdOfPlayerInstance_Int()
        {
            // Arrange
            Player newPlayer = new Player("Dynasty");
            Player newPlayer2 = new Player("Dynasty");
            int expectedId = 1;
            int expectedId2 = 2;

            // Act
            int actualId = newPlayer.Id;
            int actualId2 = newPlayer2.Id;

            // Assert
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedId2, actualId2);
        }

        // Test7. Test to 
        // [TestMethod]
        // public void 

        // []

    }
}