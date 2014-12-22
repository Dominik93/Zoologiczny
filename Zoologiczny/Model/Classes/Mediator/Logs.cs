/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-15
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.M.Classes.Mediator{
	public class Logs {
		List<Registry> list;

        internal List<Registry> List{
            get { return list; }
            set { list = value; }
        }

        public Logs(List<Registry> list){
            this.list = list;
        }

        public Logs(){
            this.list = new List<Registry>();
        }

        public void addRegistry(Registry registry){
            list.Add(registry);
        }
	}
}
