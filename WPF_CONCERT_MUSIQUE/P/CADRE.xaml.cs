using LIB_PROJET;
using Microsoft.Maps.MapControl.WPF;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_CONCERT_MUSIQUE.C;

namespace WPF_CONCERT_MUSIQUE;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class CADRE :Window {
    COORDINATION La_Coordination;
    C_BASE_PROJET La_Base;

    public CADRE() {
        La_Coordination = new COORDINATION();
        InitializeComponent();

        DataContext = La_Coordination;
    }

    private void Lbox_Concert_SelectionChanged(object sender,SelectionChangedEventArgs e) {
        if(La_Coordination.Concerts_Selectionnee != null) {
            mapControl.Center = new Location(La_Coordination.Concerts_Selectionnee.latitude,La_Coordination.Concerts_Selectionnee.longitude);
        }
    }
}