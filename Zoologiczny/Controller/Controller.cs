/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	public class Controller
	{
		Model model;
		View view;
		
		public Controller(Model model, View view){
			this.model = model;
			this.view = view;
		}
		
		public void start(){
			while(true){
				view.diplayMainOptions();
				try{
					switch(view.enterIntNumber()){
	        			case 0:
							view.displayMasage("Exit");
							view.waitAndClear();
	        				return;
	        			case 1:
	        				view.displayAvailableAnimals();
	        					switch(view.enterIntNumber()){
	        						case(0):
	        							view.displayMasage("Enter number and price");
	        							try{
		        							DogBreeder dogBreeder = new DogBreeder();
		        							dogBreeder.DogBuilder = new BulldogDogBuilder();
		        							dogBreeder.DogBuilder.createNewDog();
		        							dogBreeder.constructDog(view.enterIntNumber(), view.enterDoubleNumber());
		        							model.addAnimalToWarehouse(dogBreeder.Dog);
		        							dogBreeder = null;
	        							}catch(InvalidCastException){
	        								view.displayError("It is not the number!");
	        							}
		        						break;
	        						case(1):
	        							view.displayMasage("Enter number and price");
	        							try{
		        							CatBreeder catBreeder = new CatBreeder();
		        							catBreeder.CatBuilder = new PersianCatBuilder();
		        							catBreeder.CatBuilder.createNewCat();
		        							catBreeder.constructCat(view.enterIntNumber(), view.enterDoubleNumber());
		        							model.addAnimalToWarehouse(catBreeder.Cat);
		        							catBreeder = null;
		        						}catch(InvalidCastException){
	        								view.displayError("It is not the number!");
	        							}
	        							break;
	        						case(2):
	        							view.displayMasage("Enter number and price");
	        							try{
		        							model.addAnimalToWarehouse(Farm.FarmFactory(Animal.Animals.Cow, view.enterIntNumber(), view.enterDoubleNumber()));
	        							}catch(InvalidCastException){
	        								view.displayError("It is not the number!");
	        							}
		        						break;
	        						case(3):
		        						view.displayMasage("Enter number and price");
	        							try{
		        							model.addAnimalToWarehouse(Farm.FarmFactory(Animal.Animals.Chicken, view.enterIntNumber(), view.enterDoubleNumber()));
	        							}catch(InvalidCastException){
	        								view.displayError("It is not the number!");
	        							}
		        						break;
	        						default:
	        							view.displayError("Wrong choise");
	        							break;
	        					}
	        				view.waitAndClear();
	        				break;
	        			case 2:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				view.waitAndClear();
	        				break;
	        			case 3:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
	        					view.displayMasage("Enter number of animals to remove");
	        					model.removeAnimalFromWarehouse(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				view.waitAndClear();
	        				break;
	        			case 4:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
		        				view.displayMasage("What animal you want to buy and how many?");
		        				model.addAnimalToClient(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				view.waitAndClear();
	        				break;
	        			case 5:
	        				view.displayClientStatus(model.Client, model.Client.Sum);
	        				view.waitAndClear();
	        				break;	
	        			case 6:
	        				view.displayClientStatus(model.Client);
	        				try{
	        					view.displayMasage("Chose animal and enter number of animals to remove");
	        					model.removeAnimalFromClient(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				view.waitAndClear();
	        				break;
	        			case 7:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
		        				view.displayMasage("Which animal you want to change price?");
		        				model.changeAnimalPrice(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				view.waitAndClear();
	        				break;
						case 8:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
		        				view.displayMasage("Which animal you want to change number?");
		        				model.changeAnimalNumber(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				view.waitAndClear();
	        				break;	 
	        			case 9:
	        				view.displayMasage("Buy all animals");
	        				model.buyAllAnimals();
	        				view.waitAndClear();
	        				break;
	        			default:
	        				view.displayError("Wrong choise");
	        				view.waitAndClear();
	        				break;
	        		}
				}catch(InvalidCastException){
					view.displayError("It is not the number!");
					view.waitAndClear();
				}
				catch(FormatException){
					view.displayError("It is not the number!");
					view.waitAndClear();
				}
			}
		}
	}
}
