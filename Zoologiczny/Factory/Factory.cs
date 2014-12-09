/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 19:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny{
	public class Cow : Farm{
	    protected string race;
		
	    public Cow(int number, double price, string spacies, string race){
	    	this.number = number;
	    	this.price = price;
	    	this.species = species;
	    	this.race = race;
	    }
	    
	}
 
	public class Chicken : Farm{
	    protected string race;
		
	    public Chicken(int number, double price, string species, string race){
	    	this.number = number;
	    	this.price = price;
	    	this.species = species;
	    	this.race = race;
	    }
	}
}
