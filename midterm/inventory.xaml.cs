using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace midterm
{
    public partial class inventory : Window
    {

        public class CombinedData
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int NoofStock { get; set; }
            public SqlMoney Cost { get; set; }
            public SqlMoney SellingPrice { get; set; }
            public string Description { get; set; }
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        public inventory(string currentUserType)
        {
            InitializeComponent();
            LoadData(); // Load data when the inventory window is initialized

            // Check if the current user type is "user" and hide the search button
            if (currentUserType == "user")
            {
                btn_Trans.Visibility = Visibility.Collapsed;
            }
        }

        public void ShowTransactionWindow()
        {
            this.Hide();
            // Create an instance of the transaction window
            var transactionWindow = new Transaction();

            // Show the transaction window
            transactionWindow.Show();
        }

        private void btn_Trans_Click(object sender, RoutedEventArgs e)
        {
            ShowTransactionWindow();
        }

        public void HideSearchButton()
        {
            btn_Trans.Visibility = Visibility.Collapsed;
        }

        private void ClearInputFields()
        {
            tbx_prodID.Text = string.Empty;
            tbx_prodName.Text = string.Empty;
            tbx_prodDescription.Text = string.Empty;
            tbx_prodQuantity.Text = string.Empty;
            tbx_prodCost.Text = string.Empty;
            tbx_prodPrice.Text = string.Empty;
            tbx_Search.Text = string.Empty;
        }

        // Helper method to show error messages
         void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void DisableUIElements()
        {
            tbx_prodName.IsEnabled = false;
            tbx_prodDescription.IsEnabled = false;
            tbx_prodCost.IsEnabled = false;
            tbx_prodPrice.IsEnabled = false;
            btn_Outgoing.IsEnabled = false;

            // Enable the quantity textbox
            tbx_prodQuantity.IsEnabled = true;

            // Show the Confirm Sale button
            btn_ConfirmSale.Visibility = Visibility.Visible;
            btn_Outgoing.Visibility = Visibility.Collapsed;
        }

        private void EnableUIElements()
        {
            tbx_prodName.IsEnabled = true;
            tbx_prodDescription.IsEnabled = true;
            tbx_prodCost.IsEnabled = true;
            tbx_prodPrice.IsEnabled = true;
            btn_Outgoing.IsEnabled = true;
            tbx_prodQuantity.IsEnabled = true; // Make sure to enable the quantity textbox
        }


        // Helper method to check if a product with the given name already exists
        bool ProductExists(string productName)
        {
            // Retrieve product names from the database and perform case-insensitive comparison in-memory
            var existingProductNames = db.Table_Products
                .Select(p => p.Name)
                .ToList();

            return existingProductNames.Any(existingName => existingName.Trim().Equals(productName.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear input fields
            ClearInputFields();
            EnableUIElements();
            btn_ConfirmSale.Visibility = Visibility.Collapsed;
            btn_Outgoing.Visibility = Visibility.Visible;

            // Reload data in the ListView
            LoadData();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(tbx_prodName.Text) || string.IsNullOrWhiteSpace(tbx_prodDescription.Text) ||
                    string.IsNullOrWhiteSpace(tbx_prodQuantity.Text) || string.IsNullOrWhiteSpace(tbx_prodCost.Text) ||
                    string.IsNullOrWhiteSpace(tbx_prodPrice.Text))
                {
                    ShowErrorMessage("Please fill in all fields.");
                    return;
                }

                // Convert input to appropriate types
                string productName = tbx_prodName.Text;
                string description = tbx_prodDescription.Text;
                int quantity = int.Parse(tbx_prodQuantity.Text);
                decimal cost = decimal.Parse(tbx_prodCost.Text);
                decimal price = decimal.Parse(tbx_prodPrice.Text);

                // Check if the product already exists
                if (ProductExists(productName))
                {
                    ShowErrorMessage("Product with the same name already exists.");
                    return;
                }

                // Create a new product object
                Table_Product newProduct = new Table_Product
                {
                    Name = productName,
                    Description = description,
                    No_of_Stock = quantity,
                    Cost = cost,
                    Selling_Price = price
                };

                // Add the product to the database
                db.Table_Products.InsertOnSubmit(newProduct);
                db.SubmitChanges();

                // Reload data in the ListView
                LoadData();

                // Clear input fields
                ClearInputFields();

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error adding product: " + ex.Message);
            }
        }

        private void Search_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Search.SelectedItem != null)
            {
                CombinedData selectedProduct = (CombinedData)Search.SelectedItem;

                // Display the selected product details in the input fields
                tbx_prodID.Text = selectedProduct.ProductID.ToString();
                tbx_prodName.Text = selectedProduct.ProductName;
                tbx_prodDescription.Text = selectedProduct.Description;
                tbx_prodQuantity.Text = selectedProduct.NoofStock.ToString();
                tbx_prodCost.Text = selectedProduct.Cost.ToString();
                tbx_prodPrice.Text = selectedProduct.SellingPrice.ToString();
            }
        }

        private void btn_Outgoing_Click(object sender, RoutedEventArgs e)
        {
            if (Search.SelectedItem == null || string.IsNullOrWhiteSpace(tbx_prodName.Text) ||
                string.IsNullOrWhiteSpace(tbx_prodQuantity.Text) || string.IsNullOrWhiteSpace(tbx_prodCost.Text) ||
                string.IsNullOrWhiteSpace(tbx_prodPrice.Text))
            {
                MessageBox.Show("Please select a product first in the table and ensure all required fields are filled."
                    , "ERROR: Select a data first"
                    ,MessageBoxButton.OK
                    ,MessageBoxImage.Warning);
            }
            else
            {
                DisableUIElements();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if a product is selected
            if (Search.SelectedItem == null || string.IsNullOrWhiteSpace(tbx_prodName.Text) ||
                string.IsNullOrWhiteSpace(tbx_prodQuantity.Text) || string.IsNullOrWhiteSpace(tbx_prodCost.Text) ||
                string.IsNullOrWhiteSpace(tbx_prodPrice.Text))
            {
                MessageBox.Show("Please select a product first in the table and ensure all required fields are filled."
                    , "ERROR: Select a data first"
                    , MessageBoxButton.OK
                    , MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    // Retrieve the selected product
                    CombinedData selectedProduct = (CombinedData)Search.SelectedItem;

                    // Update the product properties
                    selectedProduct.ProductName = tbx_prodName.Text;
                    selectedProduct.Description = tbx_prodDescription.Text;
                    selectedProduct.NoofStock = int.Parse(tbx_prodQuantity.Text);
                    selectedProduct.Cost = decimal.Parse(tbx_prodCost.Text);
                    selectedProduct.SellingPrice = decimal.Parse(tbx_prodPrice.Text);

                    // Update the product in the database
                    Table_Product productToUpdate = db.Table_Products.SingleOrDefault(p => p.ProductID == selectedProduct.ProductID);
                    if (productToUpdate != null)
                    {
                        productToUpdate.Name = selectedProduct.ProductName;
                        productToUpdate.Description = selectedProduct.Description;
                        productToUpdate.No_of_Stock = selectedProduct.NoofStock;
                        productToUpdate.Cost = (decimal)selectedProduct.Cost;
                        productToUpdate.Selling_Price = (decimal)selectedProduct.SellingPrice;

                        // Submit changes to the database
                        db.SubmitChanges();

                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                        // Reload data in the ListView
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Product not found in the database.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Error updating product: " + ex.Message);
                }
            }
        }


        private void LoadData(string searchTerm = "")
        {
            // Retrieve data from the database based on the search term
            var productList = (from p in db.Table_Products
                               where string.IsNullOrEmpty(searchTerm) || p.Name.Contains(searchTerm)
                               select new CombinedData
                               {
                                   ProductID = p.ProductID,
                                   ProductName = p.Name,
                                   NoofStock = (int)p.No_of_Stock,
                                   Cost = (SqlMoney)p.Cost,
                                   SellingPrice = (SqlMoney)p.Selling_Price,
                                   Description = p.Description
                               }).ToList();

            // Bind the data to the ListView
            Search.ItemsSource = productList;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = tbx_Search.Text;
            LoadData(searchTerm);

            if (Search.Items.Count == 0)
            {
                MessageBox.Show("No matching products found.", "Search Results", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadData();
                ClearInputFields();
            }
        }
    }
}