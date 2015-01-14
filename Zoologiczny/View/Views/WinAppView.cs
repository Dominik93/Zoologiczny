/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 18:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using PetShop.M;
using PetShop.M.Classes.Product;
using PetShop.M.Classes.Mediator;
using PetShop.V;
using PetShop.V.WindowsApp;

namespace PetShop.V.Views{
	
	public class WinAppView : View{

		public override void InitComponent(){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			this.Form = new MainForm();
		}
		
		public override void StartApplication(){
			Application.Run((MainForm)Form);
		}
		
		public override void Update(Model model){
			this.DisplayWarehouseStatus(model.Warehouse.GetValues());
			this.DisplayClientStatus(model.Client.GetValues(), model.Client.Sum, model.Client.Credit);
			this.DisplayLogs(model.Logs);
		}
		
		public override string GetState(){
			return ((MainForm)Form).GetState();
		}
		
		public override string EnterAnimalNumberWerehouse(){
			return ((MainForm)Form).GetNumber();
		}
		
		public override string EnterAnimalNumberClient(){
			return ((MainForm)Form).GetNumber();
		}
		
		public override string EnterAnimal(){
			return ((MainForm)Form).GetAnimal();
		}
		
		public override string EnterPrice(){
			return ((MainForm)Form).GetPrice();
		}
		
		public override void DisplayLogs(Logs logs){
			string s = "Logs:\n";
			foreach (Registry registry in logs.List){
				foreach (Animal animal in registry.List){
					s += animal.Name() + " number " + animal.Number + " price " + animal.Price + "\n";
				}
				s += "Suma = "+ registry.Sum +"\nData " + registry.Date + "\n--------------------\n";
			}
			((MainForm)Form).SetTextLogs(s);
		}
		
		public override void DisplayError(string error){
			MessageBox.Show(error,
			                "Error",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Exclamation,
			                MessageBoxDefaultButton.Button1);
		}
		
		public override void DisplayMasage(string msg){
			MessageBox.Show(msg,
			                "Message",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Exclamation,
			                MessageBoxDefaultButton.Button1);
		}
		
		public override void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list){
			string s = "Warehouse status:\n";
			foreach(Animal animal in list){
				s += animal.Name() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			((MainForm)Form).SetTextWarehouse(s);
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum, double credit){
			string s  = "Client basket:\n";
			foreach(Animal animal in list){
				s +=  animal.Name() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			s +="Price " + sum;
			((MainForm)Form).SetTextClient(s);
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
			string s  = "Client basket:\n";
			foreach(Animal animal in list){
				s +=  animal.Name() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			((MainForm)Form).SetTextClient(s);
		}
		
		public override void DisplayAvailableAnimals(){
			string s = "";
			foreach(Animals element in Enum.GetValues(typeof(Animals))){
				s += element.ToString();
			}
			MessageBox.Show(s,
			                "Avalible animals",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Exclamation,
			                MessageBoxDefaultButton.Button1);
		}
		
		public override void DisplayMainOptions(){	}
		
		public override void WaitAndClear(){	}
		
		public override string EnterOption(){
			return "";
		}
	}
}
