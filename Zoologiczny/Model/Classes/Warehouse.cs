/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-03
 * Time: 11:03
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
	/// Description of Warehouse.
	/// </summary>
	class Warehouse: ProductContainer {

        public Warehouse() {
        	list = new List<Animal>();
        }
    }
}
