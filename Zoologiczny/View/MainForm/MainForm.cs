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
		
		public MainForm(){
			InitializeComponent();
		}
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing){
			if (disposing){
				if (components != null){
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent(){
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(167, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 110);
			this.label1.TabIndex = 0;
			this.label1.Text = "Warehouse";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add animal to warehouse";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 90);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(145, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Remove animal from warehouse";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(16, 148);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(145, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Change price";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(17, 119);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(145, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Change number of animal";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(16, 196);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(146, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Add to basket";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(16, 225);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(146, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Remove from basket";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(16, 254);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(146, 23);
			this.button7.TabIndex = 8;
			this.button7.Text = "Buy";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(306, 81);
			this.label2.TabIndex = 9;
			this.label2.Text = "Client basket";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Animal";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(122, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Number";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(228, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Price";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 13;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(122, 35);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 14;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(228, 35);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(167, 299);
			this.label6.Name = "Logs";
			this.label6.Size = new System.Drawing.Size(265, 65);
			this.label6.TabIndex = 16;
			this.label6.Text = "label6";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 404);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Win app";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
		public void RegisterButton1EventHandler(System.EventHandler eventHandler){
			this.button1.Click += new System.EventHandler(eventHandler);
		}
		
		public void RegisterButton2EventHandler(System.EventHandler eventHandler){
			this.button2.Click += new System.EventHandler(eventHandler);
		}
		
		public void RegisterButton3EventHandler(System.EventHandler eventHandler){
			this.button3.Click += new System.EventHandler(eventHandler);
		}
		
		public void RegisterButton4EventHandler(System.EventHandler eventHandler){
			this.button4.Click += new System.EventHandler(eventHandler);
		}
		
		public void RegisterButton5EventHandler(System.EventHandler eventHandler){
			this.button5.Click += new System.EventHandler(eventHandler);
		}
		
		public void RegisterButton6EventHandler(System.EventHandler eventHandler){
			this.button6.Click += new System.EventHandler(eventHandler);
		}
		
		public void RegisterButton7EventHandler(System.EventHandler eventHandler){
			this.button7.Click += new System.EventHandler(eventHandler);
		}
		
		public void SetTextWarehouse(string text){
			this.label1.Text = text;
		}
		
		public void SetTextClient(string text){
			this.label2.Text = text;
		}
		
		public void SetTextLogs(string text){
			this.label6.Text = text;
		}
		
		public string GetAnimal(){
			return this.textBox1.Text;
		}
		
		public string GetNumber(){
			return this.textBox2.Text;
		}
		
		public string GetPrice(){
			return this.textBox3.Text;
		}
		
		
	}
}