using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpacePlanner.Models;

namespace SpacePlanner.Tests
{
	[TestClass]
	public class FuelTests
	{
        [TestMethod]
        public void GetFuelWeight_ReturnsWeightOfFuel_Int()
		{
			//Arrange
			var fuel = new Fuel(1400, 1000);

			//Act
			var result = fuel.GetFuelWeight();

			//Assert
			Assert.AreEqual(595, result);

		}
	}
}
