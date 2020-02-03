using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFFileFormat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string book;
        private string path;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnride_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run text = new Run();

            File.ReadAllText(@"C:\Users\kang0016\Source\Repos\AustinKang3013002\InClassParticipations\WPFFileFormat\WPFFileFormat\Pride and Prejudice by Jane Austen.txt");
            text.Text = book;

            p.Inlines.Add(text);
            fd.Blocks.Add(p);
            RtbPride.Document = fd;
            MessageBox.Show("Read Successfully");
        }

        private void BtnSales_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\kang0016\Source\Repos\AustinKang3013002\InClassParticipations\WPFFileFormat\WPFFileFormat\SalesJan2009 (1).csv";
            var lines = File.ReadAllLines(path);
            MessageBox.Show("Read Successfully");

            
        }
    }
}
