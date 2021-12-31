using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    public partial class Car1
    {
		private string Car_Name;
		private int Year;
		private string Car_color;
		public Car1(string N, int Y, string C)
		{
			this.Car_Name = N;
			this.Year = Y;
			this.Car_color = C;
		}
	}
}
