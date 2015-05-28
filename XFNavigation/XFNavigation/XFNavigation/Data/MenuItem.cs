using System;

namespace XFNavigation.Data
{
    public class MenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        public BucketCategory Category { get; set; }
    }
}

