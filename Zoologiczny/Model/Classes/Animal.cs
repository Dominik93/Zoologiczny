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
	abstract class Animal{
		protected int number;
		protected double price;
		
		public Animal(){}
		
		public int Number{
			get {return number;}
			set {number = value;}
		}
		
		public double Price{
			get {return price;}
			set {price = value;}
		}
		
		public abstract string display();
	}
}
