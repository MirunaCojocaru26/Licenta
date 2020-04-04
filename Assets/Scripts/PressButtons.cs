using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PressButtons : MonoBehaviour
{
    public GameObject textDisplay;
    //0
    public void pressHaret()
    {
        textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), a patra usa pe partea dreapta.";
    }
    //1
    public void pressStoilow()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din stanga (cum urci scarile principale), a treia usa pe partea dreapta.";
    }
    //2
    public void pressPompeiu()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din stanga (cum urci scarile principale), a cincea usa pe partea dreapta.";
    }
    //3
    public void pressTiteica()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din stanga (cum urci scarile principale), a sasea usa pe partea dreapta.";
    }
    //4
    public void pressDecanat()
    {
        textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), dupa amfiteatru, ultima usa pe partea stanga inainte de scari.";
    }
    //5
    public void pressProdecanat()
    {
        textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), imediat dupa amfiteatru, a doua usa pe partea stanga.";
    }
    //6
    public void pressSecretariat()
    {
        textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), imediat dupa amfiteatru, prima usa pe partea dreapta.";
    }
    //7
    public void pressCaserie()
    {
        textDisplay.GetComponent<Text>().text = "Parter, prima usa pe dreapta cum intri in facultate.";
    }
    //9
    public void pressAsmi()
    {
        textDisplay.GetComponent<Text>().text = "Demisol, pe culoarul din dreapta (cum cobori scarile), pe partea stanga.";
    }
    //10
    public void pressGoogle()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 2, cum urci scarile imediat pe partea stanga. Nu ai cum sa il ratezi.";
    }
    //11
    public void pressCegeka()
    {
        textDisplay.GetComponent<Text>().text = "Aka sala 303. Etajul 3, culoarul din dreapta (cum urci scarile) a treia usa pe partea stanga.";
    }
    //12
    public void pressPlanetariu()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 3, fata in fata cu scarile principale.";
    }
    //13
    public void pressRobo()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din stanga (cum urci scarile principale), a cincea usa pe partea dreapta, langa amfiteatrul Titeica.";
    }
    //14
    public void pressBiblioteca()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din stanga (cum urci scarile principale), a doua usa pe partea stanga.";
    }
    //15
    public void pressLectura()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din dreapta (cum urci scarile principale), a treia usa pe partea stanga.";
    }
    //16
    public void pressEcdl()
    {
        textDisplay.GetComponent<Text>().text = "Laboratorul 411, etajul 4 (in capetele diametral opuse fiecarui culoar de le etajul 3 sunt scari spre etajul 4)";
    }
    //17
    public void pressProtocol()
    {
        textDisplay.GetComponent<Text>().text = "Demisol, culoarul din dreapta (cum cobori scarile), prima sala pe dreapta.";
    }
    //18
    public void pressConsiliu()
    {
        textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), dupa amfiteatru, ultima usa pe partea dreapta.";
    }
    //19
    public void pressCataloage()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 1, fata in fata cu scarile principale.";
    }
    //20
    public void pressCatedraDeInformatica()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din stanga (cum urci scarile principale), imediat dupa amfiteatrul Titeica, salile 317, 318, 323.";
    }
    //21
    public void pressCatedraDeGeometrie()
    {
        textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din stanga (cum intri in facultate), a doua usa pe partea stanga.";
    }
    //22
    public void pressCatedraDePS()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din dreapta (cum urci scarile principale), prima usa pe partea dreapta.";
    }
    //23
    public void pressCatedraDeMecanicaSiEcuatii()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din dreapta (cum urci scarile principale), salile 304 si 306.";
    }
    //24
    public void pressCatedraDeAlgebra()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din stanga (cum urci scarile principale), sala 224.";
    }
    //25
    public void pressCatedraDeAnaliza()
    {
        textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din dreapta (cum urci scarile principale), prima usa pe partea dreapta.";
    }
    //26
    public void pressFundamenteleInformaticii()
    {
        textDisplay.GetComponent<Text>().text = "Parter, salile 4 si 15.";
    }
    //27
    public void pressLimbiStraine()
    {
        textDisplay.GetComponent<Text>().text = "Demisol, pe culoarul din stanga, a treia sala pe partea dreapta.";
    }
}
