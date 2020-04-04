using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchScript : MonoBehaviour
{
    public string theEnter;
    public GameObject inputField;
    public GameObject textDisplay;
    public void storeNumber()
    {
        theEnter = inputField.GetComponent<Text>().text;
        if (theEnter == null)
            textDisplay.GetComponent<Text>().text = "Campul de input este gol.";
        else
        {
            try
            {
                int numEnter = Int32.Parse(theEnter);
                if (numEnter < 1 || numEnter > 425)
                    textDisplay.GetComponent<Text>().text = "Nu pot sa gasesc aceasta sala. Te rog sa mai verifici o data.";
                else
                {
                    switch (numEnter / 100)
                    {
                        case 0: 
                            {
                                bool verify = false;
                                if (numEnter > 0 && numEnter < 7)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din stanga (cum intri in facultate), pe partea stanga.";
                                }
                                if(numEnter >6 && numEnter< 11)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din stanga (cum intri in facultate), pe partea dreapta.";
                                }
                                if(numEnter >26 && numEnter < 29)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), pe partea stanga.";
                                }
                                if(numEnter > 17 && numEnter < 26)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), dupa amfiteatru.";
                                }
                                if(numEnter >11 && numEnter < 17)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Parter, pe culoarul din dreapta (cum intri in facultate), pe partea dreapta.";
                                }
                                if (numEnter == 17)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Aceasta sala este de fapt amfitestrul Haret";
                                }
                                if (verify == false)
                                    textDisplay.GetComponent<Text>().text = "Nu pot sa gasesc aceasta sala. Te rog sa mai verifici o data.";
                                break;
                            }
                        case 1: 
                            {
                                bool verify = false;
                                if (numEnter > 100 && numEnter < 105)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din dreapta (cum urci scarile principale), pe partea stanga.";
                                }
                                if(numEnter == 112)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din dreapta (cum urci scarile principale), prima sala pe partea dreapta.";
                                }
                                if(numEnter == 113)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 1, fata in fata cu scarile principale.";
                                }
                                if (numEnter > 113 && numEnter< 122 && numEnter !=118)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din stanga (cum urci scarile principale), pe partea dreapta.";
                                }
                                if(numEnter > 121&& numEnter<126)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 1, pe culoarul din stanga (cum urci scarile principale), pe partea stanga.";
                                }
                                if (numEnter == 118)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Aceasta sala este de fapt amfitestrul Stoilow";
                                }
                                if (verify == false)
                                    textDisplay.GetComponent<Text>().text = "Nu pot sa gasesc aceasta sala. Te rog sa mai verifici o data.";
                                break;
                            }
                        case 2: 
                            {
                                bool verify = false;
                                if (numEnter > 200 && numEnter < 206)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din dreapta (cum urci scarile principale), pe partea stanga.";
                                }
                                if (numEnter >205 && numEnter <213)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din dreapta (cum urci scarile principale), pe partea dreapta.";
                                }
                                if (numEnter == 213)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 2, fata in fata cu scarile principale.";
                                }
                                if (numEnter > 213 && numEnter < 221 && numEnter != 217)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din stanga (cum urci scarile principale), pe partea dreapta.";
                                }
                                if (numEnter > 220 && numEnter < 225)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 2, pe culoarul din stanga (cum urci scarile principale), pe partea stanga.";
                                }
                                if (numEnter == 217)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Aceasta sala este de fapt amfitestrul Pompeiu";
                                }
                                if (verify == false)
                                    textDisplay.GetComponent<Text>().text = "Nu pot sa gasesc aceasta sala. Te rog sa mai verifici o data.";
                                break;
                            }
                        case 3: 
                            {
                                bool verify = false;
                                if (numEnter > 301 && numEnter < 307)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din dreapta (cum urci scarile principale), pe partea stanga.";
                                }
                                if (numEnter > 306 && numEnter < 311)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din dreapta (cum urci scarile principale), pe partea dreapta.";
                                }
                                if (numEnter == 301)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 3, fata in fata cu scarile principale.";
                                }
                                if (numEnter > 210 && numEnter < 322 && numEnter != 316)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din stanga (cum urci scarile principale), pe partea dreapta.";
                                }
                                if (numEnter > 321 && numEnter < 327)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Etajul 3, pe culoarul din stanga (cum urci scarile principale), pe partea stanga.";
                                }
                                if (numEnter == 316)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "Aceasta sala este de fapt amfitestrul Titeica";
                                }
                                if (verify == false)
                                    textDisplay.GetComponent<Text>().text = "Nu pot sa gasesc aceasta sala. Te rog sa mai verifici o data.";
                                break;
                            }
                        case 4: 
                            {
                                bool verify = false;
                                if((numEnter > 420 && numEnter < 426) || numEnter == 419)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "La etajul 3 urci scarile din capatul culoarului din stanga. Sala pe care o cauti este pe partea drepta.";
                                }
                                if(numEnter>412 && numEnter<421 && numEnter!=419)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "La etajul 3 urci scarile din capatul culoarului din stanga. Sala pe care o cauti este pe partea stanga.";
                                }
                                if (numEnter > 404 && numEnter <410)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "La etajul 3 urci scarile din capatul culoarului din dreapta. Sala pe care o cauti este in spatele tau.";
                                }
                                if (numEnter >400 && numEnter <405)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "La etajul 3 urci scarile din capatul culoarului din dreapta. Sala pe care o cauti este pe partea stanga.";
                                }
                                if (numEnter >409 && numEnter < 413)
                                {
                                    verify = true;
                                    textDisplay.GetComponent<Text>().text = "La etajul 3 urci scarile din capatul culoarului din dreapta. Sala pe care o cauti este pe partea dreapta.";
                                }
                                if (verify == false)
                                    textDisplay.GetComponent<Text>().text = "Nu pot sa gasesc aceasta sala. Te rog sa mai verifici o data.";
                                break;
                            }
                        default: 
                            {
                                Debug.Log("Nu stiu cum ai reusit sa ajungi aici, dar nu e bine");
                                break;
                            }
                    }
                }
            }
            catch
            {
                textDisplay.GetComponent<Text>().text = "Campul de input trebuie sa contina doar cifre.";
            }
        }
    }
}
