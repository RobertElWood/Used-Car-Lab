using System;

namespace Used_Cars_Lab
{
	public class Car
	{
		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public decimal Price { get; set; }

		//Car object containing necessary information on each New vehicle.
		public Car(string make, string model, int year, decimal price)
		{
			Make = make;
			Model = model;
			Year = year;
			Price = price;
		}

		//Null Car object to set values to defaults where necessary.
		public Car() 
		{

		}

		//Anytime an object would be turned into a string, its ToString() method gets called.
		//This makes printing the values in our lists easier.
		public override string ToString()
		{
			string output = $"Make: {Make}\tModel: {Model}\tYear: {Year}\t Price: {Price}";
			return output;
		}

	}
}
