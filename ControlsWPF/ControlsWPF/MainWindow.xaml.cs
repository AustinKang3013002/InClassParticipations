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

namespace ControlsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtBirthDate.Text = string.Empty;
            

        }

        private void BTNSubmit_Click(object sender, RoutedEventArgs e)
        {
            lstLetters.Items.Clear();
            string firstname, lastname, birthdate;
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            birthdate = txtBirthDate.Text;
            string fullname = firstname + " " + lastname;
            DateTime bday = DateTime.Now;
            bday = Convert.ToDateTime(birthdate);
            foreach (var letter in fullname)
            {
                lstLetters.Items.Add(letter);
            }

            string message = $"{fullname} born on {bday.DayOfWeek} \n Thank you for submitting";

            MessageBox.Show(message);


        }

        private void BTNX_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
