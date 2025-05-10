using LIB_PROJET;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CONCERT_MUSIQUE.C;

public class COORDINATION :C_NOTIFIABLE {
    C_BASE_PROJET La_Base;
    public COORDINATION() {
        La_Base = new C_BASE_PROJET();

        Liste_Concerts = La_Base.Get_All_Concert();
    }

    private List<C_CONCERT> _Liste_Concerts;

    public List<C_CONCERT> Liste_Concerts {
        get { return _Liste_Concerts; }
        set {
            _Liste_Concerts = value;
            Signale_Changement();
        }
    }
    private C_CONCERT _Concerts_Selectionne;

    public C_CONCERT Concerts_Selectionnee {
        get { return _Concerts_Selectionne; }
        set {
            _Concerts_Selectionne = value;
            Signale_Changement();
        }
    }
}
