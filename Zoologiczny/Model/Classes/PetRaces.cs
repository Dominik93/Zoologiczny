/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	public class Dog : Pet{
		protected string race;
			
		public Dog(){}
		
		public string Race{
			get {return race;}
			set {race = value;}
		}
		
		public override string Display(){
			string s = "I'm " + this.GetType() + " species " + this.species + " race " + this.race + " number " + this.number + " price " + this.price + "\n";
			return s;
		}
	}
	
	public class Cat : Pet{
		protected string race;
			
		public Cat(){}
		
		public string Race{
			get {return race;}
			set {race = value;}
		}
		
		public override string Display(){
			string s = "I'm " + this.GetType() + " species " + this.species + " race " + this.race + " number " + this.number + " price " + this.price + "\n";
			return s;
		}
	}
}
