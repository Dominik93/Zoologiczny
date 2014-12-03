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

namespace Zoologiczny
{
	/// <summary>
	/// Description of Client.
	/// </summary>
	class Client : ProductContainer{
        double suma;

        public Client(){
        	list = new List<Animal>();
        }
        
        public double Suma
        {
            get { return suma; }
            set { suma = value; }
        }
    }
}
