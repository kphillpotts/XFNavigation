using Xamarin.Forms;
using XFNavigation.Data;

namespace XFNavigation.Views
{
    public partial class BucketItemDetail : ContentPage
    {
        public BucketItemDetail(BucketItem item)
        {
            BindingContext = item;
            InitializeComponent();
        }
    }
}

