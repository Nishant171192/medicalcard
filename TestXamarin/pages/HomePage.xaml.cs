using System;
using System.Collections.Generic;
using TestXamarin.Model;
using Xamarin.Forms;

namespace TestXamarin.pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
            BindingContext = new DependencyModalClass();




            //Child.ItemsSource = dependencyModalClasses;
        }
    }
}
