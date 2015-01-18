/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 12/21/2014
 * Time: 21:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using PetShop.M.Classes.Product;
 
namespace PetShop.Builder.Builders{
	/*
	 * abstract Dog builder, base for creating dog : builder pattern
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
	
	/*
	 * dog builders : builder pattern
	 */
	class DogDogBuilder : DogBuilder{
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
	
}