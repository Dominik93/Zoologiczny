/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny{
	
	public class Model : Observable {
		Client client;
		Warehouse warehouse;
		
		private readonly List<View> views = new List<View>();
		
		public Model(){
			client = new Client();
			warehouse = new Warehouse();
		}
		
		public Client Client{
			get { return client; }
			set { client = value; }
		}
		
		public Warehouse Warehouse{
			get { return warehouse; }
			set { warehouse = value; }
		}
		
		public void Attach(View view){
			views.Add(view);
		}
		public void Detach(View view){
			views.Remove(view);
		}
		public void Notify(){
			foreach (View view in views){
				view.Update(this);
			}
		}
		
		/*
		 * Change price
		 */
		public void ChangeAnimalPrice(string key, double price){
			try{
				warehouse.Instance[key].Price = price;
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 * Change namber of animal
		 */
		public void ChangeAnimalNumber(string key, int number){
			try{
				warehouse.Instance[key].Number = number;
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 * Remove item form warehouse/client
		 */
		public void RemoveAnimal(ProductContainer pc, string key, int number){
			try{
				if(pc.Instance[key].Number >= number){
					if (pc.Instance[key].Number != 0){
						pc.Instance[key].Number -= number;
					}else{
						//Console.WriteLine("Cannot remove more");
					}
				}else{
					//Console.WriteLine("To many number to remove");
				}
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 *  Add animal to warehouse only if list don't have animal with this type
		 */
		public void AddAnimalToWarehouse(string race, Animal animal){
			warehouse.Add(race, animal);
		}
		
		public void AddNumberOfAnimal(string race, int number){
			try{
				warehouse.Instance[race].Number += number;
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 *  Add animal to client's basket only if list don't have animal with this type
		 */
		public void AddAnimalToClient(string key, int number){
			if(warehouse.Instance[key].Number >= number){
				Animal animal = (Animal)warehouse.Instance[key].Clone();
				animal.Number = number;
				warehouse.Instance[key].Number -= number;
				client.Add(key, animal);
				client.CalculateSum();
			}else{
				//Console.WriteLine("Cannot add to basket");
			}
		}
		
		/*
		 * Create new list for client
		 */
		public void BuyAllAnimals(){
			List<string> list;
			list = new List<string>();
			foreach(string s in client.GetKeys())
				list.Add(s);
			foreach(string s in list)
				client.Instance.Remove(s);
			client.CalculateSum();
		}
	}
}
