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

namespace Zoologiczny{
	
	public class WinAppStrategy : BaseStrategy{
		
		public override void InitModelAndView(Model model, View view){
			this.model = model;
			this.view = view;
		}
		
		public override void Start(){
			view.InitComponent();
			view.MainForm.RegisterButton1EventHandler(new System.EventHandler(this.Button1Click));
			view.MainForm.RegisterButton2EventHandler(new System.EventHandler(this.Button2Click));
			view.MainForm.RegisterButton3EventHandler(new System.EventHandler(this.Button3Click));
			view.MainForm.RegisterButton4EventHandler(new System.EventHandler(this.Button4Click));
			view.MainForm.RegisterButton5EventHandler(new System.EventHandler(this.Button5Click));
			view.MainForm.RegisterButton6EventHandler(new System.EventHandler(this.Button6Click));
			view.MainForm.RegisterButton7EventHandler(new System.EventHandler(this.Button7Click));
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
						dogBreeder.ConstructDog(view.EnterAnimalNumber(), view.EnterPrice());
						
						model.AddAnimalToWarehouse(dogBreeder.Dog.Race, dogBreeder.Dog);
						dogBreeder = null;
					}catch(InvalidCastException){
					}
					break;
				case("Cat"): // add cat
					try{
						// cat builder
						CatBreeder catBreeder = new CatBreeder();
						catBreeder.CatBuilder = new PersianCatBuilder();
						catBreeder.CatBuilder.CreateNewCat();
						catBreeder.ConstructCat(view.EnterAnimalNumber(), view.EnterPrice());
						
						model.AddAnimalToWarehouse(catBreeder.Cat.Race,catBreeder.Cat);
						catBreeder = null;
					}catch(InvalidCastException){
						view.DisplayError("It is not the number!");
					}
					break;
				case("Cow"): // add cow
					try{
						// factory method
						model.AddAnimalToWarehouse("Cow", Farm.FarmFactory(Animal.Animals.Cow, view.EnterAnimalNumber(), view.EnterPrice()));
					}catch(InvalidCastException){
						view.DisplayError("It is not the number!");
					}
					break;
				case("Chicken"): // add Chicken
					try{
						// factory method
						model.AddAnimalToWarehouse("Chicken", Farm.FarmFactory(Animal.Animals.Chicken, view.EnterAnimalNumber(), view.EnterPrice()));
					}catch(InvalidCastException){
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
		}
		
		void Button3Click(object sender, EventArgs e){
		}
		
		void Button4Click(object sender, EventArgs e){
		}
		
		void Button5Click(object sender, EventArgs e){
		}
		
		void Button6Click(object sender, EventArgs e){
		}
		
		void Button7Click(object sender, EventArgs e){
		}
	}
}
