/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.Builder.Builders;
using PetShop.M.Classes.Product;
	
namespace PetShop.Builder.Director{
	/*
	 * director to create dog : builder pattern
	 */
	class DogBreeder{
		private DogBuilder dogBuilder;
		/*
		 * getter and setter for dog builder
		 */
		public DogBuilder DogBuilder{
			get { return dogBuilder; }
			set { dogBuilder = value; }
		}
		/*
		 * getter for dog
		 */
		public Dog Dog {
			get { return dogBuilder.Dog; }
		}
		/*
		 * method to create dog by part
		 */
		public void ConstructDog(int number, double price){
			dogBuilder.CreateNewDog();
			dogBuilder.BuildNumber(number);
			dogBuilder.BuildPrice(price);
			dogBuilder.BuildSpecies();
			dogBuilder.BuildRace();
		}
	}
	
	/*
	 * director to create cat : builder pattern
	 */
	class CatBreeder{
		private CatBuilder catBuilder;
		/*
		 * getter and setter for cat builder
		 */
		public CatBuilder CatBuilder{
			get { return catBuilder; }
			set { catBuilder = value; }
		}
		/*
		 * getter for cat
		 */
		public Cat Cat {
			get { return catBuilder.Cat; }
		}
		/*
		 * method to create cat by part
		 */
		public void ConstructCat(int number, double price){
			catBuilder.CreateNewCat();
			catBuilder.BuildNumber(number);
			catBuilder.BuildPrice(price);
			catBuilder.BuildSpecies();
			catBuilder.BuildRace();
		}
	}
}
