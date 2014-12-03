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
		
		public string Species{
			get {return species;}
			set {species = value;}
		}
	}
}
