using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ModeleVueVueModele
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ModeleVueVueModele.View.MainPage shopsWindow = new View.MainPage();
            ShopViewModel VM = new ShopViewModel();
            shopsWindow.DataContext = VM;
            shopsWindow.Show();
        }
    }
}
