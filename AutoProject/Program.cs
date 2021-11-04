using System;

namespace AutoProject
{
	class Program
	{
		static void Main(string[] args)
		{
			AutoData autoData = new AutoData();
			autoData.autos.ForEach(x => x.CurrentDistanceRange());
			Console.ReadLine();
		}
	}
}
