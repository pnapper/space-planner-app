using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpacePlanner.Models;

namespace SpacePlanner.Tests
{
    [TestClass]
    public class CrewTests
    {
        [TestMethod]
        public void GetAstronaut_ReturnsNumberOfAstronauts_Int()
        {
			//Arrange
			var crew = new Crew(16, 4);

			//Act
			var result = crew.GetAstronauts();

			//Assert
			Assert.AreEqual(1, result);

        }
    }
}
