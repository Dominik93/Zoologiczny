/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 12/16/2014
 * Time: 00:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Zoologiczny{
	
	public class WPFAppView : View{
		public override void InitComponent(){
		}
		
		public override void StartApplication(){
			Zoologiczny.App app = new Zoologiczny.App();
			app.Run(new WPFForm());
		}
		
		public override void Update(Model model){
		}
		
		public override string EnterAnimalNumber(){
			return "";
		}
		
		public override string EnterAnimal(){
			return "";
		}
		
		public override string EnterPrice(){
			return "";
		}
		
		public override void DisplayLogs(Logs logs){
		}
		
		public override void DisplayError(string error){
		}
		
		public override void DisplayMasage(string msg){
		}
		
		public override void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list){
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum){
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
		}
		
		public override void DisplayAvailableAnimals(){
		}
		
		public override void DisplayMainOptions(){
		}
		
		public override void WaitAndClear(){
		}
		
		public override string EnterOption(){
			return "";
		}
	}
}
