using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Przycisk_zachownaie : MonoBehaviour
{
   // Button przycisk;
    public GameObject tekst_uroczystosc;
    public GameObject scena1;
    public GameObject scena2;
    public GameObject scena3;
    public GameObject scena4;
    public GameObject scena5;
    public GameObject scena6;
    public GameObject scena7;
    public GameObject scena8;
    public GameObject scena9;
    public GameObject scena10;
    public GameObject scena11;
    public InputField ilosc_osob;
    public GameObject widok_sala1;
    public GameObject widok_sala2;
    public GameObject punkty;
    public int ilosc_punktow;

    public GameObject pop_up_wyjdz;
    public int licznik_scen;
    string ilosc_osob_l;

    public void wybor_uroczystosci()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;

        tekst_uroczystosc.SetActive(true);
        tekst_uroczystosc.GetComponent<UnityEngine.UI.Text>().text = tekst;
        scena1.SetActive(false);
        scena2.SetActive(true);
        licznik_scen++;
        Debug.Log(tekst);
    }

    public void zamknij()
    {
        pop_up_wyjdz.SetActive(true);
    }

    public void wyjdz_nie()
    {
        pop_up_wyjdz.SetActive(false);
    }

    public void wycztaj_scene(string name)
    {
        Application.LoadLevel(name);
        licznik_scen = 0;
        ilosc_punktow = 0;
    }

    public void cofnij()
    {
        if(licznik_scen == 2)
        {
            zamknij();
        }
        else if(licznik_scen == 3)
        {
            licznik_scen--;
            scena3.SetActive(false);
            scena2.SetActive(true);
        }
        else if (licznik_scen == 4)
        {
            licznik_scen--;
            scena4.SetActive(false);
            scena3.SetActive(true);
        }
        else if (licznik_scen == 5)
        {
            licznik_scen--;
            scena5.SetActive(false);
            scena4.SetActive(true);
        }
        else if (licznik_scen == 6)
        {
            licznik_scen--;
            scena6.SetActive(false);
            scena5.SetActive(true);
        }
        else if (licznik_scen == 7)
        {
            licznik_scen--;
            scena7.SetActive(false);
            scena6.SetActive(true);
        }
        else if (licznik_scen == 8)
        {
            licznik_scen--;
            scena8.SetActive(false);
            scena7.SetActive(true);
        }
        else if (licznik_scen == 9)
        {
            licznik_scen--;
            scena9.SetActive(false);
            scena8.SetActive(true);
        }
        else if (licznik_scen == 10)
        {
            licznik_scen--;
            scena10.SetActive(false);
            scena9.SetActive(true);
        }
        else if (licznik_scen == 11)
        {
            licznik_scen--;
            scena11.SetActive(false);
            scena10.SetActive(true);
        }
    }

    public void get_ilosc_osob()
    {

        ilosc_osob_l = ilosc_osob.text;
        Debug.Log(ilosc_osob_l);

    }

    public void zapisz_scena()
    {
        licznik_scen++;
        scena2.SetActive(false);
        scena3.SetActive(true);
    }

    public void wybor_sali()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(tekst);
        if (tekst == "Sala 1")
        {
            widok_sala1.SetActive(true);
            widok_sala2.SetActive(false);
            ilosc_punktow = ilosc_punktow + 2;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
        }
        else if (tekst == "Sala 2")
        {
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(true);
        }
    }
}