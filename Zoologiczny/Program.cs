using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny{
	class Program{
		static void Main(string[] args){
			View view = new View();
			Model model = new Model();
			Controller controller = new Controller(model, view);
			while(true){
				controller.View.DisplayMainOptions();
				try{
					switch(controller.View.EnterIntNumber()){
						case(-1):
							break;
						case 0: // exit
							controller.View.DisplayMasage("Exit");
							controller.View.WaitAndClear();
							return;
						case 1: // add animal to werehouse
							controller.View.DisplayAvailableAnimals();
							switch(controller.View.EnterIntNumber()){
								case(0): // add doge
									controller.View.DisplayMasage("Enter number and price");
									try{
										// dog builder
										DogBreeder dogBreeder = new DogBreeder();
										dogBreeder.DogBuilder = new LabradorDogBuilder();
										dogBreeder.DogBuilder.CreateNewDog();
										dogBreeder.ConstructDog(controller.View.EnterIntNumber(), controller.View.EnterDoubleNumber());
										
										controller.Model.AddAnimalToWarehouse(dogBreeder.Dog.Race, dogBreeder.Dog);
										dogBreeder = null;
									}catch(InvalidCastException){
									}
									break;
								case(1): // add cat
									controller.View.DisplayMasage("Enter number and price");
									try{
										// cat builder
										CatBreeder catBreeder = new CatBreeder();
										catBreeder.CatBuilder = new PersianCatBuilder();
										catBreeder.CatBuilder.CreateNewCat();
										catBreeder.ConstructCat(controller.View.EnterIntNumber(), controller.View.EnterDoubleNumber());
										
										controller.Model.AddAnimalToWarehouse(catBreeder.Cat.Race,catBreeder.Cat);
										catBreeder = null;
									}catch(InvalidCastException){
										controller.View.DisplayError("It is not the number!");
									}
									break;
								case(2): // add cow
									controller.View.DisplayMasage("Enter number and price");
									try{
										// factory method
										controller.Model.AddAnimalToWarehouse("Cow", Farm.FarmFactory(Animal.Animals.Cow, controller.View.EnterIntNumber(), controller.View.EnterDoubleNumber()));
									}catch(InvalidCastException){
										controller.View.DisplayError("It is not the number!");
									}
									break;
								case(3): // add Chicken
									controller.View.DisplayMasage("Enter number and price");
									try{
										// factory method
										controller.Model.AddAnimalToWarehouse("Chicken", Farm.FarmFactory(Animal.Animals.Chicken, controller.View.EnterIntNumber(), controller.View.EnterDoubleNumber()));
									}catch(InvalidCastException){
										controller.View.DisplayError("It is not the number!");
									}
									break;
								default:
									controller.View.DisplayError("Wrong choise");
									break;
							}
							controller.View.WaitAndClear();
							break;
						case 2: // Display warehouse
							controller.View.DisplayWarehouseStatus(controller.Model.Warehouse.GetValues());
							controller.View.WaitAndClear();
							break;
						case 3: // remove number of animals form warehouse
							controller.View.DisplayWarehouseStatus(controller.Model.Warehouse.GetValues());
							try{
								controller.View.DisplayMasage("Enter animals to remove");
								controller.Model.RemoveAnimal(controller.Model.Warehouse, controller.View.EnterString(), controller.View.EnterIntNumber());
							}catch(InvalidCastException){
								controller.View.DisplayError("It is not the number!");
							}
							controller.View.WaitAndClear();
							break;
						case 4: // add to basket
							controller.View.DisplayWarehouseStatus(controller.Model.Warehouse.GetValues());
							try{
								controller.View.DisplayMasage("What animal you want to buy and how many?");
								controller.Model.AddAnimalToClient(controller.View.EnterString(), controller.View.EnterIntNumber());
							}catch(InvalidCastException){
								controller.View.DisplayError("It is not the number!");
							}
							controller.View.WaitAndClear();
							break;
						case 5: // Display client's basket
							controller.View.DisplayClientStatus(controller.Model.Client.GetValues(), controller.Model.Client.Sum);
							controller.View.WaitAndClear();
							break;
						case 6: // remove number of animals form client's basket
							controller.View.DisplayClientStatus(controller.Model.Client.GetValues());
							try{
								controller.View.DisplayMasage("Chose animal and enter number of animals to remove");
								controller.Model.RemoveAnimal(controller.Model.Client, controller.View.EnterString(), controller.View.EnterIntNumber());
							}catch(InvalidCastException){
								controller.View.DisplayError("It is not the number!");
							}
							controller.View.WaitAndClear();
							break;
						case 7: // change price
							controller.View.DisplayWarehouseStatus(controller.Model.Warehouse.GetValues());
							try{
								controller.View.DisplayMasage("Which animal you want to change price?");
								controller.Model.ChangeAnimalPrice(controller.View.EnterString(), controller.View.EnterIntNumber());
							}catch(InvalidCastException){
								controller.View.DisplayError("It is not the number!");
							}
							controller.View.WaitAndClear();
							break;
						case 8: // change number of animal
							controller.View.DisplayWarehouseStatus(controller.Model.Warehouse.GetValues());
							try{
								controller.View.DisplayMasage("Which animal you want to change number?");
								controller.Model.ChangeAnimalNumber(controller.View.EnterString(), controller.View.EnterIntNumber());
							}catch(InvalidCastException){
								controller.View.DisplayError("It is not the number!");
							}
							controller.View.WaitAndClear();
							break;
						case 9: // buy animals, clear all basket
							controller.View.DisplayMasage("Buy all animals");
							controller.Model.BuyAllAnimals();
							controller.View.WaitAndClear();
							break;
						default:
							controller.View.DisplayError("Wrong choise");
							controller.View.WaitAndClear();
							break;
					}
				}catch(InvalidCastException){
					controller.View.DisplayError("It is not the number!");
					controller.View.WaitAndClear();
				}
				catch(FormatException){
					controller.View.DisplayError("It is not the number!");
					controller.View.WaitAndClear();
				}
			}
		}
	}
}
