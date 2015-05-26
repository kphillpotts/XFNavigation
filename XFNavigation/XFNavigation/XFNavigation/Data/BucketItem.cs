using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFNavigation.Data
{
    public class BucketItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate {};

        public string BucketImageUrl { get; set; }

        string name;
        public string Name { 
            get { return name; }
            set { SetProperty(ref name, value); }
        }


        string _description;
        public string Description { 
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }


        BucketCategory _category;
        public BucketCategory Category { 
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        bool _done;
        public bool Done { 
            get { return _done; }
            set { SetProperty(ref _done, value); }
        }



        /// <summary>
        /// Method to compare and replace a field's value and raise a 
        /// PropertyChanged notification if it was altered.
        /// </summary>
        /// <returns><c>true</c>, if field was set, <c>false</c> otherwise.</returns>
        /// <param name="field">Field.</param>
        /// <param name="value">Value.</param>
        /// <param name="propertyName">Property name.</param>
        /// <typeparam name="T">Field type.</typeparam>
        bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "") 
        {
            if (!object.Equals(field, value)) {
                field = value;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }

    }
}

