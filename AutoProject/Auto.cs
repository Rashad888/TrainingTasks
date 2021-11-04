using System;
namespace AutoProject
{
	abstract class Auto
	{
		public string TypeOfAuto { get; set; }
		public double CapacityFuelTank { get; set; }
		public double AvgFuelConsumption { get; set; }
		public double Speed { get; set; }
		public double Fuel { get; set; }

		public Auto(string TypeOfAuto, double CapacityFuelTank, double AvgFuelConsumption, double Speed, double Fuel) 
		{
			this.TypeOfAuto = TypeOfAuto;
			this.CapacityFuelTank = CapacityFuelTank;
			this.AvgFuelConsumption = AvgFuelConsumption;
			this.Speed = Speed;
            this.Fuel = Fuel;
		}
        protected virtual double AbleDistance(double fuel)
        {
            return fuel / AvgFuelConsumption;
        }

        public void CurrentDistanceRange()
        {
            Console.WriteLine($"Тип авто: {TypeOfAuto} Количество топлива: {Fuel} Запас хода в данный момент {DistanceFuelCurrent()}") ;
        }
        public double TimeDistanceComplete(double Distance)
        {
            return Distance / Speed;
        }
        public double CalcFuelRangeOfFullFuel()
        {
            return AbleDistance(CapacityFuelTank);
        }
        public double DistanceFuelCurrent()
        {
            return AbleDistance(Fuel);
        }
    }
}