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
using Newtonsoft.Json;
using System.IO;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Connecting database
        database_showContainer db = new database_showContainer();

        //All lists
        List<Show> allShows;

        public MainWindow()
        {
            InitializeComponent();

            //Getting data for all Shows
            allShows = GetShows();
            lbxShow.ItemsSource = allShows;
        }

        //Getting data for all Shows (where all lists are saved)
        public List<Show> GetShows()
        {
            List<Show> allShows = new List<Show>();
            #region Create Shows
            //Creating info
            //Friends
            Show S1 = new Show() { ShowName = "Friends", image = "/images/Friends.jpg"};
            Season S1s1 = new Season() { numberOfSeason = 1, SeasonName = "All the Friends" };
            S1.Seasons.Add(S1s1);
            Episode S1s1e1 = new Episode() { numberOfEpisode = 1 };
            S1s1.Episodes.Add(S1s1e1);
            Episode S1s1e2 = new Episode() { numberOfEpisode = 2 };
            S1s1.Episodes.Add(S1s1e2);
            Episode S1s1e3 = new Episode() { numberOfEpisode = 3 };
            S1s1.Episodes.Add(S1s1e3);
            Episode S1s1e4 = new Episode() { numberOfEpisode = 4 };
            S1s1.Episodes.Add(S1s1e4);
            Season S1s2 = new Season() { numberOfSeason = 2, SeasonName = "Friends Gone" };
            S1.Seasons.Add(S1s2);
            Episode S1s2e1 = new Episode() { numberOfEpisode = 1 };
            S1s2.Episodes.Add(S1s2e1);
            Episode S1s2e2 = new Episode() { numberOfEpisode = 2 };
            S1s2.Episodes.Add(S1s2e2);
            Episode S1s2e3 = new Episode() { numberOfEpisode = 3 };
            S1s2.Episodes.Add(S1s2e3);
            Season S1s3 = new Season() { numberOfSeason = 3, SeasonName = "Splitting Apart" };
            S1.Seasons.Add(S1s3);
            Episode S1s3e1 = new Episode() { numberOfEpisode = 1 };
            S1s3.Episodes.Add(S1s3e1);
            Episode S1s3e2 = new Episode() { numberOfEpisode = 2 };
            S1s3.Episodes.Add(S1s3e2);
            Episode S1s3e3 = new Episode() { numberOfEpisode = 3 };
            S1s3.Episodes.Add(S1s3e3);

            //Fraiser
            Show S2 = new Show() { ShowName = "Fraiser", image = "/images/Fraiser.jpg" };
            Season S2s1 = new Season() { numberOfSeason = 1, SeasonName = "What could go wrong?" };
            S2.Seasons.Add(S2s1);
            Episode S2s1e1 = new Episode() { numberOfEpisode = 1 };
            S2s1.Episodes.Add(S2s1e1);
            Episode S2s1e2 = new Episode() { numberOfEpisode = 2 };
            S2s1.Episodes.Add(S2s1e2);
            Episode S2s1e3 = new Episode() { numberOfEpisode = 3 };
            S2s1.Episodes.Add(S2s1e3);
            Episode S2s1e4 = new Episode() { numberOfEpisode = 4 };
            S2s1.Episodes.Add(S2s1e4);
            Season S2s2 = new Season() { numberOfSeason = 2, SeasonName = "Lying Down" };
            S2.Seasons.Add(S2s2);
            Episode S2s2e1 = new Episode() { numberOfEpisode = 1 };
            S2s2.Episodes.Add(S2s2e1);
            Episode S2s2e2 = new Episode() { numberOfEpisode = 2 };
            S2s2.Episodes.Add(S2s2e2);
            Episode S2s2e3 = new Episode() { numberOfEpisode = 3 };
            S2s2.Episodes.Add(S2s2e3);
            Episode S2s2e4 = new Episode() { numberOfEpisode = 4 };
            S2s2.Episodes.Add(S2s2e4);

            //The Office
            Show S3 = new Show() { ShowName = "The Office", image = "/images/theOffice.jpg" };
            Season S3s1 = new Season() { numberOfSeason = 1, SeasonName = "In America" };
            S3.Seasons.Add(S3s1);

            //Scrubs
            Show S4 = new Show() { ShowName = "Scrubs", image = "/images/scrubs.jpg" };
            Season S4s1 = new Season() { numberOfSeason = 1, SeasonName = "ER Emergency" };
            S4.Seasons.Add(S4s1);

            //Seinfield
            Show S5 = new Show() { ShowName = "Seinfield", image = "/images/Seinfield.jpg" };
            Season S5s1 = new Season() { numberOfSeason = 1, SeasonName = "The Classics" };
            S5.Seasons.Add(S5s1);
            #endregion

            //Adding bands into list
            allShows.Add(S1);
            allShows.Add(S2);
            allShows.Add(S3);
            allShows.Add(S4);
            allShows.Add(S5);
            return allShows;
        }


        //Displays Seasons in listbox through selectedShows
        private void LbxShow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshDisplay();
            Show selectedShows = lbxShow.SelectedItem as Show;
            if (selectedShows != null)
            {
                lbxSeason.ItemsSource = selectedShows.Seasons;
                imgBox.Source = new BitmapImage(new Uri(selectedShows.image, UriKind.Relative));
            }

         

            /*var query = from c in db.Seasons
                        select c.name2;

            lbxShow.ItemsSource = query.ToList(); */
        }


        //Displays episodes in listbox through selectedSeasons
        private void LbxSeason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Season selectedSeason = lbxSeason.SelectedItem as Season;
            if (selectedSeason != null)
            {
                lbxEpisode.ItemsSource = selectedSeason.Episodes;
            }
        }


        //Refreshes all displays back to the begininng
        private void RefreshDisplay()
        {
            imgBox.Source = null;
            lbxEpisode.ItemsSource = null;
            lbxSeason.ItemsSource = null;
            rbOneStar.IsChecked = false;
            rbTwoStar.IsChecked = false;
            rbThreeStar.IsChecked = false;
            rbFourStar.IsChecked = false;
            rbFiveStar.IsChecked = false;
            tbxReview.Text = "";
        }


        //Saves the review and rating for an episode
        private void BtnSaveReview_Click(object sender, RoutedEventArgs e)
        {
            //Figure out what rating
            int rating = 0;
            if (rbOneStar.IsChecked == true)
            { rating = 1; }
            else if (rbTwoStar.IsChecked == true)
            { rating = 2; }
            else if (rbThreeStar.IsChecked == true)
            { rating = 3; }
            else if (rbFourStar.IsChecked == true)
            { rating = 4; }
            else if (rbFiveStar.IsChecked == true)
            { rating = 5; }

            //Get review text
            string reviewText = tbxReview.Text;

            //Saves for Episode
            Episode selectedEpisode = lbxEpisode.SelectedItem as Episode;
            if (selectedEpisode != null)
            {
                //Update episode object with review
                selectedEpisode.Review = reviewText;
                selectedEpisode.Rating = rating;
            }


            string data = JsonConvert.SerializeObject(selectedEpisode, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter("C:\\Users\\artmc\\Documents\\OOD.json"))
            {
                sw.Write(data);
                sw.Close();
            }

            //Refreshes page
            RefreshDisplay();

        }


        //This method helps save the rating for an episode
        private void lbxEpisode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check something selected
            Episode selected = lbxEpisode.SelectedItem as Episode;

            if (selected != null)
            {
                //update screen
                tbxReview.Text = selected.Review;

                switch(selected.Rating)
                {
                    case 1:
                        rbOneStar.IsChecked = true;  //sets radiobutton to checked
                        break;

                    case 2:
                        rbTwoStar.IsChecked = true;
                        break;

                    case 3:
                        rbThreeStar.IsChecked = true;
                        break;

                    case 4:
                        rbFourStar.IsChecked = true;
                        break;

                    case 5:
                        rbFiveStar.IsChecked = true;
                        break;
                }

            }
        }

        



        private void rbOneStar_Checked(object sender, RoutedEventArgs e)
        {

        }
        public void tbxReview_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
