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

namespace Zoologiczny
{
	public class ProductContainer{ 
 		protected List<Animal> list;
        
 		internal List<Animal> List{
            get { return list; }
            set { list = value; }
        }
 		
 		public void AddAnimal(Animal animal){
			list.Add(animal);
		}
		
		public void RemoveAnimal(int index){
			list.RemoveAt(index);
		}
    }
}
