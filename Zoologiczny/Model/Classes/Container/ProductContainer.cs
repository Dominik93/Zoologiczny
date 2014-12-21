/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny{
	public class ProductContainer{
		
		protected Dictionary<string, Animal> instance = new Dictionary<string, Animal>();
		
		public Dictionary<string, Animal> Instance{
			get { return instance; }
			set { instance = value; }
		}
		
		public void Add(string race, Animal animal){
			try{
				instance.Add(race, animal);
			}catch(ArgumentException){
				
			}
		}
		
		public Dictionary<string, Animal>.ValueCollection GetValues(){
			return instance.Values;
		}
		
		public Dictionary<string, Animal>.KeyCollection GetKeys(){
			return instance.Keys;
		}
		
	}
	
}
