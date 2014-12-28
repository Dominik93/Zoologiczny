/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 19:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.M.Classes.Product;

namespace PetShop.Factory{
	public class Chicken : Farm{
	    protected string race;
		
	    public Chicken(int number, double price, string species, string race){
	    	this.number = number;
	    	this.price = price;
	    	this.species = species;
	    	this.race = race;
	    }
	    
	    public override string Name()
		{
			return "Chicken";
		}
	}
}
