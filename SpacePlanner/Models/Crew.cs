using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SpacePlanner.Models
{       
    public class Crew
    {
		public int Tasks { get; set; }
		public int Hours { get; set; }
		
        public Crew(int tasks, int hours)
        {
			Tasks = tasks;
			Hours = hours;
 
        }

		public Crew()
		{
		}


		public double GetAstronauts()
		{
            double astronauts = (Convert.ToDouble(Tasks) /Convert.ToDouble(Hours)) / 4;

            return Math.Ceiling(astronauts);
		}

        public int GetHours()
        {
            return Hours;
        }

		public int GetTasks()
		{
			return Tasks;
		}
    }

        


}