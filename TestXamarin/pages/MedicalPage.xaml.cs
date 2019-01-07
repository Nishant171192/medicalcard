using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestXamarin.pages
{
    public partial class MedicalPage : ContentPage
    {
        public MedicalPage()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);

            Header.HasNotificationIcon(true);
        }
    }
}
