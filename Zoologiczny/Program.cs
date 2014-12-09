using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	
namespace Zoologiczny{
	
	class Program{
		static void Main(string[] args){
			View view;
			Model model;
			Strategy strategy;
			Controller controller;
			
			view = new ConsoleView();
			view = new WinAppView();
			
			model = new Model();
			
			strategy = new ConsoleStrategy();
			strategy = new WinAppStrategy();
			controller = new Controller(model, view, strategy);
			controller.Model.Attach(view);
			controller.Start();
			
		}
	}
}
