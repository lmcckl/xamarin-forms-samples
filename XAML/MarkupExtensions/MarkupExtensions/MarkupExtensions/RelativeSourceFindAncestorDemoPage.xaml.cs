﻿using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MarkupExtensions
{
    public partial class RelativeSourceFindAncestorDemoPage : ContentPage
    {
        public PeopleViewModel People { get; } = new PeopleViewModel
        {
            Employees = new ObservableCollection<Person>
            {
                new Person
                {
                    Forename = "John",
                    Surname = "Doe"
                },
                new Person
                {
                    Forename = "Jane",
                    Surname = "Doe"
                },
                new Person
                {
                    Forename = "Xamarin",
                    Surname = "Monkey"
                }
            }
        };

        public RelativeSourceFindAncestorDemoPage()
        {
            InitializeComponent();
        }
    }
}
