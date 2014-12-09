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

namespace Zoologiczny{
	public class MainForm : Form{
		
		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		
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
			this.Size = new Size(300, 350);
			this.Text = "Win app";
			this.Name = "MainForm";
			
			label1 = new Label();
		    label1.Text = "Warehouse";
		    label1.Location = new Point(20, 30);
		    label1.Size = new Size(70, 120);
		    
			label2 = new Label();
		    label2.Text = "Basket";
		    label2.Location = new Point(20, 170);
		    label2.Size = new Size(70, 120);
		    
		    button1 = new Button();
		    button1.Text = "Add animal to warehouse";
		    button1.Location = new Point(100, 30);
		    button1.Size = new Size(80,30);
		    
		    button2 = new Button();
		    button2.Text = "Remove animal form werehouse";
		    button2.Location = new Point(100, 60);
		    button2.Size = new Size(80,30);
		    
		    button3 = new Button();
		    button3.Text = "Change price";
		    button3.Location = new Point(100, 90);
		    button3.Size = new Size(80,30);
		    
		    button4 = new Button();
		    button4.Text = "Change number";
		    button4.Location = new Point(100, 120);
		    button4.Size = new Size(80,30);
		    
		    button5 = new Button();
		    button5.Text = "Add animal to basket";
		    button5.Location = new Point(100, 180);
		    button5.Size = new Size(80,30);
		    
		    button6 = new Button();
		    button6.Text = "Remove Animal from basket";
		    button6.Location = new Point(100, 210);
		    button6.Size = new Size(80,30);
		    
		    button7 = new Button();
		    button7.Text = "Buy";
		    button7.Location = new Point(100, 240);
		    button7.Size = new Size(80,30);
		    
		    Controls.Add(label1);
		    Controls.Add(label2);
		    
		    Controls.Add(button1);
			Controls.Add(button2);
			Controls.Add(button3);
			Controls.Add(button4);
			Controls.Add(button5);
			Controls.Add(button6);
			Controls.Add(button7);
		}
		
		public void SetText(string text){
			label1.Text = text;
		}
	}
}
