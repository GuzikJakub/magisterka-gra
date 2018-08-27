﻿using System.Collections;
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

    public string nazwa_uroczystosci;

    public void wybor_uroczystosci()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;

        tekst_uroczystosc.SetActive(true);
        tekst_uroczystosc.GetComponent<UnityEngine.UI.Text>().text = tekst;
        nazwa_uroczystosci = tekst.ToString();
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
            ilosc_punktow = ilosc_punktow - 2;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena4.SetActive(false);
            scena3.SetActive(true);
        }
        else if (licznik_scen == 5)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena5.SetActive(false);
            scena4.SetActive(true);
        }
        else if (licznik_scen == 6)
        {
            ilosc_punktow = ilosc_punktow - 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
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

    public string nazwa_sali;

    public void wybor_sali()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        nazwa_sali = tekst.ToString();
//        nazwa_sali = tekst.ToString();
        Debug.Log(tekst);
        bool czy_kolejna = false;
        if (tekst == "Sala 1")
        {
            if (uroczystosc_warunki_sala(nazwa_uroczystosci) == true)
            {
                max_ilosc_osob = 15;
                widok_sala1.SetActive(true);
                widok_sala2.SetActive(false);
                widok_sala3.SetActive(false);
                widok_sala4.SetActive(false);
                //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }

        }
        else if (tekst == "Sala 2")
        {
            if (uroczystosc_warunki_sala(nazwa_uroczystosci) == true)
            {
                max_ilosc_osob = 8;
                widok_sala1.SetActive(false);
                widok_sala2.SetActive(true);
                widok_sala3.SetActive(false);
                widok_sala4.SetActive(false);
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Sala 3")
        {
            if (uroczystosc_warunki_sala(nazwa_uroczystosci) == true)
            {
                max_ilosc_osob = 4;
                widok_sala1.SetActive(false);
                widok_sala2.SetActive(false);
                widok_sala3.SetActive(true);
                widok_sala4.SetActive(false);
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Sala 4")
        {
            if (uroczystosc_warunki_sala(nazwa_uroczystosci) == true)
            {
                max_ilosc_osob = 2;
                widok_sala1.SetActive(false);
                widok_sala2.SetActive(false);
                widok_sala3.SetActive(false);
                widok_sala4.SetActive(true);
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        if (czy_kolejna == true)
        {
            ilosc_punktow = ilosc_punktow + 2;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena3.SetActive(false);
            scena4.SetActive(true);
            licznik_scen++;
        }
        
    }

    public bool uroczystosc_warunki_sala(string uroczystosc)
    {
        if (uroczystosc == "Walentynki")
        {
            if (ilosc_osob_l == "2" || ilosc_osob_l == "4")
            {
                if (nazwa_sali == "Sala 4")
                {
                    return true;
                }
            }
        }
        return false;
    }

    string nazwa_stolu_tmp; 

    public void wybor_stolu()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        nazwa_stolu_tmp = tekst.ToString();
 //       nazwa_stolu = tekst.ToString();
        Debug.Log(nazwa_stolu_tmp);
        bool czy_ok = false;
        if (tekst == "Stol kwadratowy")
        {
  //          Debug.Log("1");
            if (stol_warunki(nazwa_uroczystosci) == true)
            {
                max_ilosc_stolow = 2;
                widok_stol1.SetActive(true); //zmienic to -> znikaja przyciski
                widok_stol2.SetActive(false);
                widok_stol3.SetActive(false);
                widok_stol4.SetActive(false);
                //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Stol prostokatny")
        {
            if (stol_warunki(nazwa_uroczystosci) == true)
            {
                max_ilosc_stolow = 4;
                widok_stol1.SetActive(false);
                widok_stol2.SetActive(true);
                widok_stol3.SetActive(false);
                widok_stol4.SetActive(false);
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Stol okragly 70")
        {
            if (stol_warunki(nazwa_uroczystosci) == true)
            {
                max_ilosc_stolow = 2;
                widok_stol1.SetActive(false);
                widok_stol2.SetActive(false);
                widok_stol3.SetActive(true);
                widok_stol4.SetActive(false);
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Stol okragly 90")
        {
            if (stol_warunki(nazwa_uroczystosci) == true)
            {
                max_ilosc_stolow = 4;
                widok_stol1.SetActive(false);
                widok_stol2.SetActive(false);
                widok_stol3.SetActive(false);
                widok_stol4.SetActive(true);

                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        if (czy_ok == true)
        {
            ilosc_punktow = ilosc_punktow + 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            Debug.Log("JESTEM");
            scena4.SetActive(false);
            scena5.SetActive(true);
            licznik_scen++;
        }
    }

    bool ilosc_stolow_dalej;

    public void get_ilosc_stolow()
    {
        string ile_stolow;
        int ile_stolow_tmp;
        int ilosc_osob_tmp;
        ile_stolow = ilosc_stolow_get.text;
        int wynik_tmp;
        ilosc_stolow_dalej = false;

        int.TryParse(ilosc_osob_l, out ilosc_osob_tmp);
        int.TryParse(ile_stolow, out ile_stolow_tmp);

        wynik_tmp = ile_stolow_tmp * max_ilosc_stolow;
        int wynik_tmp2 = ile_stolow_tmp * (max_ilosc_stolow - 1);

        if(ilosc_osob_tmp <= wynik_tmp && ilosc_osob_tmp > wynik_tmp2)
        {
            ilosc_punktow = ilosc_punktow + 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            ilosc_stolow_dalej = true; //button do następnej sceny
            //wyswietlenie większej ilości stołów
        }
    }

    bool stol_warunki(string uroczystosc)
    {
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (nazwa_stolu_tmp == "Stol kwadratowy")
            {
                return true;
            }
        }
        return false;
    }

    public Button pomoc;
    public GameObject ksiazka_scena;
    public Text pomoc_text;

    public void pomoc_przycisk()
    {
        blad.SetActive(false);
        ksiazka_scena.SetActive(true);
        ilosc_punktow = ilosc_punktow - 1;
        punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (licznik_scen == 3)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybierając uroczystosc " + nazwa_uroczystosci + " dla " + ilosc_osob_l + " osób powinienieś wybrać salę, która będzie odpowiednia dla uroczystości romantycznych. Dodatkowo pamiętaj, żeby dobrze dysponować wszystkimi salami w naszej restauracji. Dla mniejszej ilości osób wybieraj mniejsze sale. Za pomoc utraciłeś 1 punkt.";
            }
            if (licznik_scen == 4)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybierając uroczystość " + nazwa_uroczystosci + " dla " + ilosc_osob_l + "osób, pamiętaj o dobrze odpowiedniego stolika. Takiej osoby chciałby siedzieć naprzeciwko siebie oraz jak najbardziej blisko. Rozdysponuj stolikami tak, aby w przypadku mniejszej ilości osób na jeden stolik, takie osoby dostawały mniejsze stoliki.";
            }
            if (licznik_scen == 5)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybrałeś uroczystość " + nazwa_uroczystosci + " dla " + ilosc_osob_l +  "osób. Stoliki, na którym siąda goście są dla " + max_ilosc_osob + " osób. Przelicz jeszcze raz ilość stolików!";
            }
        }
    }

    public void zamknij_pomoc()
    {
        ksiazka_scena.SetActive(false);
    }

    public void powiadomienie_blad()
    {
        if (ilosc_punktow > 0)
        {
            pomoc.interactable = true;
        }
        else
        {
            pomoc.interactable = false;
        }
        blad.SetActive(true);
        StartCoroutine(Blad_wait());
    }

    IEnumerator Blad_wait()
    {
        yield return new WaitForSeconds(3);
        blad.SetActive(false);
    }

    public void zapisz_scena_stol()
    {
        if (ilosc_stolow_dalej == true)
        {
            licznik_scen++;
            scena5.SetActive(false);
            scena6.SetActive(true);
        }
        else
        {
            powiadomienie_blad();
        }
        
    }

    public Toggle Obrus1;
    public Toggle Obrus2;
    public Toggle Obrus3;
    public Toggle Obrus4;

    public void check_obrus()
    {
        if (Obrus1.isOn == true)
        {
            Obrus2.interactable = false;
            Obrus3.interactable = false;
            Obrus4.interactable = false;
            //tutaj wyskakuje inforamcja z wyborem koloru obrusu - to jak będę miał stolik
 //           Debug.Log(Obrus1.isOn);
        }
        else if (Obrus2.isOn == true)
        {
            Obrus1.interactable = false;
            Obrus3.interactable = false;
            Obrus4.interactable = false;
//            Debug.Log(Obrus2.isOn);
        }
        else if (Obrus3.isOn == true)
        {
            Obrus1.interactable = false;
            Obrus2.interactable = false;
            Obrus4.interactable = false;
//            Debug.Log(Obrus1.isOn);
        }
        else if (Obrus4.isOn == true)
        {
            Obrus1.interactable = false;
            Obrus2.interactable = false;
            Obrus3.interactable = false;
//            Debug.Log(Obrus1.isOn);
        }
        else
        {
            Obrus1.interactable = true;
            Obrus2.interactable = true;
            Obrus3.interactable = true;
            Obrus4.interactable = true;
        }
    }
}