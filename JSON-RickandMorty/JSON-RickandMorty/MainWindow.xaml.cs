using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_RickandMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string dataseturl = "https://rickandmortyapi.com/api/character/";
            using (var client = new HttpClient())
            {
                client.Baseaddress = new Uri(dataseturl);
                string json = client.GetStringAsync().Result;

                RickMortyAPI results = JsonConvert.DeserializeObject<RickMortyAPI>(json);
                //RickMortyAPI rickandmortystuff.results
            }

            foreach (var character in rickandmortystuff.results)
            {
                Lstbox1Characters.Items.Add(character);
            }

 //              string json = @"{
                //'Name': 'Bad Boys',
               //'ReleaseDate': '1995-4-7T00:00:00',
               //'Genres': [
             //  'Action',
             //  'Comedy'
               //]
        //       }";

     //          Movie m = JsonConvert.DeserializeObject<Movie>(json);

  //          string name = m.Name;
  //           Bad Boys





        }

        public object Lstbox1Characters { get; set; }

        private void Lstbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCharacterFromList = (ResultObject)Lstbox1characters.SelectedItem;

        }
    }
}
