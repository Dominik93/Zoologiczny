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
using PetShop.Observer;
using PetShop.M.Classes.Product;
using PetShop.M;
using PetShop.M.Classes.Mediator;

namespace PetShop.V{
	
	public abstract class View : IObserver{
		
		public enum Animals { Dog, Cat, Cow, Chicken }

		protected Object form;
		
		public Object Form{
			get { return form; }
			set { form = value; }
		}
		
		public abstract void InitComponent();
		public abstract void StartApplication();
		public abstract void Update(Model model);
		public abstract void DisplayError(string error);
		public abstract void DisplayMasage(string msg);
		
		public abstract void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list);
		public abstract void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum, double credit);
		
		public abstract void DisplayLogs(Logs logs);
		
		public abstract void DisplayAvailableAnimals();
		public abstract void DisplayMainOptions();
		public abstract void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list);
		public abstract string EnterOption();
		public abstract string EnterAnimalNumberWerehouse();
		public abstract string EnterAnimalNumberClient();
		public abstract string EnterAnimal();
		public abstract string EnterPrice();
		public abstract string GetState();
		public abstract void WaitAndClear();
	}
}
