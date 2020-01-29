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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Class_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtZipCode.Text = " ";
        }
        
            


        

        private void BtnSubmit_Click_1(object sender, RoutedEventArgs e)
        {
            LstBox1.Items.Clear();
            string Name, Address, ZipCode;
            Name = txtName.Text;
            Address = txtAddress.Text;
            ZipCode = txtZipCode.Text;

            EntryForm entryForm = new EntryForm(Name, Address, Convert.ToInt32(ZipCode));
            LstBox1.Items.Add(entryForm);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
