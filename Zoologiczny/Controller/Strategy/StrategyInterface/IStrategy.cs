/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 22:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.M;
using PetShop.V;

namespace PetShop.C.Strategy.StrategyInterface{
	public interface IStrategy{
		void InitModelAndView(Model model, View view);
		void Start();
	}
}
