/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Windows.Forms;

namespace Zoologiczny{
	
	public class WinAppStrategy : Strategy{
		
		public void Start(Model model, View view){
			view.InitComponent();
		}
		
		/*
		 * dodac zdarzenia które mają się wykonać po naciśnięciu przycisku w view(oknie)
		 * np
		 * buton1 was kliked pokaż input i dodaj animala do listy i updateuj view
		 * itd.
		*/
	}
}
