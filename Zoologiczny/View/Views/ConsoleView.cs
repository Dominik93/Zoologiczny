/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 18:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.M.Classes.Mediator;
using PetShop.M.Classes.Product;
using PetShop.M;

namespace PetShop.V.Views{
	public class ConsoleView : View{
		
		public override void InitComponent(){ }
		
		public override void StartApplication(){
			Console.WriteLine("Start: Dominik Ślusarz");
		}
		
		public override void Update(Model model){
			Console.WriteLine("View was updated");
			this.DisplayWarehouseStatus(model.Warehouse.GetValues());
			this.DisplayClientStatus(model.Client.GetValues(), model.Client.Sum,model.Client.Credit);
			this.DisplayLogs(model.Logs);
			this.WaitAndClear();
		}
		
		private void WaitAndClear(){
			Console.WriteLine("Press any key");
			Console.ReadKey();
			Console.Clear();
		}
		
		public override void DisplayLogs(Logs logs){
            foreach(Registry registry in logs.List){
                Console.WriteLine("Logs:");
                foreach (Animal animal in registry.List){
                	Console.WriteLine("I'm " + animal.GetType() + " number " + animal.Number + " price " + animal.Price + "\n");
                }
                Console.WriteLine("Data "+ registry.Date);
            }
        }
		
		public override string GetState(){
			return Console.ReadLine();
		}
		
		public override string EnterOption(){
			return Console.ReadLine();
		}
		
		
		public override string EnterAnimalNumberWerehouse(){
			return Console.ReadLine();
		}
		
		public override string EnterAnimalNumberClient(){
			return Console.ReadLine();
		}
		
		public override string EnterAnimal(){
			return Console.ReadLine();
		}
		
		public override string EnterPrice(){
			return Console.ReadLine();
		}
		
		public override void DisplayAvailableAnimals(){
			foreach(Animals element in Enum.GetValues(typeof(Animals))){
				Console.WriteLine(element.ToString());
			}
		}
		
		public override void DisplayMainOptions(){
			Console.WriteLine("0 - Exit\n" +
			                  "1 - Add animal to warehouse\n" +
			                  "2 - Show warehouse status\n" +
			                  "3 - Remove from warehouse\n" +
			                  "4 - Add to basket\n" +
			                  "5 - Display basket\n" +
			                  "6 - Remove from basket\n" +
			                  "7 - Change price\n" +
			                  "8 - Change number\n" +
			                  "9 - Buy\n" +
			                  "10 - Change state");
		}
		
		public override void DisplayError(string error){
			Console.WriteLine(" ---- " + error + " ----");
		}
		
		public override void DisplayMasage(string msg){
			Console.WriteLine(msg);
		}
		
		public override void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list){
			Console.WriteLine("Warehouse status:");
			int i = 0;
			foreach(Animal animal in list){
				string s = "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";
				Console.WriteLine(i++ + "- " + s);
			}
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum, double credit){
			Console.WriteLine("Client basket:");
			foreach(Animal animal in list){
				string s = "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";;
				Console.WriteLine(s);
			}
			Console.WriteLine("Price " + sum);
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
			Console.WriteLine("Client basket:");
			foreach(Animal animal in list){
				string s ="I'm " + animal.GetType() + " number " + animal.Number + " price " + animal.Price + "\n";
				Console.WriteLine(s);
			}
		}
	}
}