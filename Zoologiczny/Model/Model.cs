/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Zoologiczny
{
	public enum Animals { Dog, Cat };
	
	public class Model
	{
		Client client;
		Warehouse warehouse;
		
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
		
		/*
		 * Change price
		*/		
		public void ChangeAnimalPrice(int index, int price){
			try{
				warehouse.List[index].Price = price;
			}catch(ArgumentOutOfRangeException){
				
			}
		}
		
		/*
		 * Change namber of animal
		*/	
		public void ChangeAnimalNumber(int index, int number){
			try{
				warehouse.List[index].Number = number;
			}catch(ArgumentOutOfRangeException){
				
			}
		}
		
		/*
		 * Remove item form warehouse
		*/
		public void RemoveAnimalFromWarehouse(int index, int number){
			try{
				if(warehouse.List[index].Number >= number){
					if (warehouse.List[index].Number != 0){
						warehouse.List[index].Number -= number;
					}
					else{
				        //Console.WriteLine("Cannot remove more");
					}
				}
				else{
					//Console.WriteLine("To many number to remove");
				}
			}catch(ArgumentOutOfRangeException){
				
			}
       	}
		
		/*
		 * Remove item form client's basket
		*/
		public void RemoveAnimalFromClient(int index, int number){
			try{
				if(client.List[index].Number > number){
					if (client.List[index].Number != 0){
						client.List[index].Number -= number;
					}
					else{
						//Console.WriteLine("Cannot remove more");
					}
				}
				else{
					//Console.WriteLine("To many number to remove");
				}
			}catch(ArgumentOutOfRangeException){
				
			}
       	}
         
		/*
		 *  Add animal to warehouse only if list don't have animal with this type 
		*/
		public void AddAnimalToWarehouse(Animal animal){
			Boolean dodaj = true;
			foreach(Animal an in warehouse.List){
				if(an.GetType().Equals(animal.GetType())){
					dodaj = false;
				}
			}
			if(dodaj){
				warehouse.AddAnimal(animal);
			}else{
				//Console.WriteLine("Animal already exist");
			}
		}
		
		/*
		 *  Add animal to client's basket only if list don't have animal with this type 
		*/
		public void AddAnimalToClient(int index, int number){
			try{
				if(warehouse.List[index].Number > number){
					client.AddAnimal((Animal)warehouse.List[index].Clone());
					client.List[client.List.Count - 1].Number = number;
					RemoveAnimalFromWarehouse(index, number);
					client.CalculateSum();
				}else{
					//Console.WriteLine("Cannot add to basket");
				}
			}catch(ArgumentOutOfRangeException){
				
			}
		}
		
		/*
		 * Create new list for client
		*/
		public void BuyAllAnimals(){
			client = new Client();
		}
	}
}
