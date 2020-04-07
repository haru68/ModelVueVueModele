using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace ModeleVueVueModele
{
    class ShopViewModel
    {
        private IList<Shop> _ShopList;

        public ShopViewModel()
        {
            _ShopList = new List<Shop>
            {
                new Shop{ShopName = "Shop1", City="Strasbourg", Department="Bas-Rhin", ShopId=1},
                new Shop{ShopName = "Shop2", City="Colmar", Department="Haut-Rhin", ShopId=2},
                new Shop{ShopName = "Shop3", City="Mulhouse", Department="Haut-Rhin", ShopId=3},
                new Shop{ShopName = "Shop4", City="Ferrette", Department="Haut-Rhin", ShopId=4},
                new Shop{ShopName = "Shop5", City="Nancy", Department="Meurte et Moselle", ShopId=5},
                new Shop{ShopName = "Shop6", City="Besançon", Department="Doubs", ShopId=6}
            };
        }

        public IList<Shop> Shops
        {
            get
            {
                return _ShopList;
            }
            set
            {
                _ShopList = value;
            }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if(mUpdater == null)
                {
                    mUpdater = new Updater();
                }
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }
        }

    }
}
