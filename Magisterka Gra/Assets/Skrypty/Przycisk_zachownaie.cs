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
    public InputField ilosc_stolow_get;

    public int max_ilosc_stolow;
    public GameObject widok_sala1;
    public GameObject widok_sala2;
    public GameObject widok_sala3;
    public GameObject widok_sala4;

    public int max_ilosc_osob;
    public GameObject widok_stol1;
    public GameObject widok_stol2;
    public GameObject widok_stol3;
    public GameObject widok_stol4;

    public GameObject punkty;
    public int ilosc_punktow;

    public GameObject blad;

    public GameObject pop_up_wyjdz;
    public int licznik_scen;
    string ilosc_osob_l;
//    string nazwa_stolu;
//    string nazwa_sali;

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
        licznik_scen++;
        var tekst = EventSystem.current.currentSelectedGameObject.name;
//        nazwa_sali = tekst.ToString();
        Debug.Log(tekst);
        if (tekst == "Sala 1")
        {
            max_ilosc_osob = 15;
            widok_sala1.SetActive(true);
            widok_sala2.SetActive(false);
            widok_sala3.SetActive(false);
            widok_sala4.SetActive(false);
            ilosc_punktow = ilosc_punktow + 2;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
        }
        else if (tekst == "Sala 2")
        {
            max_ilosc_osob = 8;
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(true);
            widok_sala3.SetActive(false);
            widok_sala4.SetActive(false);
        }
        else if (tekst == "Sala 3")
        {
            max_ilosc_osob = 4;
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(false);
            widok_sala3.SetActive(true);
            widok_sala4.SetActive(false);
        }
        else if (tekst == "Sala 4")
        {
            max_ilosc_osob = 2;
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(false);
            widok_sala3.SetActive(false);
            widok_sala4.SetActive(true);
        }
        scena3.SetActive(false);
        scena4.SetActive(true);
    }

    public void wybor_stolu()
    {
        licznik_scen++;
        var tekst = EventSystem.current.currentSelectedGameObject.name;
 //       nazwa_stolu = tekst.ToString();
        Debug.Log(tekst);
        if (tekst == "Stol kwadratowy")
        {
            max_ilosc_stolow = 2;
            widok_sala1.SetActive(true);
            widok_sala2.SetActive(false);
            widok_sala3.SetActive(false);
            widok_sala4.SetActive(false);
            ilosc_punktow = ilosc_punktow + 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)

        }
        else if (tekst == "Stol prostokatny")
        {
            max_ilosc_stolow = 4;
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(true);
            widok_sala3.SetActive(false);
            widok_sala4.SetActive(false);
        }
        else if (tekst == "Stol okragly 70")
        {
            max_ilosc_stolow = 2;
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(false);
            widok_sala3.SetActive(true);
            widok_sala4.SetActive(false);
        }
        else if (tekst == "Stol okragly 90")
        {
            max_ilosc_stolow = 4;
            widok_sala1.SetActive(false);
            widok_sala2.SetActive(false);
            widok_sala3.SetActive(false);
            widok_sala4.SetActive(true);
        }
        scena4.SetActive(false);
        scena5.SetActive(true);
    }

    public void get_ilosc_stolow()
    {
        string ile_stolow;
        int ile_stolow_tmp;
        int ilosc_osob_tmp;
        ile_stolow = ilosc_stolow_get.text;
        int wynik_tmp;


        int.TryParse(ilosc_osob_l, out ilosc_osob_tmp);
        int.TryParse(ile_stolow, out ile_stolow_tmp);

        wynik_tmp = ile_stolow_tmp * max_ilosc_stolow;
        int wynik_tmp2 = ile_stolow_tmp * (max_ilosc_stolow - 1);

        if(ilosc_osob_tmp <= wynik_tmp && ilosc_osob_tmp > wynik_tmp2) //poprawka, ze nie może być jednej osoby przy stole
        {

        }
        else
        {
            blad.SetActive(true);
            StartCoroutine(Blad_wait());
        }
    }

    IEnumerator Blad_wait()
    {
        yield return new WaitForSeconds(3);
        blad.SetActive(false);
    }

    public void zapisz_scena_stol()
    {
        licznik_scen++;
        scena5.SetActive(false);
        scena6.SetActive(true);
    }
}