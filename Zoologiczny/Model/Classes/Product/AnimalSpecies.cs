/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.Factory;

namespace PetShop.M.Classes.Product{
	public abstract class Pet : Animal{
		protected string species;
		
		public Pet(){}
		
		public string Species{
			get {return species;}
			set {species = value;}
		}
	}
	
	
	public abstract class Farm : Animal{
		
		protected string species;
		
		public Farm(){}
		
		public static Farm FarmFactory(Animals farmType, int number, double price){
			switch(farmType){
				case(Animals.Cow):
					return new Cow(number, price, "Farm", "Cow");
				case(Animals.Chicken):
					return new Chicken(number, price, "Farm", "Chicken");
				default:
					break;
			}
			throw new System.NotSupportedException("The pizza type " + farmType.ToString() + " is not recognized.");
		}
		
		public string Species{
			get {return species;}
			set {species = value;}
		}
	}
}
