using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace HelloWorld
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Basic Input sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Page 1", ClassType=typeof(Page1)},
            new Scenario() { Title="Page 2", ClassType=typeof(Page2)},
            new Scenario() { Title="Page 3", ClassType=typeof(Page3)},
            new Scenario() { Title="DentallHiS", ClassType=typeof(DentallHiS)}
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}