/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

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
			get {return client;}
			set {client = value;}
		}
		
		public Warehouse Warehouse{
			get {return warehouse;}
			set {warehouse = value;}
		}
		
		public void addAnimalToWarehouse(Animal animal){
			Boolean dodaj = true;
			foreach(Animal an in warehouse.List){
				if(an.GetType().Equals(animal.GetType())){
					dodaj = false;
				}
			}
			if(dodaj)
				warehouse.addAnimal(animal);
			else
				Console.WriteLine("Animal already exist");
		}
		
		public void removeAnimalFromWarehouse(int index, int number){
			if(warehouse.List[index].Number > number)
				if (warehouse.List[index].Number != 0)
		         	warehouse.List[index].Number -= number;
		        else
		        	Console.WriteLine("Cannot remove more");
			else
				Console.WriteLine("To many number to remove");
       	}
		
		public void removeAnimalFromClient(int index, int number){
			if(client.List[index].Number > number)
				if (client.List[index].Number != 0)
		         	client.List[index].Number -= number;
		        else
		        	Console.WriteLine("Cannot remove more");
			else
				Console.WriteLine("To many number to remove");
       	}
         
		
		public void addAnimalToClient(int index, int number){
			if(warehouse.List[index].Number > number){
				client.addAnimal((Animal)warehouse.List[index].Clone());
				client.List[client.List.Count - 1].Number = number;
				removeAnimalFromWarehouse(index, number);
				client.calculateSum();
			}else{
				Console.WriteLine("Cannot add to basket");
			}
			
		}
	}
}
