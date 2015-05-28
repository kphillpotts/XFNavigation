using System;
using XFNavigation.Data;

namespace XFNavigation.Views.MasterDetail
{
    public class MenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        public BucketCategory Category { get; set; }
    }
}

