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
 
	    public void ConstructDog(int number, double price){
	        dogBuilder.CreateNewDog();
	        dogBuilder.BuildNumber(number);
	        dogBuilder.BuildPrice(price);
	        dogBuilder.BuildSpecies();
	        dogBuilder.BuildRace();
	    }
	}
	
	class CatBreeder{
		private CatBuilder catBuilder;
		
		public CatBuilder CatBuilder{
	        get { return catBuilder; } 
	        set { catBuilder = value; }
    	}
		
		public Cat Cat { 
			get { return catBuilder.Cat; } 
		}
 
	    public void ConstructCat(int number, double price){
	        catBuilder.CreateNewCat();
	        catBuilder.BuildNumber(number);
	        catBuilder.BuildPrice(price);
	        catBuilder.BuildSpecies();
	        catBuilder.BuildRace();
	    }
	}
	
	/*
	class AnimalBreeder{
		private AnimalBuilder animalBuilder;
		
		public AnimalBuilder AnimalBuilder{
	        get { return animalBuilder; } 
	        set { animalBuilder = value; }
    	}
 
	    public void ConstructAnimal(int number, double price){
	        animalBuilder.CreateNewAnimal();
	        animalBuilder.BuildNumber(number);
	        animalBuilder.BuildPrice(price);
	        animalBuilder.BuildSpecies();
	        animalBuilder.BuildRace();
	    }
	}*/
}
