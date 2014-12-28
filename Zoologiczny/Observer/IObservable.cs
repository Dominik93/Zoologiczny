﻿/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using PetShop.V;

namespace PetShop.Observer{
	public interface IObservable{
		void Attach(View view);
		void Detach(View view);
		void Notify();
	}
}
