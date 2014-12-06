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
		
		public void CreateNewDog() { 
			dog = new Dog();
		}
		
		public abstract void BuildNumber(int number);
		public abstract void BuildPrice(double price);
		public abstract void BuildSpecies();
		public abstract void BuildRace();
	}
	
	class LabradorDogBuilder : DogBuilder{
		public override void BuildRace() {
			dog.Race = "Labrador";
		}
		
		public override void BuildNumber(int number) { 
			dog.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			dog.Price = price; 
		}
		
		public override void BuildSpecies() { 
			dog.Species = "Dog"; 
		}
	}
	
	class BulldogDogBuilder : DogBuilder{
		public override void BuildRace() {
			dog.Race = "Bulldog";
		}
		
		public override void BuildNumber(int number) { 
			dog.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			dog.Price = price; 
		}
		
		public override void BuildSpecies() {
			dog.Species = "Dog"; 
		}
	}

	abstract class CatBuilder{
		protected Cat cat;
		
		public Cat Cat{
			get{ return cat; }
		}
		
		public void CreateNewCat() { 
			cat = new Cat();
		}
		
		public abstract void BuildNumber(int number);
		public abstract void BuildPrice(double price);
		public abstract void BuildSpecies();
		public abstract void BuildRace();
	}
	
	class PersianCatBuilder : CatBuilder{
		public override void BuildRace() {
			cat.Race = "Persian";
		}
		
		public override void BuildNumber(int number) { 
			cat.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			cat.Price = price; 
		}
		
		public override void BuildSpecies() { 
			cat.Species = "Cat"; 
		}
	}
	
	class SiameseCatBuilder : CatBuilder{
		public override void BuildRace() {
			cat.Race = "Siamese ";
		}
		
		public override void BuildNumber(int number) { 
			cat.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			cat.Price = price; 
		}
		
		public override void BuildSpecies() {
			cat.Species = "Cat"; 
		}
	}

}
