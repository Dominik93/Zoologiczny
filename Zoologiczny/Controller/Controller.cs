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
					int choice = Convert.ToInt32(Console.ReadLine());
					switch(choice){
	        			case 0:
							view.displayMasage("Exit");
							Console.ReadKey();
	        				Console.Clear();
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
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
	        			case 2:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
	        			case 3:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
	        					view.displayMasage("Enter number of animals to remove");
	        					model.removeAnimalFromWarehouse(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
	        			case 4:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
		        				view.displayMasage("What animal you want to buy and how many?");
		        				model.addAnimalToClient(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
	        			case 5:
	        				view.displayClientStatus(model.Client, model.Client.Sum);
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;	
	        			case 6:
	        				view.displayClientStatus(model.Client);
	        				try{
	        					view.displayMasage("Chose animal and enter number of animals to remove");
	        					model.removeAnimalFromClient(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
	        			case 7:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
		        				view.displayMasage("Which animal you want change price?");
		        				model.changeAnimalPrice(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
						case 8:
	        				view.displayWarehouseStatus(model.Warehouse);
	        				try{
		        				view.displayMasage("Which animal you want change number?");
		        				model.changeAnimalNumber(view.enterIntNumber(), view.enterIntNumber());
	        				}catch(InvalidCastException){
	        					view.displayError("It is not the number!");
	        				}
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;	        				
	        			default:
	        				view.displayError("Wrong choise");
	        				Console.ReadKey();
	        				Console.Clear();
	        				break;
	        		}
				}catch(InvalidCastException){
					view.displayError("It is not the number!");
					Console.ReadKey();
	        		Console.Clear();
				}
				catch(FormatException){
					view.displayError("It is not the number!");
					Console.ReadKey();
	        		Console.Clear();
				}
			}
		}
	}
}
