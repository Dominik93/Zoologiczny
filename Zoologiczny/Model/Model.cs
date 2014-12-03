/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zoologiczny
{
	public class Model
	{
		
		Client client;
		Warehouse warhouse;
		
		public Model(){
			client = new Client();
			warhouse = new Warehouse();
		}
	}
}
