using System;

namespace AutoProject
{
	class AutoPassenger: Auto
	{
		public int MaxCountPass { get; set; }
		public double PercentForOnePerson = 6;

		public int CountPassInAuto { get; set; }

		public AutoPassenger(string TypeOfAuto, float CapacityFuelTank, float AvgFuelConsumption, float Speed, int MaxCountPass, int CountPassInAuto, double Fuel) 
			: base (TypeOfAuto, CapacityFuelTank, AvgFuelConsumption, Speed, Fuel) 
		{
			this.MaxCountPass = MaxCountPass;
			this.CountPassInAuto = CountPassInAuto;
			
			if (CountPassInAuto > MaxCountPass)
				Console.WriteLine($"{CountPassInAuto} человек не поместятся в салоне легкового автомобиля\n\rВместимость автомобиля: {MaxCountPass} человек");
		}
		protected override double AbleDistance(double fuel)
		{
			double total_percent = 100 - CountPassInAuto * PercentForOnePerson;
			return base.AbleDistance(fuel) * total_percent;
		}
	}
}
