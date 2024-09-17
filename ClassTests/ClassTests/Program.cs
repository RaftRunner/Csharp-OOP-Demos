using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTests
{
	class Shapes
	{
		// This class is to demonstrate encapsulation
		public double width;
		public double height;
		public double radius;
		public double pi = 3.14;

		public double rectangeleArea()
		{
			return width * height;
		}

		public void displayRectangle()
		{
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Height: {0}", height);
			Console.WriteLine("Area: {0}", rectangeleArea());
		}

		public double sqaureArea()
		{
			return width * width;
		}

		public void displaySquare()
		{
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", sqaureArea());
		}

		public double circleArea()
		{
			return pi * (radius * radius);
		}

		public void displayCircle()
		{
			Console.WriteLine("Radius: {0}", radius);
			Console.WriteLine("Pi: {0}", pi);
			Console.WriteLine("Area: {0}", circleArea());
		}

		public double triangleArea()
		{
			return 0.5 * (width * height);
		}

		public void displayTriangle()
		{
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Height: {0}", height);
			Console.WriteLine("Area: {0}", triangleArea());
		}
	}

	class Vehicle
	{
		// This class is the base class for demonstrating inheritance
		public string make = "Seat";

		public void honk()
		{
            Console.WriteLine("Honk honk");
        }
	}

	class Car : Vehicle
	{
		// This class is the child class for demonstrating inheritance
		public string model = "Leon";
	}

		class MainExecutable
	{
		static void Main(string[] args)
		{
			/* All the shapes stuff

			Shapes rect = new Shapes();
			rect.width = 2.3;
			rect.height = 82.7;
			rect.displayRectangle();

			Shapes square = new Shapes();
			square.width = 3.6;
			square.displaySquare();

			Shapes triangle = new Shapes();
			triangle.width = 6.4;
			triangle.height = 12.5;
			triangle.displayTriangle();

			Shapes circle = new Shapes();
			circle.radius = 11.3;
			circle.displayCircle();
			*/

			/* This is to demonstrate inheritance 
			
			Car myNextCar = new Car();
			myNextCar.honk();
            Console.WriteLine("My next car is going to be a " + myNextCar.make + " and the model will be a " + myNextCar.model);
			*/
			
			
			Console.ReadLine();

		}
	}
}
