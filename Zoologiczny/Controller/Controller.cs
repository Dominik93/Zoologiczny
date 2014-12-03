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
		
		
		public void showInterface(){
			while(true){
        		Console.WriteLine("0- Exit\n1- Add animal to warehouse\n2- Show warehouse status\n3- Remove from warehouse\n4- Add to basket\n5- Display basket");
        		switch(Convert.ToInt32(Console.ReadLine())){
        			case 0:
        				return;
        			case 1:
        				break;
        			case 2:
        				break;
        			case 3:
        				break;
        			case 4:
        				break;
        			case 5:
        				break;	
        			default:
        				Console.WriteLine("Wrong choise");
        				Console.ReadKey();
        				Console.Clear();
        				break;
        		}
        	}
		}
	}
}
