using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XFNavigation.Views.MasterDetail
{
    public class SimpleMasterDetailContainer : MasterDetailPage
    {
        public SimpleMasterDetailContainer()
        {
            Master = new ContentPage() {BackgroundColor = Color.Red, Title="Menu"};
            Detail = new ContentPage() {BackgroundColor = Color.Green, Title="Detail"};
        }
    }
}
