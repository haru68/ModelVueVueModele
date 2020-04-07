using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ModeleVueVueModele
{
    class Shop : INotifyPropertyChanged
    {
        private int shopId { get; set; }
        private string shopName { get; set; }
        private string city { get; set; }
        private string department { get; set; }
        public int ShopId
        {
            get
            {
                return shopId;
            }
            set
            {
                shopId = value;
                OnPropertyChanged("ShopId");
            }
        }
        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                shopName = value;
                OnPropertyChanged("ShopName");
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
                OnPropertyChanged("Department");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
