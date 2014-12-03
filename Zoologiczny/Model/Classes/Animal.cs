/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-02
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	public abstract class Animal : ICloneable{
		protected int number;
		protected double price;
		
		public enum Animals { Dog, Cat, Cow, Chicken }
		
		public Animal(){}

		public int Number{
			get {return number;}
			set {number = value;}
		}
		
		public double Price{
			get {return price;}
			set {price = value;}
		}
	
		public object Clone(){
	        return this.MemberwiseClone();
	    }
		
		public abstract string display();
	}
}
