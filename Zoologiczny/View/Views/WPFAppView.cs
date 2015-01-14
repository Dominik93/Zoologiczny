/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 12/16/2014
 * Time: 00:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using PetShop.M.Classes.Product;
using PetShop.M;
using PetShop.M.Classes.Mediator;
using PetShop.V.WindowsApp;
using PetShop.Factory;

namespace PetShop.V.Views{
	
	public class WPFAppView : View{
		public override void InitComponent(){
			this.Form = new WPFForm();
		}
		
		public override void StartApplication(){
			PetShop.App app = new PetShop.App();
			app.Run((WPFForm)this.Form);
		}
		
		public override void Update(Model model){
			this.DisplayWarehouseStatus(model.Warehouse.GetValues());
			this.DisplayClientStatus(model.Client.GetValues(), model.Client.Sum, model.Client.Credit);
			this.DisplayLogs(model.Logs);
			switch(((WPFForm)Form).GetSelectedComboBox()){
				case 0:
					break;
				case 1:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Animal>();
					break;
				case 2:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Pet>();
					break;
				case 3:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Farm>();
					break;
				case 4:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Cat>();
					break;	
				case 5:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Dog>();
					break;
				case 6:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Cow>();
					break;	
				case 7:
					((WPFForm)Form).WGrid.ItemsSource = model.Warehouse.getAnimal<Chicken>();
					break;	
			}
		}
		
		public override string GetState(){
			return "";
		}
		
		public override string EnterAnimalNumberWerehouse(){
			return ((WPFForm)Form).GetNumberWerehouse();
		}
		
		public override string EnterAnimalNumberClient(){
			return ((WPFForm)Form).GetNumberClient();
		}
		
		public override string EnterAnimal(){
			return ((WPFForm)Form).GetAnimal();
		}
		
		public override string EnterPrice(){
			return ((WPFForm)Form).GetPrice();
		}
		
		public override void DisplayLogs(Logs logs){
			string s = "Logs:\n";
			
			foreach (Registry registry in logs.List){
				foreach (Animal animal in registry.List){
					s +=  animal.Name() + " number " + animal.Number + " price " + animal.Price + " " + "\n";
				}
				s += "Sum = "+ registry.Sum +"\nDate " + registry.Date + "\n--------------------\n";
			}
			((WPFForm)Form).SetTextLogs(s);
		}
		
		public override void DisplayError(string error){
			MessageBoxResult result = System.Windows.MessageBox.Show(error, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
		}
		
		public override void DisplayMasage(string msg){
			MessageBoxResult result = System.Windows.MessageBox.Show(msg, "Massage", MessageBoxButton.OK, MessageBoxImage.Information);
		}
		
		public override void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list){
			string s = "Warehouse status:\n";
			foreach(Animal animal in list){
				s += animal.Name() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			((WPFForm)Form).SetTextWarehouse(s);
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum, double credit){
			string s  = "Credit = "+ credit +"\nClient basket:\n";
			foreach(Animal animal in list){
				s += animal.Name() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			s +="Price " + sum;
			((WPFForm)Form).SetTextClient(s);
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
			string s  = "Client basket:\n";
			foreach(Animal animal in list){
				s += animal.Name() +  " number " + animal.Number + " price " + animal.Price + "\n";
			}
			((WPFForm)Form).SetTextClient(s);
		}
		
		public override void DisplayAvailableAnimals(){
			string s = "";
			foreach(Animals element in Enum.GetValues(typeof(Animals))){
				s += element.ToString();
			}
		}
		
		public override void DisplayMainOptions(){
		}
		
		public override void WaitAndClear(){
		}
		
		public override string EnterOption(){
			return "";
		}
	}
}
