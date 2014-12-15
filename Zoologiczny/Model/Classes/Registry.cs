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


namespace Zoologiczny{
	public class Registry{
		List<Animal> list;
        DateTime date;

        public List<Animal> List{
            get { return list; }
            set { list = value; }
        }


        public DateTime Date{
            get { return date; }
            set { date = value; }
        }

        public Registry(List<Animal> list){
            this.list = list;
            this.date = DateTime.Now;
        }
	}
}
