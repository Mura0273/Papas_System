using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Papas_System.UI
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {

        public Menu()
        {
            switch (combobox.SelectedItem)
            {
                case "1":
                    datebox1.IsEnabled = true;
                    break;
                case "2":
                    datebox1.IsEnabled = true;
                    datebox2.IsEnabled = true;
                    break;
                default:
                    //what you want when nothing is selected
                    break;
            }
        }
    }
}
