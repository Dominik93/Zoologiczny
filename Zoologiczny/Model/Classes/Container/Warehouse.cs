﻿/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.M.Classes.Product;

namespace PetShop.M.Classes.Container{
	public class Warehouse: ProductContainer {
		
		private static Warehouse instanceWarehouse;
		
		private Warehouse() {}
		// singleton pattern
		public static Warehouse InstanceWarehouse{
			get {
				if (instanceWarehouse == null){
					instanceWarehouse = new Warehouse();
				}
				return instanceWarehouse;
			}
		}
		
		/*
		 *  Add animal to warehouse only if list don't have animal with this type
		 */
		public void AddAnimalToWarehouse(string race, Animal animal){
			this.Add(race, animal);
		}
		
		public void AddNumberOfAnimal(string race, int number){
			try{
				this.Instance[race].Number += number;
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 * Remove item form warehouse
		 */
		public void RemoveAnimalFromWarehouse(string key, int number){
			try{
				if(this.Instance[key].Number >= number){
					if (this.Instance[key].Number != 0){
						this.Instance[key].Number -= number;
					}
				}
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 * Change price
		 */
		public void ChangeAnimalPrice(string key, double price){
			try{
				this.Instance[key].Price = price;
			}catch(KeyNotFoundException){
				
			}
		}
		
		/*
		 * Change namber of animal
		 */
		public void ChangeAnimalNumber(string key, int number){
			try{
				this.Instance[key].Number = number;
			}catch(KeyNotFoundException){
				
			}
		}
		
	}
}
