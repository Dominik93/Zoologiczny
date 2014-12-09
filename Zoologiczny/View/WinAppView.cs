/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 18:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Zoologiczny{
	
	public class WinAppView : View{
		MainForm mainForm;
		
		public MainForm MainForm{
			get { return mainForm; }
		}
		
		public WinAppView(){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			mainForm = new MainForm();
		}
		
		public override void InitComponent(){
			Application.Run(mainForm);
		}
		
		public override void Update(Model model){
			mainForm.SetText(this.DisplayWarehouseStatus());
		}
		
		public override void WaitAndClear(){
		}
		
		public override int EnterIntNumber(){
			return 0;
		}
		
		public override string EnterString(){
			return "";
		}
		
		public override double EnterDoubleNumber(){
			return 0.0;
		}
		
		public override void DisplayAvailableAnimals(){
		}
		
		public override void DisplayMainOptions(){
		}
		
		public override void DisplayError(string error){
			MessageBox.Show(error,
			                "Error",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Exclamation,
			                MessageBoxDefaultButton.Button1);
		}
		
		public override void DisplayMasage(string msg){
			MessageBox.Show(msg,
			                "Message",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Exclamation,
			                MessageBoxDefaultButton.Button1);
		}
		
		public override void DisplayWarehouseStatus(Dictionary<string, Animal>.ValueCollection list){
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list, double sum){
		}
		
		public override void DisplayClientStatus(Dictionary<string, Animal>.ValueCollection list){
		}
	}
}
