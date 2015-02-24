using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.UI.ApplicationSettings;
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Data_Structure_Tutorial
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            try
            {
                ani.Begin();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SettingsPane.GetForCurrentView().CommandsRequested += SettingsCommandsRequested;
        }

        private void SettingsCommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        {
            var privacyStatement = new SettingsCommand("privacy", "Privacy Policy", x => Launcher.LaunchUriAsync(new Uri("http://fybcaprogrammers.blogspot.in/p/privacy-for-windows-8-tips-and-info-app.html")));

            args.Request.ApplicationCommands.Clear();
            args.Request.ApplicationCommands.Add(privacyStatement);
        }

        private void gostack(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage),stack.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void go_twostack(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.two_stack.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        private void go_queue(object sender, RoutedEventArgs e)
        {
             try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.queue.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void gocir_queue(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.Circular_Queue.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void go_linklist(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.Link_List.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void go_cir_linkist(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.Circular_Link_List.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void go_dou_linkinst(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.Doubly_Linked_List.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void go_cir_doulinklist(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.Circular_Doubly_Linked_List.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void go_btree(object sender, RoutedEventArgs e)
        {
            try
            {
                ani.Stop();
                this.Frame.Navigate(typeof(ItemPage), this.Binary_Tree.Content.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


        

        
    }
}
