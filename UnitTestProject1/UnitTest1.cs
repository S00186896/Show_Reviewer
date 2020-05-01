using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using UnitTestProject1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            Show S1 = new Show() { ShowName = "Friends" };

            //Act
            Season S1s1 = new Season() { numberOfSeason = 1, SeasonName = "All the Friends" };
            S1.Seasons.Add(S1s1);

            //Assert
            Assert.AreEqual(S1.ShowName, "Friends");
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            Show S1 = new Show() { ShowName = "Fraiser" };

            //Act
            Season S1s1 = new Season() { numberOfSeason = 1, SeasonName = "All the Friends" };
            S1.Seasons.Add(S1s1);

            //Assert
            Assert.AreEqual(S1.ShowName, "Friends");
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            Season S2s1 = new Season() { SeasonName = "failed name" };

            //Act  
            S2s1.SeasonName = "Failed name";

            //Assert
            Assert.AreEqual(S2s1.SeasonName, "What could go wrong?");
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            Season S2s1 = new Season() { SeasonName = "What could go wrong?" };

            //Act  
            S2s1.SeasonName = "What could go wrong?";

            //Assert
            Assert.AreEqual(S2s1.SeasonName, "What could go wrong?");
        }
    }
}
