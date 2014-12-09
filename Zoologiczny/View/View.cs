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
	
	public abstract class View : Observer{
		
		public enum Animals { Dog, Cat, Cow, Chicken }
		
		public abstract void InitComponent();
		public abstract void Update(Model model);
		public abstract void DisplayError(string error);
		public abstract void DisplayMasage(string msg);
		
		public abstract void WaitAndClear();
		public abstract int EnterIntNumber();
		public abstract string EnterString();
		public abstract double EnterDoubleNumber();
		public abstract void DisplayAvailableAnimals();
		public abstract void DisplayMainOptions();
		public abstract void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list);
		public abstract void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum);
		public abstract void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list);
	}
}
