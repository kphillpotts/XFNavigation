using Xamarin.Forms;

namespace XFNavigation.Views.MasterDetail.SimpleMasterDetail
{
    public class SimpleMasterDetailContainer : MasterDetailPage
    {
        public SimpleMasterDetailContainer()
        {
            Master = new SimpleMasterPage();
            Detail = new NavigationPage(new SimpleDetailPage());
            this.MasterBehavior = MasterBehavior.Default;
        }
    }
}
