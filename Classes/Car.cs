﻿using System;
namespace Classes
{
	public class Car
	{
		public Car() //- a special member method that has the same name as its class
		{

		}

		public Car(string make, string model, int year)
		{
			Make = make;
			Model = model;
			Year = year;
		}

		
		

        //Create a Make property of type string that is public( and model, and year)

		public string Make { get; set;  } //-read;write;
        public string Model { get; set; }
        public int Year { get; set; }

    }
}

