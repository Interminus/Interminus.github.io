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

namespace InterminusLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string tab;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void interminuswebsite(object sender, RoutedEventArgs e)
        {
            LauncherScript.launchwebsite("https://interminus.github.io/");
        }

        private void launchgame(object sender, RoutedEventArgs e)
        {
            LauncherScript.playGame();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Home";
            InterminusStudios.Foreground = Brushes.Blue;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void YoutubeW(object sender, RoutedEventArgs e)
        {
            LauncherScript.launchwebsite("https://www.youtube.com/channel/UCmI8ha_INcVCvQlXWxHl4CA");
        }

        private void TwitterW(object sender, RoutedEventArgs e)
        {
            LauncherScript.launchwebsite("http://twitter.com/interminus");
        }

        private void InstagramW(object sender, RoutedEventArgs e)
        {
            LauncherScript.launchwebsite("https://www.instagram.com/interminus.studios/");
        }

        private void settings(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Settings";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.Blue;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void owned(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Owned";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.Blue;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void store(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Store";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.Blue;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void spotlight(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Spotlight";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.Blue;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void recent(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Recent";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.Blue;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void announcements(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Announcements";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.Blue;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.White;
        }

        private void community(object sender, RoutedEventArgs e)
        {
            TabText.Content = "Community";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.Blue;
            User.Foreground = Brushes.White;
        }

        private void usersettings(object sender, RoutedEventArgs e)
        {
            TabText.Content = "User";
            InterminusStudios.Foreground = Brushes.White;
            OwnedApps.Foreground = Brushes.White;
            LauncherSettings.Foreground = Brushes.White;
            InterminusStore.Foreground = Brushes.White;
            Spotlight.Foreground = Brushes.White;
            RecentlyUsed.Foreground = Brushes.White;
            Announcements.Foreground = Brushes.White;
            Community.Foreground = Brushes.White;
            User.Foreground = Brushes.Blue;
        }
    }
}
