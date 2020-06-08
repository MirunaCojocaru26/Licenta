using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PressButtons : MonoBehaviour
{
    public GameObject textDisplay;
    //0
    public void pressHaret()
    {
        translate("Parter, pe culoarul din dreapta (cum intri in facultate), a patra usa pe partea dreapta.");
    }
    //1
    public void pressStoilow()
    {
        translate("Etajul 1, pe culoarul din stanga (cum urci scarile principale), a treia usa pe partea dreapta.");
    }
    //2
    public void pressPompeiu()
    {
        translate("Etajul 2, pe culoarul din stanga (cum urci scarile principale), a cincea usa pe partea dreapta.");
    }
    //3
    public void pressTiteica()
    {
        translate("Etajul 3, pe culoarul din stanga (cum urci scarile principale), a sasea usa pe partea dreapta.");
    }
    //4
    public void pressDecanat()
    {
        translate("Parter, pe culoarul din dreapta (cum intri in facultate), dupa amfiteatru, ultima usa pe partea stanga inainte de scari.");
    }
    //5
    public void pressProdecanat()
    {
        translate("Parter, pe culoarul din dreapta (cum intri in facultate), imediat dupa amfiteatru, a doua usa pe partea stanga.");
    }
    //6
    public void pressSecretariat()
    {
        translate("Parter, pe culoarul din dreapta (cum intri in facultate), imediat dupa amfiteatru, prima usa pe partea dreapta.");
    }
    //7
    public void pressCaserie()
    {
        translate("Parter, prima usa pe dreapta cum intri in facultate.");
    }
    //9
    public void pressAsmi()
    {
        translate("Demisol, pe culoarul din dreapta (cum cobori scarile), pe partea stanga.");
    }
    //10
    public void pressGoogle()
    {
        translate("Etajul 2, cum urci scarile imediat pe partea stanga. Nu ai cum sa il ratezi.");
    }
    //11
    public void pressCegeka()
    {
        translate("Aka sala 303. Etajul 3, culoarul din dreapta (cum urci scarile) a treia usa pe partea stanga.");
    }
    //12
    public void pressPlanetariu()
    {
        translate("Etajul 3, fata in fata cu scarile principale.");
    }
    //13
    public void pressRobo()
    {
        translate("Etajul 3, pe culoarul din stanga (cum urci scarile principale), a cincea usa pe partea dreapta, langa amfiteatrul Titeica.");
    }
    //14
    public void pressBiblioteca()
    {
        translate("Etajul 1, pe culoarul din stanga (cum urci scarile principale), a doua usa pe partea stanga.");
    }
    //15
    public void pressLectura()
    {
        translate("Etajul 1, pe culoarul din dreapta (cum urci scarile principale), a treia usa pe partea stanga.");
    }
    //16
    public void pressEcdl()
    {
        translate("Laboratorul 411, etajul 4 (in capetele diametral opuse fiecarui culoar de le etajul 3 sunt scari spre etajul 4)");
    }
    //17
    public void pressProtocol()
    {
        translate("Demisol, culoarul din dreapta (cum cobori scarile), prima sala pe dreapta.");
    }
    //18
    public void pressConsiliu()
    {
        translate("Parter, pe culoarul din dreapta (cum intri in facultate), dupa amfiteatru, ultima usa pe partea dreapta.");
    }
    //19
    public void pressCataloage()
    {
        translate("Etajul 1, fata in fata cu scarile principale.");
    }
    //20
    public void pressCatedraDeInformatica()
    {
        translate("Etajul 3, pe culoarul din stanga (cum urci scarile principale), imediat dupa amfiteatrul Titeica, salile 317, 318, 323.");
    }
    //21
    public void pressCatedraDeGeometrie()
    {
        translate("Parter, pe culoarul din stanga (cum intri in facultate), a doua usa pe partea stanga.");
    }
    //22
    public void pressCatedraDePS()
    {
        translate("Etajul 2, pe culoarul din dreapta (cum urci scarile principale), prima usa pe partea dreapta.");
    }
    //23
    public void pressCatedraDeMecanicaSiEcuatii()
    {
        translate("Etajul 3, pe culoarul din dreapta (cum urci scarile principale), salile 304 si 306.");
    }
    //24
    public void pressCatedraDeAlgebra()
    {
        translate("Etajul 2, pe culoarul din stanga (cum urci scarile principale), sala 224.");
    }
    //25
    public void pressCatedraDeAnaliza()
    {
        translate("Etajul 2, pe culoarul din dreapta (cum urci scarile principale), prima usa pe partea dreapta.");
    }
    //26
    public void pressFundamenteleInformaticii()
    {
        translate("Parter, salile 4 si 15.");
    }
    //27
    public void pressLimbiStraine()
    {
        translate("Demisol, pe culoarul din stanga, a treia sala pe partea dreapta.");
    }

    public void translate(string myText)
    {
        Language lang = new Language();
        string first = lang.prefLang("Auto");
        string lang_name = PlayerPrefs.GetString("language");
        string second = lang.prefLang(lang_name);
        string response = " ";
        Translator translator = Translator.Create(first, second);
        int i = 0;
        translator.Run(myText, results => {
            foreach (var result in results)
            {
                response = response + result.translated;
            }
            textDisplay.GetComponent<Text>().text = response;
        });
    }
}
