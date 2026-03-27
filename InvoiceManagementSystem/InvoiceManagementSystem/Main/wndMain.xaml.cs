using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InvoiceManagementSystem.Main
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        public wndMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Search ion the menu clicked, opens the search window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Open the search window
        }
        /// <summary>
        /// Update on the menu clicked, updates the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSearch_Click(object sender, RoutedEventArgs e)
        {
            // update a def table that contains the items
        }
        /// <summary>
        /// Update Items in combo box
        /// </summary>
        public void UpdateComboBox()
        {
            // This method will be called after the Items Window closes.
            // If any items were added, updated, or deleted, this method will refresh the item combo box
            // and any displayed item names on the Main Window.
        }
    }
}
