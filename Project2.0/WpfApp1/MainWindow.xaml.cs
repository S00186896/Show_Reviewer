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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //All lists
        List<Show> allShows;
        List<Show> selectedShows;
        List<Episode> allEpisodes;
        List<Episode> selectedEpisode;
        List<Season> allSeasons;
        List<Season> selectedSeason;

        public MainWindow()
        {
            InitializeComponent();

            //Getting data for all Shows
            allShows = GetShows();
            lbxShow.ItemsSource = allShows;
        }

        //Getting data for all Shows
        private List<Show> GetShows()
        {
            List<Show> allShows = new List<Show>();
            //Creating info
            Show S1 = new Show() { ShowName = "Friends"};
            Season S1s1 = new Season() { numberOfSeason = 1, SeasonName = "All the Friends" };
            S1.Seasons.Add(S1s1);
            Season S1s2 = new Season() { numberOfSeason = 2, SeasonName = "Closer Friends" };
            S1.Seasons.Add(S1s2);

            Show S2 = new Show() { ShowName = "Fraiser" };
            Season S2s1 = new Season() { numberOfSeason = 1, SeasonName = "What could go wrong?" };
            S2.Seasons.Add(S2s1);

            Show S3 = new Show() { ShowName = "The Office" };
            Season S3s1 = new Season() { numberOfSeason = 1, SeasonName = "In America" };
            S3.Seasons.Add(S3s1);

            Show S4 = new Show() { ShowName = "Scrubs" };
            Season S4s1 = new Season() { numberOfSeason = 1, SeasonName = "ER Emergency" };
            S4.Seasons.Add(S4s1);

            Show S5 = new Show() { ShowName = "Seinfield" };
            Season S5s1 = new Season() { numberOfSeason = 1, SeasonName = "The Classics" };
            S5.Seasons.Add(S5s1);

            //Adding bands into list
            allShows.Add(S1);
            allShows.Add(S2);
            allShows.Add(S3);
            allShows.Add(S4);
            allShows.Add(S5);
            return allShows;
        }

        private void LbxShow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Show selectedShows = lbxShow.SelectedItem as Show;
            if (selectedShows != null)
            {
                lbxSeason.ItemsSource = selectedShows.Seasons;
            }
        }


    }
}
