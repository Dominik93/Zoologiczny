/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.M;

namespace PetShop.Observer{
	public interface IObserver{
		void Update(Model model);
	}
}
