/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny{
	public class Client : ProductContainer{
        double sum;

        public Client(){
        	sum = 0;
        }
        
        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        
        public void CalculateSum(){
        	this.sum = 0;
        	foreach(Animal animal in instance.Values){
        		this.sum = this.sum + ( animal.Number * animal.Price);
        	}
        }
    }
}
