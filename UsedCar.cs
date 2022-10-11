using System;


namespace Used_Cars_Lab
{
	public class UsedCar : Car
	{
		double Mileage { get; set; }

		public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
		{
            Mileage = mileage;
		}

        public override string ToString()
        {
            return base.ToString() + "\tMilage: " + Mileage;
        }

    }
}
