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
using PetShop.Observer;
using PetShop.M.Classes.Container;
using PetShop.M.Classes.Mediator;
using PetShop.M.Classes.Product;
using PetShop.V;

namespace PetShop.M{
	
	public class Model : IObservable {
		Client client;
		Warehouse warehouse;
		Logs logs;
		
		readonly List<View> views = new List<View>();
		
		public Model(){
			client = new Client();
			warehouse = Warehouse.InstanceWarehouse;
			logs = new Logs();
		}
		
		public Client Client{
			get { return client; }
			set { client = value; }
		}
		
		public Logs Logs{
			get { return logs; }
			set { logs = value; }
		}
		
		public Warehouse Warehouse{
			get { return warehouse; }
			set { warehouse = value; }
		}
		/*
		 * Observator pattern
		 */ 
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
	}
}
