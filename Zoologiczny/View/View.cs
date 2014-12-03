/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	public class View
	{
		/*
		Model model;
		
		public View(Model model){
			this.model = model;
		}
		*/
		
		public int enterIntNumber(){
			return Convert.ToInt32(Console.ReadLine());
		}
		
		public double enterDoubleNumber(){
			return Convert.ToDouble(Console.ReadLine());
		}
		
		public void displayAvailableAnimals(){
			Console.WriteLine("0 - Dog\n1 - Cat");
		}
		
		public void diplayMainOptions(){
			Console.WriteLine("0- Exit\n1- Add animal to warehouse\n2- Show warehouse status\n3- Remove from warehouse\n4- Add to basket\n5- Display basket\n6- Remove from basket");
		}
		
		public void displayError(string error){
			Console.WriteLine(" ---- " + error + " ----");
		}
		
		public void displayMasage(string msg){
			Console.WriteLine(msg);
		}
		
		public void displayWarehouseStatus(Warehouse werehouse){
			Console.WriteLine("Warehouse status:");
			int i = 0;
			foreach(Animal animal in werehouse.List){
				Console.WriteLine(i++ + "- " + animal.display());
			}
		}
		
		public void displayClientStatus(Client client, double sum){
			Console.WriteLine("Client backet:");
			foreach(Animal animal in client.List){
				Console.WriteLine(animal.display());
			}
		    Console.WriteLine("Price " + sum);
		}
		
		public void displayClientStatus(Client client){
			Console.WriteLine("Client backet:");
			foreach(Animal animal in client.List){
				Console.WriteLine(animal.display());
			}
		}
	}
}
