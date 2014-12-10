/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-10
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny{
	public abstract class BaseStrategy : Strategy{
		protected Model model;
		protected View view;
		
		public abstract void InitModelAndView(Model model, View view);
		public abstract void Start();
		
	}
}
