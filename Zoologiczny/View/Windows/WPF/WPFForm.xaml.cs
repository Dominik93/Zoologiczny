/*
 * Created by SharpDevelop.
 * User: Dominik
 * Date: 2014-12-15
 * Time: 16:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using PetShop.V.WindowsApp;

namespace PetShop.V.WindowsApp{
	public partial class WPFForm : Window{
		public WPFForm(){
			InitializeComponent();
		}
		
		public void RegisterButton1EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.AddAnimalToWarehouse.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton2EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.RemoveAnimalFromWarehouse.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton3EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.ChangeNumber.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton4EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.ChangePrice.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton5EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.AddToBasket.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton6EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.RemoveFromBasket.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton7EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.Buy.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton8EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.StateButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void SetTextWarehouse(string text){
			this.Warehouse.Content = text;
		}
				
		public void SetTextClient(string text){
			this.Basket.Content = text;
		}
		
		public void SetTextLogs(string text){
			this.Logs.Content = text;
		}
		
		public void SetTest(string text){
			this.Test.Content = text;
		}
		
		public string GetAnimal(){
			return this.Animal.Text;
		}
		
		public string GetNumber(){
			return this.Number.Text;
		}
				
		public string GetPrice(){
			return this.Price.Text;
		}
		
		public string GetState(){
			return this.State.Text;
		}
		
	}
}