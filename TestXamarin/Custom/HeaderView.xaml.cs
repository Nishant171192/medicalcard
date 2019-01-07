using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestXamarin.Custom
{
    public partial class HeaderView : Grid
    {

        #region BindableProperties


        public static readonly BindableProperty TitleProperty = BindableProperty.Create(propertyName: "Title",
               returnType: typeof(string),
               declaringType: typeof(HeaderView), defaultValue: "Title");
        public String Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }


        #endregion

        public ICommand OnTapBackCommand { get; set; }
        public ICommand OnTapBellCommand { get; set; }
        public ICommand OnTapMenuCommand { get; set; }
        public ICommand OnTapExpandCommand { get; set; }
        public ICommand OnTapSearchBarCommand { get; set; }
        public HeaderView()
        {
            InitializeComponent();
            BackLayout.IsVisible = true;
            MenuLayout.IsVisible = false;
            BindingContext = this;
        }


        void OnLeftTapped(object sender, System.EventArgs e)
        {
            OnTapBackCommand?.Execute(null);
            OnTapMenuCommand?.Execute(null);
        }
        void OnRightTapped(object sender, System.EventArgs e)
        {
            OnTapBellCommand?.Execute(null);
        }

        void OnExpandTapped(object sender, System.EventArgs e)
        {
            OnTapExpandCommand?.Execute(null);
        }

        private void OnSearchTapped(object sender, System.EventArgs e)
        {
            OnTapSearchBarCommand?.Execute(null);
        }

        public void HasMenu(bool value)
        {
            MenuLayout.IsVisible = true;
            BackLayout.IsVisible = false;
        }

        public void setNotificationCount(string value)
        {
            if (value == "0")
            {
                CountView.IsVisible = false;
                notificationCount.Text = "";
            }
            else
            {
                notificationCount.Text = value;
                CountView.IsVisible = true;
            }
        }

        public void HasNotificationIcon(bool value)
        {
            RightView.IsVisible = value;
        }
        public void HasExpandIcon(bool value)
        {
            ExpandLayout.IsVisible = value;
        }

        public void setBackIconVisiblity(bool value)
        {
            BackLayout.IsVisible = value;
        }

        public void SetExpandIcon(bool value)
        {
            if (value)
            {
                ExpandIcon.Source = "expandView.png";
            }
            else
            {
                ExpandIcon.Source = "closeView.png";
            }
        }
        public void SetTitle(string value)
        {
            TitleLabel.Text = value;
        }

        public void HasSearchIcon(bool value)
        {
            SearchLayout.IsVisible = value;
        }
    }
}
