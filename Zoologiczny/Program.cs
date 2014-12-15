using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	
namespace Zoologiczny{
	
	class Program{
		static void Main(string[] args){
			// declaration view, model, controller and strategy for controller 
			View view;
			Model model;
			Strategy strategy;
			Controller controller;
			// create view
			view = new ConsoleView();
			view = new WinAppView();
			// create model
			model = new Model();
			//strategy
			strategy = new ConsoleStrategy();
			strategy = new WinAppStrategy();
			// create controller with model, view and strategy
			controller = new Controller(model, view, strategy);
			// attach view to model : observer pattern
			controller.Model.Attach(view);
			// start applivation
			controller.Start();
			
		}
	}
}
