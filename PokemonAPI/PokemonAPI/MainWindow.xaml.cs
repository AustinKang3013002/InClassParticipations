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

namespace PokemonAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // private string url;
       // private object lstchar;

        public MainWindow()
        {
            InitializeComponent();

            

            string url = "https://pokeapi.co/api/v2/pokemon?offset=20&limit=1000";
            PokemonAPIResults PokemonStuff;
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(dataSetUrl);
                string json = client.GetStringAsync(url).Result;

                PokemonStuff = JsonConvert.DeserializeObject<PokemonAPIResults>(json);
            }

            foreach (var character in PokemonStuff.results)
            {
                lstchar.Items.Add(character);
            }

        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCharacterFromList = (AllPokemonresult)lstchar.SelectedItem;

            PokemonAPI poke;

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(dataSetUrl);
                string json = client.GetStringAsync(selectedCharacterFromList.url).Result;

                poke = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

           
            Img1.Source = new BitmapImage(new Uri(poke.sprites.FrontDefault));
        }
    }
}


    

