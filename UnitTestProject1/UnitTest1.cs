using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
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
    }
}
