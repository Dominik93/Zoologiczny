/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	class DogBreeder{
		private DogBuilder dogBuilder;
		
		public DogBuilder DogBuilder{
	        get { return dogBuilder; } 
	        set { dogBuilder = value; }
    	}
		
		public Dog Dog { 
			get { return dogBuilder.Dog; } 
		}
 
	    public void constructDog(int number, double price){
	        dogBuilder.createNewDog();
	        dogBuilder.buildNumber(number);
	        dogBuilder.buildPrice(price);
	        dogBuilder.buildSpecies();
	        dogBuilder.buildRace();
	    }
	}
}
