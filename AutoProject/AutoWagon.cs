using System;

namespace AutoProject
{
	class AutoWagon : Auto
	{
		public double LiftingCapacity { get; set; }
		public double CurrentLifting 
		{
			get; set;
		}

		public double PercentForAddWeight = 4;
		public AutoWagon(string TypeOfAuto, double CapacityFuelTank, double AvgFuelConsumption, double Speed, double LiftingCapacity, double CurrentLifting, double Fuel) 
			:base(TypeOfAuto, CapacityFuelTank, AvgFuelConsumption, Speed, Fuel) 
		{
			this.LiftingCapacity = LiftingCapacity;
			this.CurrentLifting = CurrentLifting;

			if (CurrentLifting > LiftingCapacity)
				Console.WriteLine($"Невозможно! Вес превышает лимита {LiftingCapacity}");
		}

		protected override double AbleDistance(double fuel)
		{
			double total_percent = 100 - CurrentLifting * (PercentForAddWeight / 200);
			return base.AbleDistance(fuel) * total_percent;
		}
	}
}
