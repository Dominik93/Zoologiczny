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

        public Client(){
        	this.sum = 0;
        	this.state = "active";
        }
        
        public double Sum{
            get { return sum; }
            set { sum = value; }
        }
        
        public string State{
            get { return state; }
            set { state = value; }
        }
        
        public void CalculateSum(){
        	if(this.State.Equals("active")){
	        	this.sum = 0;
	        	foreach(Animal animal in instance.Values){
	        		this.sum = this.sum + (animal.Number * animal.Price);
	        	}
        	}
        }
		
		/*
		 *  Add animal to client's basket only if list don't have animal with this type : prototype pattern
		 */
		public void AddAnimalToClient(Warehouse warehouse,string key, int number){
			if(this.State.Equals("active")){
				if(warehouse.Instance[key].Number >= number){
					Animal animal = (Animal)warehouse.Instance[key].Clone(); 
					animal.Number = number;
					warehouse.Instance[key].Number -= number;
					this.Add(key, animal);
					this.CalculateSum();
				}else{
					//Console.WriteLine("Cannot add to basket");
				}
			}
		}
		
		/*
		 * Create new list for client
		 */
		public void BuyAllAnimals(Logs logs){
			if(this.State.Equals("active")){
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
