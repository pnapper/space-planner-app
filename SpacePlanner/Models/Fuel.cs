using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SpacePlanner.Models
{
	public class Fuel
	{
		public double FinalSpeed { get; set; }
		public int RocketWeight { get; set; }

		public Fuel(double finalspeed, int rocketweight)
		{
            FinalSpeed = finalspeed;
			RocketWeight = rocketweight;

		}

		public Fuel()
		{
		}


		public double GetFuelWeight()
		{
            double exp = Math.Pow(2.718, Convert.ToDouble(FinalSpeed) / 3000);
            double fuelWeight = (Convert.ToDouble(RocketWeight))*exp - Convert.ToDouble(RocketWeight);

			return Math.Ceiling(fuelWeight);
		}

		public double GetFinalSpeed()
		{
			return FinalSpeed;
		}

		public int GetRocketWeight()
		{
			return RocketWeight;
		}
	}




}