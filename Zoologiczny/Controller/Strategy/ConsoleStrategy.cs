/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 22:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny{
	
	public class ConsoleStrategy : BaseStrategy	{
		
		public override void InitModelAndView(Model model, View view){
			this.model = model;
			this.view = view;
		}
		
		public override void Start(){
			while(true){
				view.DisplayMainOptions();
				try{
					switch(view.EnterOption()){
						case(-1):
							break;
						case 0: // exit
							view.DisplayMasage("Exit");
							view.WaitAndClear();
							return;
						case 1: // add animal to werehouse
							view.DisplayAvailableAnimals();
							switch(view.EnterAnimal()){
								case("Dog"): // add dog
									view.DisplayMasage("Enter number and price");
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
									view.DisplayMasage("Enter number and price");
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
									view.DisplayMasage("Enter number and price");
									try{
										// factory method
										model.AddAnimalToWarehouse("Cow", Farm.FarmFactory(Animal.Animals.Cow, view.EnterAnimalNumber(), view.EnterPrice()));
									}catch(InvalidCastException){
										view.DisplayError("It is not the number!");
									}
									break;
								case("Chicken"): // add Chicken
									view.DisplayMasage("Enter number and price");
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
							view.WaitAndClear();
							break;
						case 2: // Display warehouse
							view.DisplayWarehouseStatus(model.Warehouse.GetValues());
							view.WaitAndClear();
							break;
						case 3: // remove number of animals form warehouse
							view.DisplayWarehouseStatus(model.Warehouse.GetValues());
							try{
								view.DisplayMasage("Enter animals to remove");
								model.RemoveAnimal(model.Warehouse, view.EnterAnimal(), view.EnterAnimalNumber());
							}catch(InvalidCastException){
								view.DisplayError("It is not the number!");
							}
							model.Notify();
							view.WaitAndClear();
							break;
						case 4: // add to basket
							view.DisplayWarehouseStatus(model.Warehouse.GetValues());
							try{
								view.DisplayMasage("What animal you want to buy and how many?");
								model.AddAnimalToClient(view.EnterAnimal(), view.EnterAnimalNumber());
							}catch(InvalidCastException){
								view.DisplayError("It is not the number!");
							}
							model.Notify();
							view.WaitAndClear();
							break;
						case 5: // Display client's basket
							view.DisplayClientStatus(model.Client.GetValues(), model.Client.Sum);
							view.WaitAndClear();
							break;
						case 6: // remove number of animals form client's basket
							view.DisplayClientStatus(model.Client.GetValues());
							try{
								view.DisplayMasage("Chose animal and enter number of animals to remove");
								model.RemoveAnimal(model.Client, view.EnterAnimal(), view.EnterAnimalNumber());
							}catch(InvalidCastException){
								view.DisplayError("It is not the number!");
							}
							model.Notify();
							view.WaitAndClear();
							break;
						case 7: // change price
							view.DisplayWarehouseStatus(model.Warehouse.GetValues());
							try{
								view.DisplayMasage("Which animal you want to change price?");
								model.ChangeAnimalPrice(view.EnterAnimal(), view.EnterAnimalNumber());
							}catch(InvalidCastException){
								view.DisplayError("It is not the number!");
							}
							model.Notify();
							view.WaitAndClear();
							break;
						case 8: // change number of animal
							view.DisplayWarehouseStatus(model.Warehouse.GetValues());
							try{
								view.DisplayMasage("Which animal you want to change number?");
								model.ChangeAnimalNumber(view.EnterAnimal(), view.EnterAnimalNumber());
							}catch(InvalidCastException){
								view.DisplayError("It is not the number!");
							}
							model.Notify();
							view.WaitAndClear();
							break;
						case 9: // buy animals, clear all basket
							view.DisplayMasage("Buy all animals");
							model.BuyAllAnimals();
							model.Notify();
							view.WaitAndClear();
							break;
						default:
							view.DisplayError("Wrong choise");
							view.WaitAndClear();
							break;
					}
				}catch(InvalidCastException){
					view.DisplayError("It is not the number!");
					view.WaitAndClear();
				}
				catch(FormatException){
					view.DisplayError("It is not the number!");
					view.WaitAndClear();
				}
			}
			
		}
	}
}
