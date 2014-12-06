using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologiczny
{
    class Program
    {
        static void Main(string[] args)
        {
        	Model model = new Model();
        	//View view = new View(model);
        	View view = new View();
         	Controller controller = new Controller(model, view);
        	controller.Start();
        }
    }
}
