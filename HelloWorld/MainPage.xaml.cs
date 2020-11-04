using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Populate the scenario list from the SampleConfiguration.cs file
            var itemCollection = new List<Scenario>();
            foreach (Scenario s in scenarios)
            {
                itemCollection.Add(new Scenario { Title = $"{s.Title}", ClassType = s.ClassType });
            }
            NavigationBar.ItemsSource = itemCollection;
        }

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    ScenarioFrame.Navigate(typeof(Page1));
        //}

        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    ScenarioFrame.Navigate(typeof(Page2));
        //}

        private void ScenarioControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListBox scenarioListBox = sender as ListBox;
            Scenario s = scenarioListBox.SelectedItem as Scenario;

            if (s != null)
            {
                ScenarioFrame.Navigate(s.ClassType);
            }
        }

        public List<Scenario> Scenarios
        {
            get { return this.scenarios; }
        }
    }
}
