﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny
{
    class Program
    {
        static void Main(string[] args)
        {
        	Model model = new Model();
        	View view = new View(model);
         	Controller controller = new Controller(model, view);
         	controller.showInterface();
        	
        	
        	
        	DogBreeder dogBreeder = new DogBreeder();
        	

        	dogBreeder.DogBuilder = new BulldogDogBuilder();
        	dogBreeder.DogBuilder.createNewDog();
        	dogBreeder.constructDog(1,5.5);
        	Console.WriteLine(dogBreeder.Dog.display());
        	Console.ReadKey();
        }
    }
}
