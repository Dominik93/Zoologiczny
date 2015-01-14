/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using PetShop.Builder.Director;
using PetShop.Builder.Builders;
using PetShop.M;
using PetShop.M.Classes.Product;
using PetShop.V;
using PetShop.V.WindowsApp;

namespace PetShop.C.Strategy.Strategies{
	
	public class WinAppStrategy : BaseStrategy{
		
		public override void InitModelAndView(Model model, PetShop.V.View view){
			this.model = model;
			this.view = view;
		}
		
		public override void Start(){
			// iniciation components
			view.InitComponent();
			// register event handler for button
			((MainForm)view.Form).RegisterButton1EventHandler(new System.EventHandler(this.Button1Click));
			((MainForm)view.Form).RegisterButton2EventHandler(new System.EventHandler(this.Button2Click));
			((MainForm)view.Form).RegisterButton3EventHandler(new System.EventHandler(this.Button3Click));
			((MainForm)view.Form).RegisterButton4EventHandler(new System.EventHandler(this.Button4Click));
			((MainForm)view.Form).RegisterButton5EventHandler(new System.EventHandler(this.Button5Click));
			((MainForm)view.Form).RegisterButton6EventHandler(new System.EventHandler(this.Button6Click));
			((MainForm)view.Form).RegisterButton7EventHandler(new System.EventHandler(this.Button7Click));
			((MainForm)view.Form).RegisterComboBox1SelectionChanged(new System.EventHandler(this.ComboBox1SelectionChanged));
			
			view.StartApplication();
	     }
		
		void Button1Click(object sender, EventArgs e){
			switch(view.EnterAnimal()){
				case("Dog"): // add dog
					try{
						// dog builder
						DogBreeder dogBreeder = new DogBreeder();
						dogBreeder.DogBuilder = new DogDogBuilder();
						dogBreeder.DogBuilder.CreateNewDog();
						dogBreeder.ConstructDog(Convert.ToInt32(view.EnterAnimalNumberWerehouse()), Convert.ToDouble(view.EnterPrice()));
						
						model.Warehouse.AddAnimalToWarehouse(dogBreeder.Dog.Race, dogBreeder.Dog);
						dogBreeder = null;
					}catch(InvalidCastException){
					}
					break;
				case("Cat"): // add cat
					try{
						// cat builder
						CatBreeder catBreeder = new CatBreeder();
						catBreeder.CatBuilder = new CatCatBuilder();
						catBreeder.CatBuilder.CreateNewCat();
						catBreeder.ConstructCat(Convert.ToInt32(view.EnterAnimalNumberWerehouse()), Convert.ToDouble(view.EnterPrice()));
						
						model.Warehouse.AddAnimalToWarehouse(catBreeder.Cat.Race,catBreeder.Cat);
						catBreeder = null;
					}catch(InvalidCastException){
						view.DisplayError("It is not the number!");
					}catch(FormatException){
						view.DisplayError("It is not the number!");
					}
					break;
				case("Cow"): // add cow
					try{
						// factory method
						model.Warehouse.AddAnimalToWarehouse("Cow", Farm.FarmFactory(Animal.Animals.Cow, Convert.ToInt32(view.EnterAnimalNumberWerehouse()), Convert.ToDouble(view.EnterPrice())));
					}catch(InvalidCastException){
						view.DisplayError("It is not the number!");
					}catch(FormatException){
						view.DisplayError("It is not the number!");
					}
					break;
				case("Chicken"): // add Chicken
					try{
						// factory method
						model.Warehouse.AddAnimalToWarehouse("Chicken", Farm.FarmFactory(Animal.Animals.Chicken, Convert.ToInt32(view.EnterAnimalNumberWerehouse()), Convert.ToDouble(view.EnterPrice())));
					}catch(InvalidCastException){
						view.DisplayError("It is not the number!");
					}catch(FormatException){
						view.DisplayError("It is not the number!");
					}
					break;
				default:
					view.DisplayError("Wrong choise");
					break;
			}
			model.Notify();
		}
		
		void Button2Click(object sender, EventArgs e){
			try{
				model.Warehouse.RemoveAnimalFromWarehouse(view.EnterAnimal(), Convert.ToInt32(view.EnterAnimalNumberWerehouse()));
			}catch(InvalidCastException){
				view.DisplayError("It is not the number!");
			}catch(FormatException){
				view.DisplayError("It is not the number!");
			}
			model.Notify();
		}
		
		void Button3Click(object sender, EventArgs e){
			try{
				model.Warehouse.ChangeAnimalNumber(view.EnterAnimal(), Convert.ToInt32(view.EnterAnimalNumberWerehouse()));
			}catch(InvalidCastException){
				view.DisplayError("It is not the number!");
			}catch(FormatException){
				view.DisplayError("It is not the number!");
			}
			model.Notify();
		}
		
		void Button4Click(object sender, EventArgs e){
			try{
				model.Warehouse.ChangeAnimalPrice(view.EnterAnimal(), Convert.ToDouble(view.EnterPrice()));
			}catch(InvalidCastException){
				view.DisplayError("It is not the number!");
			}catch(FormatException){
				view.DisplayError("It is not the number!");
			}
			model.Notify();
		}
		
		void Button5Click(object sender, EventArgs e){
			try{
				model.Client.AddAnimalToClient(model.Warehouse, view.EnterAnimal(), Convert.ToInt32(view.EnterAnimalNumberClient()));
			}catch(InvalidCastException){
				view.DisplayError("It is not the number!");
			}catch(FormatException){
				view.DisplayError("It is not the number!");
			}
			model.Notify();
		}
		
		void Button6Click(object sender, EventArgs e){
			try{
				model.Warehouse.RemoveAnimalFromWarehouse(view.EnterAnimal(), Convert.ToInt32(view.EnterAnimalNumberWerehouse()));
			}catch(InvalidCastException){
				view.DisplayError("It is not the number!");
			}catch(FormatException){
				view.DisplayError("It is not the number!");
			}
			model.Notify();
		}
		
		void Button7Click(object sender, EventArgs e){
			model.Client.BuyAllAnimals(model.Logs);
			model.Notify();
		}
		
		void ComboBox1SelectionChanged(object sender, EventArgs e){
			model.Client.State = view.GetState();
		}
	}
}
