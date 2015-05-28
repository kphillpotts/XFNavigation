using System;
using Xamarin.Forms;

namespace XFNavigation.Views.PushPop
{
    public partial class PushPage : ContentPage
    {
        private int _pageNumber;

        public PushPage(int pageNumber)
        {
            InitializeComponent();
            _pageNumber = pageNumber;
            Title = string.Format("Page {0}", _pageNumber);
            PageTitleLabel.Text = Title;

            //// change background colour depending on page number
            //var delta = 255 - (_pageNumber*5);
            //this.BackgroundColor = Color.FromRgb(delta, delta, delta);
        }

        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }

        private void PushPageButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PushPage(_pageNumber + 1));
        }

        private void PopPageButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void PopToRootButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void PushModalToolbarButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ModalPage());
        }
    }
}
