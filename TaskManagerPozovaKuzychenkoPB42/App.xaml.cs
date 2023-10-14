using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaskManagerPozovaKuzychenkoPB42.DataBase;

namespace TaskManagerPozovaKuzychenkoPB42
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainContext MainContext = new MainContext();
    }
}
