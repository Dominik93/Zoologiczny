/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny{
	public class View{ // observer
		/*
		Model model;
		
		public View(Model model){
			this.model = model;
		}
		*/
		public enum Animals { Dog, Cat, Cow, Chicken }
		
		public void WaitAndClear(){
			Console.WriteLine("Press any key");
			Console.ReadKey();
	        Console.Clear();
		}
		
		public int EnterIntNumber(){
			return Convert.ToInt32(Console.ReadLine());
		}
		
		public string EnterString(){
			return Console.ReadLine();
		}
		
		public double EnterDoubleNumber(){
			return Convert.ToDouble(Console.ReadLine());
		}
		
		public void DisplayAvailableAnimals(){
			int i = 0;
			foreach(Animals element in Enum.GetValues(typeof(Animals))){
				Console.WriteLine(i++ + " - " + element.ToString());
			}
		}
		
		public void DisplayMainOptions(){
			Console.WriteLine("0 - Exit\n1 - Add animal to warehouse\n2 - Show warehouse status\n3 - Remove from warehouse\n" +
			                  "4 - Add to basket\n5 - Display basket\n6 - Remove from basket\n7 - Change price\n8 - Change number\n9 - Buy");
		}
		
		public void DisplayError(string error){
			Console.WriteLine(" ---- " + error + " ----");
		}
		
		public void DisplayMasage(string msg){
			Console.WriteLine(msg);
		}
		
		public void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list){
			Console.WriteLine("Warehouse status:");
			int i = 0;
			foreach(Animal animal in list){
				string s = "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";
				Console.WriteLine(i++ + "- " + s);
			}
		}
		
		public void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum){
			Console.WriteLine("Client basket:");
			foreach(Animal animal in list){
				string s = "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";;
				Console.WriteLine(s);
			}
		    Console.WriteLine("Price " + sum);
		}
		
		public void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
			Console.WriteLine("Client basket:");
			foreach(Animal animal in list){
				string s ="I'm " + animal.GetType() + " number " + animal.Number + " price " + animal.Price + "\n";
				Console.WriteLine(s);
			}
		}
	}
}
