/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 12/16/2014
 * Time: 00:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny{
	public class WPFAppStrategy : BaseStrategy{
		public override void InitModelAndView(Model model, View view){
			this.model = model;
			this.view = view;
		}
		
		public override void Start(){
			view.StartApplication();
		}
	}
}
