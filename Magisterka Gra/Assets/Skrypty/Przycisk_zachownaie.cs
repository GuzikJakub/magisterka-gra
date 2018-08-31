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
            ilosc_punktow = ilosc_punktow - 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena7.SetActive(false);
            scena6.SetActive(true);
        }
        else if (licznik_scen == 8) // inna
        {
            ilosc_punktow = ilosc_punktow - 1 - licznik_punkty;
            if (byl_punkt_dekoracje == true)
            {
                ilosc_punktow = ilosc_punktow - 1;
            }
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena8.SetActive(false);
            scena7.SetActive(true);
        }
        else if (licznik_scen == 9)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 2;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
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
            if (stol_warunki() == true)
            {
                max_ilosc_stolow = 2;
            /*    widok_stol1.SetActive(true); //zmienic to -> znikaja przyciski
                widok_stol2.SetActive(false);
                widok_stol3.SetActive(false);
                widok_stol4.SetActive(false);*/
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
            if (stol_warunki() == true)
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
            if (stol_warunki() == true)
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
            if (stol_warunki() == true)
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

    bool stol_warunki()
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
            if (licznik_scen == 6)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybraleś uroczystość " + nazwa_uroczystosci + ". Dla romantycznej kolacji, najlepiej, żeby stoły były trochę od siebie oddalone. Dajmy ludziom trochę prywatności :)";
            }
            if (licznik_scen == 7)
            {
                if (obrus_chec == false)
                {
                    pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Na wybrany przez Ciebie stół " + nazwa_stolu_tmp + " powinienieś wybrać inny obrus. Zastanów się nad tym i spróbuj poprawić!";
                }
                else if (licznik_scen == 7 && dekoracje_check == true && Dekoracje3 == true && nazwa_uroczystosci == "Walentynki")
                { //to nie mam ogólne, tylko na walentynki
                    pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Na wybraną przez Ciebie uroczystość " + nazwa_uroczystosci + " powinienieś wybrać bardziej dogodne dekoracje, które wprowadzą elementy romatyczne";
                }
            }
            if (licznik_scen == 8)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Na wybraną przez Ciebie uroczystość " + nazwa_uroczystosci + " powinienieś wybrać menu, które najbardziej będzie odpowiadało gościom. Czy jesteś pewny tego? Zastanów się :) ";
            }
            if (licznik_scen == 9)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Na wybraną przez Ciebie uroczystość " + nazwa_uroczystosci + " i wybranym menu " + nazwa_menu + "powinienieś wybrać bardziej przystosowany rodzaj nakrycia";
            }
            if (licznik_scen == 10)
            {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Dla wybranego " + nazwa_menu + " wybrane przez Ciebie elementy są błędną lub niekompletne. Zobacz jeszcze raz na menu, a następnie ponownie skup się nad przygotowaniem zastawy ceramicznej.";
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

    public GameObject ustawienie1;
    public GameObject ustawienie2;
    public GameObject ustawienie3;
    public GameObject ustawienie4;
    public GameObject ustawienie5;
    string ustawienie_stolu;

    public void wybor_ustawienie_stolow()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        ustawienie_stolu = tekst.ToString();
        Debug.Log(tekst);
        bool czy_ok = false;
        if (tekst == "Pojedyncze stoly")
        {
            //          Debug.Log("1");
            if (ustawienie_warunki() == true)
            {
           /*     ustawienie1.SetActive(true);
                ustawienie2.SetActive(false);
                ustawienie3.SetActive(false);
                ustawienie4.SetActive(false);
                ustawienie5.SetActive(false);*/
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Blok")
        {
            if (ustawienie_warunki() == true)
            {
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Litera T")
        {
            if (ustawienie_warunki() == true)
            {
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Litera U")
        {
            if (ustawienie_warunki() == true)
            {

                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Litera E")
        {
            if (ustawienie_warunki() == true)
            {

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
            scena6.SetActive(false);
            scena7.SetActive(true);
            licznik_scen++;
        }
    }

    bool ustawienie_warunki()
    {
        if (nazwa_uroczystosci == "Walentynki")
        {
            Debug.Log("1");
            if (ustawienie_stolu == "Pojedyncze stoly")
            {
                Debug.Log("2");
                return true;
            }
        }
        return false;
    }

    public Toggle Obrus1;
    public Toggle Obrus2;
    public Toggle Obrus3;
    public Toggle Obrus4;
    bool obrus_chec;

    public void check_obrus()
    {
        if (Obrus1.isOn == true)
        {
            Obrus2.interactable = false;
            Obrus3.interactable = false;
            Obrus4.interactable = false;
            if (nazwa_stolu_tmp == "Stol kwadratowy")
            {
                obrus_chec = true;
            }
            else
            {
                obrus_chec = false;
            }
            //tutaj wyskakuje inforamcja z wyborem koloru obrusu - to jak będę miał stolik
 //           Debug.Log(Obrus1.isOn);
        }
        else if (Obrus2.isOn == true)
        {
            Obrus1.interactable = false;
            Obrus3.interactable = false;
            Obrus4.interactable = false;
            if (nazwa_stolu_tmp == "Stol prostokątny")
            {
                obrus_chec = true;
            }
            else
            {
                obrus_chec = false;
            }
            //            Debug.Log(Obrus2.isOn);
        }
        else if (Obrus3.isOn == true)
        {
            Obrus1.interactable = false;
            Obrus2.interactable = false;
            Obrus4.interactable = false;
            if (nazwa_stolu_tmp == "Stol okragly 70")
            {
                obrus_chec = true;
            }
            else
            {
                obrus_chec = false;
            }
            //            Debug.Log(Obrus1.isOn);
        }
        else if (Obrus4.isOn == true)
        {
            Obrus1.interactable = false;
            Obrus2.interactable = false;
            Obrus3.interactable = false;
            if (nazwa_stolu_tmp == "Strol okragly 90")
            {
                obrus_chec = true;
            }
            else
            {
                obrus_chec = false;
            }
            //            Debug.Log(Obrus1.isOn);
        }
        else
        {
            Obrus1.interactable = true;
            Obrus2.interactable = true;
            Obrus3.interactable = true;
            Obrus4.interactable = true;
            obrus_chec = false;
        }
    }

    public Toggle serwety1;
    public Toggle serwety2;
    public Toggle serwety3;
    public Toggle serwety4;
    bool serwety_check;

    public void serwety_ulozenie()
    {
        if (serwety1.isOn == true)
        {
            serwety2.interactable = false;
            serwety3.interactable = false;
            serwety4.interactable = false;
            serwety_check = true;
        }
        else if (serwety2.isOn == true)
        {
            serwety1.interactable = false;
            serwety3.interactable = false;
            serwety4.interactable = false;
            serwety_check = true;
        }
        else if (serwety3.isOn == true)
        {
            serwety1.interactable = false;
            serwety2.interactable = false;
            serwety4.interactable = false;
            serwety_check = true;
        }
        else if (serwety4.isOn == true)
        {
            serwety1.interactable = false;
            serwety2.interactable = false;
            serwety3.interactable = false;
            serwety_check = true;
        }
        else
        {
            serwety1.interactable = true;
            serwety2.interactable = true;
            serwety3.interactable = true;
            serwety4.interactable = true;
            serwety_check = false;
        }
    }

    public Toggle Laufry1;
    public Toggle Laufry2;
    public Toggle Laufry3;
    bool laufry_check;

    public Toggle Skirtingi1;
    public Toggle Skirtingi2;
    public Toggle Skirtingi3;
    bool skirtingi_check;

    public Toggle Napperony1;
    public Toggle Napperony2;
    public Toggle Napperony3;
    bool napperony_check;

    public Toggle Dekoracje1;
    public Toggle Dekoracje2;
    public Toggle Dekoracje3;
    bool dekoracje_check;


    public void kolory_ustaw_laufry()
    {
        if (Laufry1.isOn == true)
        {
            Laufry2.interactable = false;
            Laufry3.interactable = false;
            laufry_check = true;
        }
        else if (Laufry2.isOn == true)
        {
            Laufry1.interactable = false;
            Laufry3.interactable = false;
            laufry_check = true;
        }
        else if (Laufry3.isOn == true)
        {
            Laufry1.interactable = false;
            Laufry2.interactable = false;
            laufry_check = true;
        }
        else
        {
            Laufry1.interactable = true;
            Laufry2.interactable = true;
            Laufry3.interactable = true;
            laufry_check = false;
        }
    }

    public void kolory_ustaw_skirtingi()
    {
        if (Skirtingi1.isOn == true)
        {
            Skirtingi2.interactable = false;
            Skirtingi3.interactable = false;
            skirtingi_check = true;
        }
        else if (Skirtingi2.isOn == true)
        {
            Skirtingi1.interactable = false;
            Skirtingi3.interactable = false;
            skirtingi_check = true;
        }
        else if (Skirtingi3.isOn == true)
        {
            Skirtingi2.interactable = false;
            Skirtingi3.interactable = false;
            skirtingi_check = true;
        }
        else
        {
            Skirtingi1.interactable = true;
            Skirtingi2.interactable = true;
            Skirtingi3.interactable = true;
            skirtingi_check = false;
        }
    }

    public void kolory_ustaw_napperony()
    {
        if (Napperony1.isOn == true)
        {
            Napperony2.interactable = false;
            Napperony3.interactable = false;
            napperony_check = true;
        }
        else if (Napperony2.isOn == true)
        {
            Napperony1.interactable = false;
            Napperony3.interactable = false;
            napperony_check = true;
        }
        else if (Napperony3.isOn == true)
        {
            Napperony1.interactable = false;
            Napperony2.interactable = false;
            napperony_check = true;
        }
        else
        {
            Napperony1.interactable = true;
            Napperony2.interactable = true;
            Napperony3.interactable = true;
            napperony_check = false;
        }
    }

    public void dekoracje_ustaw()
    {
        
        if (Dekoracje1.isOn == true)
        {
            Dekoracje2.interactable = false;
            Dekoracje3.interactable = false;
            dekoracje_check = true;
        }
        else if (Dekoracje2.isOn == true)
        {
            Dekoracje1.interactable = false;
            Dekoracje3.interactable = false;
            dekoracje_check = true;
        }
        else if (Dekoracje3.isOn == true)
        {
            Dekoracje1.interactable = false;
            Dekoracje2.interactable = false;
            dekoracje_check = true;
        }
        else
        {
            Dekoracje1.interactable = true;
            Dekoracje2.interactable = true;
            Dekoracje3.interactable = true;
            dekoracje_check = false;
        }
    }

    bool sprawdz_licznik(int licznik)
    {
        if (licznik < 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    bool byl_punkt_dekoracje;
    bool sprawdz_dekoracja()
    {
        byl_punkt_dekoracje = false;
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (Dekoracje1.isOn == true || Dekoracje2.isOn == true)
            {
                ilosc_punktow = ilosc_punktow + 1;
                punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                byl_punkt_dekoracje = true;
                return true;
            }
            else if (Dekoracje3.isOn == true)
            {
                Debug.Log("TEN BŁĄD");
                powiadomienie_blad();
                return false;
            }
        }
        return true;
    }
    int licznik_punkty;
    public void zatwierdz_bielizna()
    {
        licznik_punkty = 0;
        if (obrus_chec == true)
        {
            ilosc_punktow = ilosc_punktow + 1;
            
            if (serwety_check == true)
            {
                if (sprawdz_licznik(licznik_punkty) == true)
                {
                    ilosc_punktow = ilosc_punktow + 1;
                    licznik_punkty++;
                }
            }
            if (laufry_check == true)
            {
                if (sprawdz_licznik(licznik_punkty) == true)
                {
                    ilosc_punktow = ilosc_punktow + 1;
                    licznik_punkty++;
                }
            }
            if (skirtingi_check == true)
            {
                if (sprawdz_licznik(licznik_punkty) == true)
                {
                    ilosc_punktow = ilosc_punktow + 1;
                    licznik_punkty++;
                }
            }
            if (napperony_check == true)
            {
                if (sprawdz_licznik(licznik_punkty) == true)
                {
                    ilosc_punktow = ilosc_punktow + 1;
                    licznik_punkty++;
                }
            }
            if (sprawdz_dekoracja() == true)
            {
                punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                licznik_scen++;
                scena7.SetActive(false);
                scena8.SetActive(true);
            }
            
        }
        else
        {
            powiadomienie_blad();
        }
        //kod do sprawdzenia czy dobre rzeczy został wybrane
    }

    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject menu4;
    string nazwa_menu;

    public void sprawdz_menu()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        nazwa_menu = tekst.ToString();
        //        nazwa_sali = tekst.ToString();
        Debug.Log(tekst);
        bool czy_kolejna = false;
        if (tekst == "Romantyczna kolacja")
        {
            Debug.Log("JESSSST");
            Debug.Log(menu_warunki());
            if (menu_warunki() == true)
            {
                //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
                czy_kolejna = true;
                Debug.Log("JESTEM");
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Menu codzienne")
        {
            if (menu_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Obiad wystawny")
        {
            if (menu_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Oferta rozszerzona")
        {
            if (menu_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        if (czy_kolejna == true)
        {
            ilosc_punktow = ilosc_punktow + 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena8.SetActive(false);
            scena9.SetActive(true);
            licznik_scen++;
        }
    }

    bool menu_warunki()
    {
        Debug.Log("JESTEM 2");
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (nazwa_menu == "Romantyczna kolacja")
            {
                Debug.Log("JESTEM 3");
                return true;
            }
        }
        return false;
    }

    string nakrycie_tmp;

    public void sprawdz_nakrycie()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        nakrycie_tmp = tekst.ToString();
        //        nazwa_sali = tekst.ToString();
        Debug.Log(tekst);
        bool czy_kolejna = false;
        if (tekst == "Proste")
        {
            Debug.Log(menu_warunki());
            if (nakrycie_warunki() == true)
            {
                //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Rozszerzone")
        {
            if (nakrycie_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "la carte")
        {
            if (nakrycie_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        if (czy_kolejna == true)
        {
            ilosc_punktow = ilosc_punktow + 1;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena9.SetActive(false);
            scena10.SetActive(true);
            licznik_scen++;
        }
    }

    bool nakrycie_warunki()
    {
        if (nakrycie_tmp == "Proste")
        {
            if (nazwa_menu == "Romantyczna kolacja" || nazwa_menu == "Menu codzienne")
            {
                return true;
            }
        }
        if (nakrycie_tmp == "Rozszerzone")
        {
            if (nazwa_menu == "Obiad wystawny")
            {
                return true;
            }
        }
        if (nakrycie_tmp == "la carte")
        {
            if (nazwa_menu == "Oferta rozszerzona")
            {
                return true;
            }
        }
        return false;
    }

    Toggle sprawdz_toggle;
    // InputField aktywnosc;


/*    public void aktywne_toggle_off(InputField aktywnosc)
    {
        if (aktywnosc.interactable == false)
        {
            aktywnosc.interactable = true;
        }
        else
        {
            aktywnosc.interactable = false;
        }
    } */

    public Toggle talerz1;
    public Toggle talerz2;

    public void talerze_block()
    {
        if (talerz1.isOn == true)
        {
            talerz2.interactable = false;
        }
        else if (talerz2.isOn == true)
        {
            talerz1.interactable = false;
        }
        else
        {
            talerz1.interactable = true;
            talerz2.interactable = true;
        }
    }

    public Toggle ceramika3;
    public Toggle ceramika4;
    public Toggle ceramika5;
    public Toggle ceramika6;
    public Toggle ceramika7;
    public Toggle ceramika8;
    public Toggle ceramika9;
    public Toggle ceramika10;
    public Toggle ceramika11;
    bool nastepna_scena_ceramika;
    public void ceramika_sprawdzian()
    {
        nastepna_scena_ceramika = false;
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (talerz1.isOn == true && ceramika3.isOn == true && ceramika4.isOn == true)
            {
                ilosc_punktow = ilosc_punktow + 2;
                nastepna_scena_ceramika = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }

        if (nastepna_scena_ceramika == true)
        {
            licznik_scen++;
            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena10.SetActive(false);
            scena11.SetActive(true);
        }
    }


}