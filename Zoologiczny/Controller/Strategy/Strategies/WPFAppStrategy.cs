/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 12/16/2014
 * Time: 00:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using PetShop.Builder.Director;
using PetShop.Builder.Builders;
using PetShop.M;
using PetShop.M.Classes.Product;
using PetShop.C.Strategy;
using PetShop.Factory;
using PetShop.V;
using PetShop.V.WindowsApp;

namespace PetShop.C.Strategy.Strategies{
	public class WPFAppStrategy : BaseStrategy{
		public override void InitModelAndView(Model model, View view){
			this.model = model;
			this.view = view;
		}
		
		public override void Start(){
			view.InitComponent();
			
			((WPFForm)view.Form).RegisterButton1EventHandler(new System.Windows.RoutedEventHandler(this.Button1Click));
			((WPFForm)view.Form).RegisterButton2EventHandler(new System.Windows.RoutedEventHandler(this.Button2Click));
			((WPFForm)view.Form).RegisterButton3EventHandler(new System.Windows.RoutedEventHandler(this.Button3Click));
			((WPFForm)view.Form).RegisterButton4EventHandler(new System.Windows.RoutedEventHandler(this.Button4Click));
			((WPFForm)view.Form).RegisterButton5EventHandler(new System.Windows.RoutedEventHandler(this.Button5Click));
			((WPFForm)view.Form).RegisterButton6EventHandler(new System.Windows.RoutedEventHandler(this.Button6Click));
			((WPFForm)view.Form).RegisterButton7EventHandler(new System.Windows.RoutedEventHandler(this.Button7Click));
			((WPFForm)view.Form).RegisterComboBox1EventHendler(new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox1Change));
			((WPFForm)view.Form).RegisterComboBox2EventHendler(new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox2Change));
			((WPFForm)view.Form).RegisterComboBox3EventHendler(new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox3Change));
			((WPFForm)view.Form).RegisterComboBox4EventHendler(new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox4Change));
			((WPFForm)view.Form).RegisterComboBox5EventHendler(new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox5Change));
			view.StartApplication();
		}
		
		void Button1Click(object sender, RoutedEventArgs e){
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
			model.Client.AddAnimalToClient(model.Warehouse,
			                               ((Animal)((WPFForm)view.Form).GetWGrid().SelectedItem).Name(),
			                               Convert.ToInt32(view.EnterAnimalNumberClient()));
			}catch(Exception){
				view.DisplayError("Animal is not chose!");
			}
			model.Notify();
		}
		
		void Button6Click(object sender, EventArgs e){
			try{
				model.Client.RemoveAnimalFromClient(model.Warehouse, view.EnterAnimal(), Convert.ToInt32(view.EnterAnimalNumberClient()));
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
		
		void ComboBox5Change(object sender, EventArgs e){
			var comboBox = sender as ComboBox;
			if(comboBox.SelectedIndex == 0){
				model.Client.State = "Active";
			}
			else if(comboBox.SelectedIndex == 1){
				model.Client.State = "Disactive";
			}
			model.Notify();
		}

		void ComboBox1Change(object sender, EventArgs e){
			var comboBox = sender as ComboBox;
			if(comboBox.SelectedIndex == 0){
				((WPFForm)view.Form).SpeciesComboBox.Visibility = Visibility.Hidden;
				((WPFForm)view.Form).RacesFarmComboBox.Visibility = Visibility.Hidden;
				((WPFForm)view.Form).RacesPetComboBox.Visibility = Visibility.Hidden;
			}
			else if(comboBox.SelectedIndex == 1){
				((WPFForm)view.Form).SpeciesComboBox.Visibility = Visibility.Visible;
				((WPFForm)view.Form).RacesFarmComboBox.Visibility = Visibility.Hidden;
				((WPFForm)view.Form).RacesPetComboBox.Visibility = Visibility.Hidden;
			}
			model.Notify();
		}
		
		void ComboBox2Change(object sender, EventArgs e){
			var comboBox = sender as ComboBox;
			if(comboBox.SelectedIndex == 0){
				((WPFForm)view.Form).SpeciesComboBox.Visibility = Visibility.Hidden;
				((WPFForm)view.Form).RacesFarmComboBox.Visibility = Visibility.Hidden;
				((WPFForm)view.Form).RacesPetComboBox.Visibility = Visibility.Hidden;
			}
			else if(comboBox.SelectedIndex == 1){
				((WPFForm)view.Form).RacesPetComboBox.Visibility = Visibility.Visible;
				((WPFForm)view.Form).RacesFarmComboBox.Visibility = Visibility.Hidden;
			}
			else if(comboBox.SelectedIndex == 2){
				((WPFForm)view.Form).RacesFarmComboBox.Visibility = Visibility.Visible;
				((WPFForm)view.Form).RacesPetComboBox.Visibility = Visibility.Hidden;
			}
			model.Notify();
		}
		
		void ComboBox3Change(object sender, EventArgs e){
			var comboBox = sender as ComboBox;
			if(comboBox.SelectedIndex == 0){
				((WPFForm)view.Form).RacesPetComboBox.Visibility = Visibility.Hidden;
			}
			model.Notify();
		}
		
		void ComboBox4Change(object sender, EventArgs e){
			var comboBox = sender as ComboBox;
			if(comboBox.SelectedIndex == 0){
				((WPFForm)view.Form).RacesFarmComboBox.Visibility = Visibility.Hidden;
			}
			model.Notify();
		}
	}	
}
