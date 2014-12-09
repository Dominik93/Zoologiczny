/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny{
	/*
	abstract class AnimalBuilder{
		protected Animal animal;
		
		public Animal Animal{
			get{ return animal; }
		}
		
		public void CreateNewAnimal() { 
			animal = new Animal();
		}
		
		public abstract void BuildNumber(int number);
		public abstract void BuildPrice(double price);
		
		public abstract void BuildSpecies();
		
		public abstract void BuildRace();
	}
	
	abstract class PetBuilder : AnimalBuilder{
		
	}
	
	class DogBuilder : PetBuilder{
		
		public override void BuildRace() {
			animal.Race = "Labrador";
		}
		
		public override void BuildNumber(int number) { 
			animal.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			animal.Price = price; 
		}
		
		public override void BuildSpecies() { 
			animal.Species = "Dog"; 
		}
	}

	class CatBuilder: PetBuilder{
		
		public void Cast(){
			animal = (Cat)animal;
		}
		public override void BuildRace() {
			animal.Race = "Persian";
		}
		
		public override void BuildNumber(int number) { 
			animal.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			animal.Price = price; 
		}
		
		public override void BuildSpecies() { 
			animal.Species = "Cat"; 
		}
	}
	*/
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
			dog.Race = "Dog";
		}
		
		public override void BuildNumber(int number) { 
			dog.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			dog.Price = price; 
		}
		
		public override void BuildSpecies() { 
			dog.Species = "Pet"; 
		}
	}
	
	class BulldogDogBuilder : DogBuilder{
		public override void BuildRace() {
			dog.Race = "Dog";
		}
		
		public override void BuildNumber(int number) { 
			dog.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			dog.Price = price; 
		}
		
		public override void BuildSpecies() {
			dog.Species = "Pet"; 
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
			cat.Race = "Cat";
		}
		
		public override void BuildNumber(int number) { 
			cat.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			cat.Price = price; 
		}
		
		public override void BuildSpecies() { 
			cat.Species = "Pet"; 
		}
	}
	
	class SiameseCatBuilder : CatBuilder{
		public override void BuildRace() {
			cat.Race = "Cat ";
		}
		
		public override void BuildNumber(int number) { 
			cat.Number = number; 
		}
		
		public override void BuildPrice(double price) {
			cat.Price = price; 
		}
		
		public override void BuildSpecies() {
			cat.Species = "Pet"; 
		}
	}

}
