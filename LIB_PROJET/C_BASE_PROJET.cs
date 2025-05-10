using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace LIB_PROJET;
public class C_CONCERT {
    public int id { get; set; }
    public string style_de_musique { get; set; }
    public string groupe { get; set; }
    public string lieu { get; set; }
    public int prix { get; set; }
    public string date { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }

    //---------------------------------------------
    public void Affiche_Toi() {
        Console.WriteLine($"{id} {style_de_musique} {groupe} {lieu} {prix} {date}");
    }
}
//===============================================
public class C_BASE_PROJET {
    List<C_CONCERT> Les_Concerts;
    //---------------------------------------------
    public C_BASE_PROJET() {
        Chargement_Memoire();
    }

    //---------------------------------------------
    void Chargement_Memoire() {
        string Data_Json = File.ReadAllText("concert.json");
        Les_Concerts = JsonSerializer.Deserialize<List<C_CONCERT>>(Data_Json);

    }

    //-----------------------------------------------
    public void Affiche_Concerts() {
        foreach(C_CONCERT Un_Concert in Les_Concerts) {
            Un_Concert.Affiche_Toi();
        }
    }

    //-----------------------------------------------
    public List<C_CONCERT> Get_All_Concert() {
        return Les_Concerts;
    }
}
