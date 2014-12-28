/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-10
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.M;
using PetShop.C.Strategy.StrategyInterface;
using PetShop.V;

namespace PetShop.C.Strategy{
	public abstract class BaseStrategy : IStrategy{
		protected Model model;
		protected View view;
		
		public abstract void InitModelAndView(Model model, View view);
		public abstract void Start();
		
	}
}
