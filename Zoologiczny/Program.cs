using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.C;
using PetShop.C.Strategy.StrategyInterface;
using PetShop.C.Strategy.Strategies;
using PetShop.M;
using PetShop.V;
using PetShop.V.Views;

namespace PetShop{

	/* Wzorce:
	 * 1. Singleton - in Warehouse class
	 * 2. Multiton - in ProducktContainter class
	 * 3. MVC - all project
	 * 4. Strategy - in controller
	 * 5. Observer - in model and view
	 * 6. Prototype - in Animal class
	 * 7. Builder - in Pet class
	 * 8. Factory method - in Farm class
	 * 9. Mediator - in Client
	 * 10. Decorator - in Animal and childs classes
	 * 11. Facade - teoretical controller is facade, model, view is subsytems
	 * 12. State - in Client, if client is disactive he cant do anything
	 * Use Windows Form and WPF for windows
	 */
	
	class Program{
		[STAThread]
		static void Main(string[] args){
			// declaration view, model, controller and strategy for controller
			View view;
			Model model;
			IStrategy strategy;
			Controller controller;
			
			// create view
			view = new ConsoleView();
			view = new WinAppView();
			view = new WPFAppView();
			
			// create model
			model = new Model();
			
			// create strategy
			strategy = new ConsoleStrategy();
			strategy = new WinAppStrategy();
			strategy = new WPFAppStrategy();
			
			// create controller with model, view and strategy
			controller = new Controller(model, view, strategy);
			
			// attach view to model : observer pattern
			controller.Model.Attach(view);
			
			// start application
			controller.Start();
		}
	}
}
