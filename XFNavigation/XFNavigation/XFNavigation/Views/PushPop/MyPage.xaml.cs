using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFNavigation.Views.PushPop
{
    public partial class MyPage : ContentPage
    {
        private int _pageNumber;

        public MyPage(int pageNumber)
        {
            InitializeComponent();
            _pageNumber = pageNumber;
            this.Title = string.Format("Page {0}", _pageNumber);
        }

        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }

        private void PushPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MyPage(_pageNumber + 1));
        }

        private void PopPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void PopToRootButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PopToRootAsync();
        }

        private void PushModalToolbarButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new ModalPage());
        }
    }
}
