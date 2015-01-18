/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 12/21/2014
 * Time: 21:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.M.Classes.Product;

namespace PetShop.Factory{
	
	public class Cow : Farm{
	    protected string race;
		
	    public string Race{
			get {return race;}
			set {race = value;}
		}
	    
	    public Cow(int number, double price, string species, string race){
	    	this.number = number;
	    	this.price = price;
	    	this.species = species;
	    	this.race = race;
	    }
	    
	    public override string Name(){
			return "Cow";
		}
	    
	}
}
