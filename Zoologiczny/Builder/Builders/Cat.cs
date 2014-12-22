/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.M.Classes.Product;

namespace PetShop.Builder.Builders{
	
	/*
	 * abstract Cat builder, base for creating cat : builder pattern
	 */
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
	
	/*
	 * cat builders : builder pattern
	 */
	class CatCatBuilder : CatBuilder{
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
