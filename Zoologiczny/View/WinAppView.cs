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

namespace Zoologiczny{
	
	public class WinAppView : View{

		public override void InitComponent(){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			mainForm = new MainForm();
		}
		
		public override void StartApplication(){
			Application.Run(mainForm);
		}
		
		public override void Update(Model model){
			this.DisplayWarehouseStatus(model.Warehouse.GetValues());
			this.DisplayClientStatus(model.Client.GetValues(), model.Client.Sum);
		}
		
		public override string EnterAnimalNumber(){
			return mainForm.GetNumber();
		}
		
		public override string EnterAnimal(){
			return mainForm.GetAnimal();
		}
		
		public override string EnterPrice(){
			return mainForm.GetPrice();
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
			string s = "Warehouse status:";
			foreach(Animal animal in list){
				s += "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";
				mainForm.SetTextWarehouse(s);
			}
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum){
			string s  = "Client basket:";
			foreach(Animal animal in list){
				s += "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			s +="Price " + sum;
			mainForm.SetTextClient(s);
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
			string s  = "Client basket:";
			foreach(Animal animal in list){
				s += "I'm " + animal.GetType() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			mainForm.SetTextClient(s);
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
