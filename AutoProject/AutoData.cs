using System.Collections.Generic;

namespace AutoProject
{
	class AutoData
	{
		public List<Auto> autos;

		public AutoData() 
		{
			autos = new List<Auto>()
			{
				new AutoPassenger("B", 200, 18, 100, 5, 4,30),
				new AutoWagon("C", 300, 50, 150, 6000, 3000,90),
				new AutoSport("B", 50, 20, 300,50)
			};
		}
	}
}
