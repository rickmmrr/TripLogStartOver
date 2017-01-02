using System;
using System.Collections.Generic;
using TripLogStartOver.Models;
using Xamarin.Forms;

namespace TripLogStartOver
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            //add new to toolbar
            var newButton = new ToolbarItem
            {
                Text = "New"
            };
            newButton.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new NewEntryPage());
            };

            //ContentPage member
            ToolbarItems.Add(newButton);
            
            
            
            
            //Content Page Member
            Title = "Triplog";


            //Iteration 1 add some default data
            var items = new List<TripLogEntry>
            {
                new TripLogEntry
                {
                    Title = "Washington Monument",
                    Notes = "Amazing!",
                    Rating = 3,
                    Date = new DateTime(2015,2,5),
                    Latitude = 38.8895,
                    Longitude = -77.0352
                },
                new TripLogEntry
                {
                    Title = "Statue of Liberty",
                    Notes = "Inspiring",
                    Rating = 4,
                    Date = new DateTime(2015,4,13),
                    Latitude = 40.6892,
                    Longitude = -74.0444
                },
                new TripLogEntry
                {
                    Title = "Golden Gate Bridge",
                    Notes = "Foggy, but beautiful.",
                    Rating = 5,
                    Date = new DateTime(2015,4,26),
                    Latitude = 37.8268,
                    Longitude = -122.4798
                }


            };

            var itemTemplate = new DataTemplate(typeof(TextCell));
            itemTemplate.SetBinding(TextCell.TextProperty, "Title");
            itemTemplate.SetBinding(TextCell.DetailProperty, "Notes");

            var entries = new ListView
            {
                ItemsSource = items,
                ItemTemplate = itemTemplate
            };

            Content = entries;

        }

        private void NewButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
