/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.M.Classes.Product;
using PetShop.M.Classes.Mediator;

namespace PetShop.M.Classes.Container{
	public class Client : ProductContainer{
        double sum;
        string state;
        double credit;

        public Client(){
        	this.sum = 0;
        	this.state = "Active";
        	this.credit = 1000;
        }
        
        public double Credit{
            get { return credit; }
            set { credit = value; }
        }
        
        public double Sum{
            get { return sum; }
            set { sum = value; }
        }
        
        public string State{
            get { return state; }
            set { state = value; }
        }
        
        private Boolean CanBuy(int number, double price){
        	if(this.State.Equals("Active")){
        		if(this.Credit < (number * price)){
        			return false;
        		}
        	}
        	return true;
        }
        
        public void CalculateSum(){
        	if(this.State.Equals("Active")){
	        	this.sum = 0;
	        	this.credit = 1000;
	        	foreach(Animal animal in instance.Values){
	        		this.sum = this.sum + (animal.Number * animal.Price);
	        		this.credit -= (animal.Number * animal.Price);
	        	}
        	}
        }
		
		/*
		 *  Add animal to client's basket only if list don't have animal with this type : prototype pattern
		 */
		public void AddAnimalToClient(Warehouse warehouse, string key, int number){
			if(this.State.Equals("Active")){
				if(warehouse.Instance[key].Number >= number){
					if(this.CanBuy(number, warehouse.Instance[key].Price)){
						Animal animal = (Animal)warehouse.Instance[key].Clone(); 
						animal.Number = number;
						warehouse.Instance[key].Number -= number;
						if(this.Instance.ContainsKey(key)){
							this.Instance[key].Number += number;
						}
						else{
							this.Add(key, animal);
						}
						this.CalculateSum();
					}
				}else{
					//Console.WriteLine("Cannot add to basket");
				}
			}
		}
		
		/*
		 * Remove item form warehouse/client
		 */
		public void RemoveAnimalFromClient(ProductContainer pc, string key, int number){
			try{
				if(this.Instance[key].Number >= number){
					if (this.Instance[key].Number != 0){
						this.Instance[key].Number -= number;
						pc.Instance[key].Number += number;
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
		 * Create new list for client
		 */
		public void BuyAllAnimals(Logs logs){
			if(this.State.Equals("Active")){
				// mediator pattern
				logs.addRegistry(new Registry(this.Instance.Values.ToList<Animal>(), this.Sum));
				List<string> list;
				list = new List<string>();
				foreach(string s in this.GetKeys())
					list.Add(s);
				foreach(string s in list)
					this.Instance.Remove(s);
				this.CalculateSum();
			}
		}
    }
}
