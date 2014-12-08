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
		
		public Model Model{
			get { return model; }
		}
		
		public View View{
			get { return view; }
		}
		
		public Controller(Model model, View view){
			this.model = model;
			this.view = view;
		}
	}
}
