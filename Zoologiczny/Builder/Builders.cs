/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	abstract class DogBuilder{
		protected Dog dog;
		
		public Dog Dog{
			get{ return dog; }
		}
		
		public void createNewDog() { 
			dog = new Dog();
		}
		
		public abstract void buildNumber(int number);
		public abstract void buildPrice(double price);
		public abstract void buildSpecies();
		public abstract void buildRace();
	}
	
	class LabradorDogBuilder : DogBuilder{
		public override void buildRace() {
			dog.Race = "Labrador";
		}
		
		public override void buildNumber(int number) { 
			dog.Number = number; 
		}
		
		public override void buildPrice(double price) {
			dog.Price = price; 
		}
		
		public override void buildSpecies() { 
			dog.Species = "Dog"; 
		}
	}
	
	class BulldogDogBuilder : DogBuilder{
		public override void buildRace() {
			dog.Race = "Bulldog";
		}
		
		public override void buildNumber(int number) { 
			dog.Number = number; 
		}
		
		public override void buildPrice(double price) {
			dog.Price = price; 
		}
		
		public override void buildSpecies() {
			dog.Species = "Dog"; 
		}
	}

	abstract class CatBuilder{
		protected Cat cat;
		
		public Cat Cat{
			get{ return cat; }
		}
		
		public void createNewCat() { 
			cat = new Cat();
		}
		
		public abstract void buildNumber(int number);
		public abstract void buildPrice(double price);
		public abstract void buildSpecies();
		public abstract void buildRace();
	}
	
	class PersianCatBuilder : CatBuilder{
		public override void buildRace() {
			cat.Race = "Persian";
		}
		
		public override void buildNumber(int number) { 
			cat.Number = number; 
		}
		
		public override void buildPrice(double price) {
			cat.Price = price; 
		}
		
		public override void buildSpecies() { 
			cat.Species = "Cat"; 
		}
	}
	
	class SiameseCatBuilder : CatBuilder{
		public override void buildRace() {
			cat.Race = "Siamese ";
		}
		
		public override void buildNumber(int number) { 
			cat.Number = number; 
		}
		
		public override void buildPrice(double price) {
			cat.Price = price; 
		}
		
		public override void buildSpecies() {
			cat.Species = "Cat"; 
		}
	}

}
