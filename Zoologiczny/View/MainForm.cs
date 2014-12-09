/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-09
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zoologiczny
{
	public class MainForm : Form{
		
		Label label1 = new Label();
		
		public MainForm(){
			InitializeComponent();
		}
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing){
			if (disposing){
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent(){
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		
		    label1.Text = "First Name";
		    label1.Location = new Point(48,48);
		    label1.Size = new Size(104, 16);
		
		    Controls.Add(label1);
			
			this.Text = "Win app";
			this.Name = "MainForm";
		}
		
		public void setLabel(string s){
			label1.Text = s;
		}
	}
}
