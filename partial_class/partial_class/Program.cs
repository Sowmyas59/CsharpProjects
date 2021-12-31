using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
	public class Car
	{
		private string Car_Name;
		private int Year;
		private string Car_color;
		public Car(string N, int Y, string C)
		{
			this.Car_Name = N;
			this.Year = Y;
			this.Car_color = C;
		}
		public void Display()
		{
			Console.WriteLine("Car Name is : " + Car_Name);
			Console.WriteLine("Car mfg year is : " + Year);
			Console.WriteLine("Car color is : " + Car_color);
		}
	}
}
