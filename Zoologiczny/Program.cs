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
	 * 1. Singleton - in Warehouse class, creating only one global warehouse
	 * 2. Multiton - in ProducktContainter class, cant add existed product
	 * 3. MVC - all project
	 * 4. Strategy - in controller, controller can change strategy, 3 avaible strategy: Console, WPF, Form
	 * 5. Observer - in model and view, model notify view when it change state, data
	 * 6. Prototype - in Animal class, clone product couse c# work with references
	 * 7. Builder - in Pet class, creating a Dog, Cat object
	 * 8. Factory method - in Farm class, creating a Cow, Chicken object
	 * 9. Mediator - in Client, sent a massage from client to logs about what he bought 
	 * 10. Decorator - in Animal and childs classes, decorating each animal
	 * 11. Facade - teoretical: controller is facade; model, view is subsytems, client have access to method in strategy
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
			//view = new WinAppView(); // dont support all functionality
			//view = new WPFAppView();
			
			// create model
			model = new Model();
			
			// create strategy
			strategy = new ConsoleStrategy(); 
			//strategy = new WinAppStrategy(); // dont supported all functionality
			//strategy = new WPFAppStrategy();
			
			// create controller with model, view and strategy
			controller = new Controller(model, view, strategy);
			
			// attach view to model : observer pattern
			controller.Model.Attach(view);
			
			// start application
			controller.Start();
		}
	}
}
com.slusarz.dictionary.domain.sql.Sql@6c6cb480com.slusarz.dictionary.domain.sql.Sql@34e9fd99commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
commit;
