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
using PetShop.V.WindowsApp;
using PetShop.M.Classes.Product;

namespace PetShop.V.WindowsApp{
	public partial class WPFForm : Window{
		public WPFForm(){
			InitializeComponent();
		}
		
		public void RegisterButton1EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.AddAnimalToWarehouseButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton2EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.RemoveAnimalFromWarehouseButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton3EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.ChangeNumberButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton4EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.ChangePriceButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton5EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.AddToBasketButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton6EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.RemoveFromBasketButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterButton7EventHandler(System.Windows.RoutedEventHandler eventHandler){
			this.BuyButton.Click += new System.Windows.RoutedEventHandler(eventHandler);
		}
		
		public void RegisterComboBox1EventHendler(System.Windows.Controls.SelectionChangedEventHandler eventHandler){
			this.AnimalComboBox.SelectionChanged += new SelectionChangedEventHandler(eventHandler);
		}
		
		public void RegisterComboBox2EventHendler(System.Windows.Controls.SelectionChangedEventHandler eventHandler){
			this.SpeciesComboBox.SelectionChanged += new SelectionChangedEventHandler(eventHandler);
		}
		
		public void RegisterComboBox3EventHendler(System.Windows.Controls.SelectionChangedEventHandler eventHandler){
			this.RacesPetComboBox.SelectionChanged += new SelectionChangedEventHandler(eventHandler);
		}
		
		public void RegisterComboBox4EventHendler(System.Windows.Controls.SelectionChangedEventHandler eventHandler){
			this.RacesFarmComboBox.SelectionChanged += new SelectionChangedEventHandler(eventHandler);
		}
		
		public void RegisterComboBox5EventHendler(System.Windows.Controls.SelectionChangedEventHandler eventHandler){
			this.StateComboBox.SelectionChanged += new SelectionChangedEventHandler(eventHandler);
		}
		
		public void SetTextWarehouse(string text){
			this.WarehouseLabel.Content = text;
		}
				
		public void SetTextClient(string text){
			this.BasketLabel.Content = text;
		}
		
		public void SetTextLogs(string text){
			this.LogsLabel.Content = text;
		}
		
		public string GetAnimal(){
			return this.AnimalTextBox.Text;
		}
		
		public string GetNumberWerehouse(){
			return this.NumberTextBox.Text;
		}
		
		public string GetNumberClient(){
			return this.NumberClientTextBox.Text;
		}
				
		public string GetPrice(){
			return this.PriceTextBox.Text;
		}
		
		public System.Windows.Controls.DataGrid GetCGrid(){
			return this.CGrid;
		}
		
		public System.Windows.Controls.DataGrid GetWGrid(){
			return this.WGrid;
		}
		
		public int GetSelectedComboBox(){
			if(this.AnimalComboBox.IsVisible){
				if(this.SpeciesComboBox.IsVisible){
					if(this.RacesPetComboBox.IsVisible){
						if(this.RacesPetComboBox.SelectedIndex == 1){
							return 4;
						}
						else if(this.RacesPetComboBox.SelectedIndex == 2){
							return 5;
						}
						else{
							return 2;
						}
					}
					else if(this.RacesFarmComboBox.IsVisible){
						if(this.RacesFarmComboBox.SelectedIndex == 1){
							return 6;
						}
						else if(this.RacesFarmComboBox.SelectedIndex == 2){
							return 7;
						}
						else{
							return 3;
						}
					}
					else{
						if(this.SpeciesComboBox.SelectedIndex == 1){
							return 2;
						}
						else if(this.SpeciesComboBox.SelectedIndex == 2){
							return 3;
						}
						else{
							return 1;
						}
					}
				}
				else{
					if(this.AnimalComboBox.SelectedIndex == 1){
						return 1;
					}
				}
			}
			else{
				return 0;
			}
			return 0;
		}
		
	}
}