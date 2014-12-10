/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny{
	
	public class Controller{
		Strategy strategy;
		Model model;
		View view;
		
		public Strategy Strategy{
			get { return strategy; }
		}
		
		public Model Model{
			get { return model; }
		}
		
		public View View{
			get { return view; }
		}
		
		public Controller(Model model, View view, Strategy strategy){
			this.model = model;
			this.view = view;
			this.strategy = strategy;
		}
		
		public void Start(){
			strategy.InitModelAndView(model, view);
			strategy.Start();
		}
	}
}
