using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Przycisk_zachownaie : MonoBehaviour
{
    // Button przycisk;
    public GameObject tekst_uroczystosc;

    public GameObject scena0;
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
    public GameObject scena12;

    public InputField ilosc_osob;
    public InputField ilosc_stolow_get;

    public GameObject tables_all;

    public int max_ilosc_stolow;
    public Sprite widok_sala1;
    public Sprite widok_sala2;
    public Sprite widok_sala3;
    public Sprite widok_sala4;
    public Sprite widok_sala_white;
    public Sprite widok_podloga;
    public GameObject widok_sali;

    public int max_ilosc_osob;
    public GameObject widok_stol_all;
    public GameObject widok_stol1;
    public GameObject widok_stol2;
    public GameObject widok_stol3;
    public GameObject widok_stol4;
    public GameObject widok_stol5;
    public GameObject widok_stol6;
    public GameObject widok_stol7;

    public GameObject punkty;
    public int ilosc_punktow;

    public GameObject blad;

    public GameObject pop_up_wyjdz;
    public int licznik_scen;
    string ilosc_osob_l;
    //    string nazwa_stolu;
    //    string nazwa_sali;

    public string nazwa_uroczystosci;

    public GameObject menu;
    public GameObject menu_zatwierdz;

    public Sprite okragly70;
    public Sprite okragly90;
    public Sprite kwadrat;
    public Sprite prostokat;

    public void wybor_uroczystosci()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;

        tekst_uroczystosc.SetActive(true);
        tekst_uroczystosc.GetComponent<UnityEngine.UI.Text>().text = tekst;
        nazwa_uroczystosci = tekst.ToString();
        Scene obecna_scena = SceneManager.GetActiveScene();
        string nazwa_sceny = obecna_scena.name;
        if (nazwa_sceny == "2Poziom2")
        {
            if (nazwa_uroczystosci == "Walentynki" && typ_przyjecia_string == "Angielskie")
            {
                powiadomienie_blad();
            }
            else
            {
                scena1.SetActive(false);
                scena2.SetActive(true);
                licznik_scen++;
                Debug.Log(tekst);
            }
        }
        else
        {
            scena1.SetActive(false);
            scena2.SetActive(true);
            licznik_scen++;
            Debug.Log(tekst);
        }
        
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
 //       licznik_scen = 0;
        ilosc_punktow = 0;
    }

    public void cofnij()
    {
        if (licznik_scen == 2)
        {
            licznik_scen--;
            tekst_uroczystosc.SetActive(false);
            scena2.SetActive(false);
            scena1.SetActive(true);
        }
        else if (licznik_scen == 1)
        {
            licznik_scen--;
            scena1.SetActive(false);
            scena0.SetActive(true);
        }
        else if (licznik_scen == 3)
        {
            licznik_scen--;
            scena3.SetActive(false);
            scena2.SetActive(true);
        }
        else if (licznik_scen == 4)
        {
            ilosc_punktow = ilosc_punktow - 2;
            widok_sali.GetComponent<SpriteRenderer>().sprite = widok_sala_white;
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena4.SetActive(false);
            scena3.SetActive(true);
        }
        else if (licznik_scen == 5)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 1;
            tables_all.SetActive(true);
            widok_stol_all.SetActive(false);
            widok_stol5.SetActive(false);
            widok_stol6.SetActive(false);
            widok_stol7.SetActive(false);
            //widok_stol1.SetActive(false);
            //widok_stol2.SetActive(false);
            //widok_stol3.SetActive(false);
            //widok_stol4.SetActive(false);
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena6.SetActive(false);
            scena4.SetActive(true);
        }
        else if (licznik_scen == 6)
        {
            ilosc_punktow = ilosc_punktow - 1;
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena5.SetActive(false);
            scena6.SetActive(true);
        }
        else if (licznik_scen == 7)
        {
            ilosc_punktow = ilosc_punktow - 1;
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena7.SetActive(false);
            scena5.SetActive(true);
        }
        else if (licznik_scen == 8) // inna
        {
            ilosc_punktow = ilosc_punktow - 1 - licznik_punkty;
            if (byl_punkt_dekoracje == true)
            {
                ilosc_punktow = ilosc_punktow - 1;
            }
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            licznik_scen--;
            scena8.SetActive(false);
            scena7.SetActive(true);
        }
        else if (licznik_scen == 9)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 1;
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena9.SetActive(false);
            scena8.SetActive(true);
        }
        else if (licznik_scen == 10)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 1;
            //            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
            scena10.SetActive(false);
            scena9.SetActive(true);
        }
        else if (licznik_scen == 11)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 2;
            scena11.SetActive(false);
            scena11_srodek_rozszerzone.SetActive(false);
            scena11_srodek_proste.SetActive(false);
            scena10.SetActive(true);
        }
        else if (licznik_scen == 12)
        {
            licznik_scen--;
            ilosc_punktow = ilosc_punktow - 2;
            scena12.SetActive(false);
            scena11.SetActive(true);
        }
        punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
        Debug.Log(licznik_scen);
    }

    string typ_przyjecia_string;

    public void typ_przyjecia()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        typ_przyjecia_string = tekst.ToString();
        Debug.Log(typ_przyjecia_string);
        licznik_scen++;
        scena0.SetActive(false);
        scena1.SetActive(true);
    }

    public void get_ilosc_osob()
    {

        ilosc_osob_l = ilosc_osob.text;
        int x = 0;
        x = int.Parse(ilosc_osob_l);
        if (nazwa_uroczystosci == "Walentynki" & (x == 3 || x == 1 || x > 4))
        {
            powiadomienie_blad();
        }
        Debug.Log(ilosc_osob_l);

    }

    public void zapisz_scena()
    {
        if (ilosc_osob_l == "1")
        {
            powiadomienie_blad();
        }
        else if (ilosc_osob_l == "0")
        {
            powiadomienie_blad();
        }
        else
        {
            if (nazwa_uroczystosci == "Wesele")
            {
                if (ilosc_osob_l == "2")
                {
                    powiadomienie_blad();
                }
                else if (ilosc_osob_l == "3")
                {
                    powiadomienie_blad();
                }
                else
                {
                    licznik_scen++;
                    scena2.SetActive(false);
                    scena3.SetActive(true);
                }
            }
            else
            {
                licznik_scen++;
                scena2.SetActive(false);
                scena3.SetActive(true);
            }
        }
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
                max_ilosc_osob = 160;
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_sala1;
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
                max_ilosc_osob = 110;
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_sala2;
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
                max_ilosc_osob = 36;
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_sala3;
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
                max_ilosc_osob = 16;
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_sala4;
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
        int x = 0;
        x = int.Parse(ilosc_osob_l);
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
        else if (uroczystosc != "")
        {
            if (x <= 16 & nazwa_sali == "Sala 4")
            {
                return true;
            }
            else if (x > 16 & x <= 36 & nazwa_sali == "Sala 3")
            {
                return true;
            }
            else if (x > 36 & x <= 110 & nazwa_sali == "Sala 2")
            {
                return true;
            }
            else if (x > 110 & x <= 160 & nazwa_sali == "Sala 1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

    string nazwa_stolu_tmp;
    int dodatkowa_ilosc_osob;
    int dodatkowa_ilosc_stolow;
    int podstawowa_ilosc_osob;
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
                podstawowa_ilosc_osob = 2;
                widok_stol1.transform.position = new Vector3(411.0f, 144.6f, 0.0f);
                widok_stol1.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol1.GetComponent<SpriteRenderer>().sprite = kwadrat;
                widok_stol2.transform.position = new Vector3(622.25f, 144.6f, 0.0f);
                widok_stol2.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol2.GetComponent<SpriteRenderer>().sprite = kwadrat;
                widok_stol3.transform.position = new Vector3(514.25f, 218.1f, 0.0f);
                widok_stol3.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol3.GetComponent<SpriteRenderer>().sprite = kwadrat;
                widok_stol4.transform.position = new Vector3(734.0f, 218.1f, 0.0f);
                widok_stol4.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol4.GetComponent<SpriteRenderer>().sprite = kwadrat;
                widok_stol5.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol5.GetComponent<SpriteRenderer>().sprite = kwadrat;
                widok_stol6.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol6.GetComponent<SpriteRenderer>().sprite = kwadrat;
                widok_stol7.transform.localScale = new Vector3(20.0f, 20.0f, 1.0f);
                widok_stol7.GetComponent<SpriteRenderer>().sprite = kwadrat;
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
                podstawowa_ilosc_osob = 4;
                widok_stol1.transform.position = new Vector3(415.8f, 168.8f, 0.0f);
                widok_stol1.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol1.GetComponent<SpriteRenderer>().sprite = prostokat;
                widok_stol2.transform.position = new Vector3(648.8f, 168.8f, 0.0f);
                widok_stol2.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol2.GetComponent<SpriteRenderer>().sprite = prostokat;
                widok_stol3.transform.position = new Vector3(519.3f, 247.2f, 0.0f);
                widok_stol3.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol3.GetComponent<SpriteRenderer>().sprite = prostokat;
                widok_stol4.transform.position = new Vector3(731.2f, 247.2f, 0.0f);
                widok_stol4.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol4.GetComponent<SpriteRenderer>().sprite = prostokat;
                widok_stol5.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol5.GetComponent<SpriteRenderer>().sprite = prostokat;
                widok_stol6.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol6.GetComponent<SpriteRenderer>().sprite = prostokat;
                widok_stol7.transform.localScale = new Vector3(24.0f, 24.0f, 1.0f);
                widok_stol7.GetComponent<SpriteRenderer>().sprite = prostokat;
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
                podstawowa_ilosc_osob = 2;
                widok_stol1.transform.position = new Vector3(428.3f, 135.0f, 0.0f);
                widok_stol1.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol1.GetComponent<SpriteRenderer>().sprite = okragly70;
                widok_stol2.transform.position = new Vector3(628.6f, 135.0f, 0.0f);
                widok_stol2.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol2.GetComponent<SpriteRenderer>().sprite = okragly70;
                widok_stol3.transform.position = new Vector3(529.9f, 209.5f, 0.0f);
                widok_stol3.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol3.GetComponent<SpriteRenderer>().sprite = okragly70;
                widok_stol4.transform.position = new Vector3(747.6f, 209.5f, 0.0f);
                widok_stol4.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol4.GetComponent<SpriteRenderer>().sprite = okragly70;
                widok_stol5.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol5.GetComponent<SpriteRenderer>().sprite = okragly70;
                widok_stol6.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol6.GetComponent<SpriteRenderer>().sprite = okragly70;
                widok_stol7.transform.localScale = new Vector3(13.0f, 13.0f, 1.0f);
                widok_stol7.GetComponent<SpriteRenderer>().sprite = okragly70;
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
                podstawowa_ilosc_osob = 4;
                widok_stol1.transform.position = new Vector3(416.7f, 131.2f, 0.0f);
                widok_stol1.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol1.GetComponent<SpriteRenderer>().sprite = okragly90;
                widok_stol2.transform.position = new Vector3(629.6f, 131.2f, 0.0f);
                widok_stol2.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol2.GetComponent<SpriteRenderer>().sprite = okragly90;
                widok_stol3.transform.position = new Vector3(529.0f, 214.4f, 0.0f);
                widok_stol3.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol3.GetComponent<SpriteRenderer>().sprite = okragly90;
                widok_stol4.transform.position = new Vector3(745.7f, 214.4f, 0.0f);
                widok_stol4.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol4.GetComponent<SpriteRenderer>().sprite = okragly90;
                widok_stol5.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol5.GetComponent<SpriteRenderer>().sprite = okragly90;
                widok_stol6.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol6.GetComponent<SpriteRenderer>().sprite = okragly90;
                widok_stol7.transform.localScale = new Vector3(14.0f, 14.0f, 1.0f);
                widok_stol7.GetComponent<SpriteRenderer>().sprite = okragly90;
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
            tables_all.SetActive(false);
            widok_stol_all.SetActive(true);
            scena4.SetActive(false);
            scena6.SetActive(true);
            licznik_scen++;
        }
    }

    string ustawienie_stolu;

    public void wybor_ustawienie_stolow()
    {
        //        widok_stol5.SetActive(false);
        //        widok_stol6.SetActive(false);
        //        widok_stol7.SetActive(false);
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        ustawienie_stolu = tekst.ToString();
        Debug.Log(tekst);
        bool czy_ok = false;
        if (tekst == "Pojedyncze stoly")
        {
            if (ustawienie_warunki() == true)
            {
                dodatkowa_ilosc_osob = 0;
                dodatkowa_ilosc_stolow = 0;
                widok_stol5.SetActive(false);
                widok_stol6.SetActive(false);
                widok_stol7.SetActive(false);
                if (nazwa_stolu_tmp == "Stol kwadratowy")
                {
                    widok_stol1.transform.position = new Vector3(411.0f, 144.6f, 0.0f);
                    widok_stol2.transform.position = new Vector3(622.25f, 144.6f, 0.0f);
                    widok_stol3.transform.position = new Vector3(514.25f, 218.1f, 0.0f);
                    widok_stol4.transform.position = new Vector3(734.0f, 218.1f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol prostokatny")
                {
                    widok_stol1.transform.position = new Vector3(415.8f, 168.8f, 0.0f);
                    widok_stol2.transform.position = new Vector3(648.8f, 168.8f, 0.0f);
                    widok_stol3.transform.position = new Vector3(519.3f, 247.2f, 0.0f);
                    widok_stol4.transform.position = new Vector3(731.2f, 247.2f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 70")
                {
                    widok_stol1.transform.position = new Vector3(428.3f, 135.0f, 0.0f);
                    widok_stol2.transform.position = new Vector3(628.6f, 135.0f, 0.0f);
                    widok_stol3.transform.position = new Vector3(529.9f, 209.5f, 0.0f);
                    widok_stol4.transform.position = new Vector3(747.6f, 209.5f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 90")
                {
                    widok_stol1.transform.position = new Vector3(416.7f, 131.2f, 0.0f);
                    widok_stol2.transform.position = new Vector3(629.6f, 131.2f, 0.0f);
                    widok_stol3.transform.position = new Vector3(529.0f, 214.4f, 0.0f);
                    widok_stol4.transform.position = new Vector3(745.7f, 214.4f, 0.0f);
                }
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
                dodatkowa_ilosc_osob = 6;
                dodatkowa_ilosc_stolow = 2;
                widok_stol5.SetActive(false);
                widok_stol6.SetActive(false);
                widok_stol7.SetActive(false);
                if (nazwa_stolu_tmp == "Stol kwadratowy")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(424.5f, 180.5f, 0.0f);
                    widok_stol2.transform.position = new Vector3(483.87f, 175.45f, 0.0f);
                    widok_stol3.transform.position = new Vector3(541.17f, 170.05f, 0.0f);
                    widok_stol4.transform.position = new Vector3(598.27f, 165.55f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol prostokatny")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(502.0f, 193.9f, 0.0f);
                    widok_stol2.transform.position = new Vector3(526.8f, 184.5f, 0.0f);
                    widok_stol3.transform.position = new Vector3(556.6f, 172.7f, 0.0f);
                    widok_stol4.transform.position = new Vector3(588.0f, 161.8f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 70")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(742.7f, 174.1f, 0.0f);
                    widok_stol2.transform.position = new Vector3(638.9f, 172.3f, 0.0f);
                    widok_stol3.transform.position = new Vector3(539.3f, 168.2f, 0.0f);
                    widok_stol4.transform.position = new Vector3(440.8f, 166.9f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 90")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(778.6f, 174.1f, 0.0f);
                    widok_stol2.transform.position = new Vector3(669.6f, 172.3f, 0.0f);
                    widok_stol3.transform.position = new Vector3(557.9f, 168.2f, 0.0f);
                    widok_stol4.transform.position = new Vector3(440.8f, 166.9f, 0.0f);
                }
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
                dodatkowa_ilosc_osob = 10;
                dodatkowa_ilosc_stolow = 4;
                widok_stol5.SetActive(true);
                widok_stol6.SetActive(false);
                widok_stol7.SetActive(false);
                if (nazwa_stolu_tmp == "Stol kwadratowy")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(502.0f, 193.9f, 0.0f);
                    widok_stol2.transform.position = new Vector3(558.3f, 188.9f, 0.0f);
                    widok_stol3.transform.position = new Vector3(615.3f, 183.0f, 0.0f);
                    widok_stol4.transform.position = new Vector3(518.2f, 175.8f, 0.0f);
                    widok_stol5.transform.position = new Vector3(477.9f, 164.1f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol prostokatny")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(570.5f, 219.8f, 0.0f);
                    widok_stol2.transform.position = new Vector3(608.7f, 205.6f, 0.0f);
                    widok_stol3.transform.position = new Vector3(646.0f, 190.5f, 0.0f);
                    widok_stol4.transform.position = new Vector3(560.1f, 201.7f, 0.0f);
                    widok_stol5.transform.position = new Vector3(512.1f, 196.6f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 70")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(593.1f, 192.2f, 0.0f);
                    widok_stol2.transform.position = new Vector3(662.2f, 183.2f, 0.0f);
                    widok_stol3.transform.position = new Vector3(727.8f, 173.8f, 0.0f);
                    widok_stol4.transform.position = new Vector3(587.6f, 177.5f, 0.0f);
                    widok_stol5.transform.position = new Vector3(501.3f, 173.2f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 90")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(554.8f, 192.2f, 0.0f);
                    widok_stol2.transform.position = new Vector3(650.6f, 183.9f, 0.0f);
                    widok_stol3.transform.position = new Vector3(750.4f, 173.8f, 0.0f);
                    widok_stol4.transform.position = new Vector3(563.5f, 172.5f, 0.0f);
                    widok_stol5.transform.position = new Vector3(481.4f, 161.6f, 0.0f);
                }
                czy_ok = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (tekst == "Litera U")
        {
            dodatkowa_ilosc_osob = 6;
            dodatkowa_ilosc_stolow = 2;
            if (ustawienie_warunki() == true)
            {
                widok_stol5.SetActive(true);
                widok_stol6.SetActive(false);
                widok_stol7.SetActive(false);
                if (nazwa_stolu_tmp == "Stol kwadratowy")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(516.0f, 216.8f, 0.0f);
                    widok_stol2.transform.position = new Vector3(573.6f, 213.3f, 0.0f);
                    widok_stol3.transform.position = new Vector3(637.6f, 209.6f, 0.0f);
                    widok_stol4.transform.position = new Vector3(470.5f, 207.4f, 0.0f);
                    widok_stol5.transform.position = new Vector3(601.3f, 195.7f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol prostokatny")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(666.0f, 218.4f, 0.0f);
                    widok_stol2.transform.position = new Vector3(611.7f, 216.5f, 0.0f);
                    widok_stol3.transform.position = new Vector3(554.2f, 215.9f, 0.0f);
                    widok_stol4.transform.position = new Vector3(723.0f, 201.0f, 0.0f);
                    widok_stol5.transform.position = new Vector3(590.9f, 199.7f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 70")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(666.0f, 218.4f, 0.0f);
                    widok_stol2.transform.position = new Vector3(568.9f, 215.7f, 0.0f);
                    widok_stol3.transform.position = new Vector3(472.4f, 212.7f, 0.0f);
                    widok_stol4.transform.position = new Vector3(738.0f, 208.9f, 0.0f);
                    widok_stol5.transform.position = new Vector3(536.9f, 202.9f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 90")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(666.8f, 218.4f, 0.0f);
                    widok_stol2.transform.position = new Vector3(553.8f, 215.7f, 0.0f);
                    widok_stol3.transform.position = new Vector3(452.6f, 212.7f, 0.0f);
                    widok_stol4.transform.position = new Vector3(738.0f, 205.7f, 0.0f);
                    widok_stol5.transform.position = new Vector3(506.0f, 195.8f, 0.0f);
                }
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
                dodatkowa_ilosc_osob = 10;
                dodatkowa_ilosc_stolow = 4;
                widok_stol5.SetActive(true);
                widok_stol6.SetActive(true);
                widok_stol7.SetActive(true);
                if (nazwa_stolu_tmp == "Stol kwadratowy")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(600.9f, 218.4f, 0.0f);
                    widok_stol2.transform.position = new Vector3(559.3f, 204.6f, 0.0f);
                    widok_stol3.transform.position = new Vector3(516.8f, 193.7f, 0.0f);
                    widok_stol4.transform.position = new Vector3(653.9f, 213.7f, 0.0f);
                    widok_stol5.transform.position = new Vector3(473.4f, 182.3f, 0.0f);
                    widok_stol6.transform.position = new Vector3(598.0f, 195.0f, 0.0f);
                    widok_stol7.transform.position = new Vector3(528.2f, 172.8f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol prostokatny")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(579.4f, 243.0f, 0.0f);
                    widok_stol2.transform.position = new Vector3(624.3f, 227.6f, 0.0f);
                    widok_stol3.transform.position = new Vector3(665.9f, 210.4f, 0.0f);
                    widok_stol4.transform.position = new Vector3(707.8f, 194.7f, 0.0f);
                    widok_stol5.transform.position = new Vector3(523.3f, 241.0f, 0.0f);
                    widok_stol6.transform.position = new Vector3(587.7f, 219.6f, 0.0f);
                    widok_stol7.transform.position = new Vector3(654.3f, 186.2f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 70")
                {
                    podstawowa_ilosc_osob = 2;
                    widok_stol1.transform.position = new Vector3(724.7f, 218.4f, 0.0f);
                    widok_stol2.transform.position = new Vector3(612.5f, 215.7f, 0.0f);
                    widok_stol3.transform.position = new Vector3(511.3f, 212.7f, 0.0f);
                    widok_stol4.transform.position = new Vector3(796.7f, 208.9f, 0.0f);
                    widok_stol5.transform.position = new Vector3(396.5f, 207.7f, 0.0f);
                    widok_stol6.transform.position = new Vector3(448.1f, 193.4f, 0.0f);
                    widok_stol7.transform.position = new Vector3(618.6f, 205.3f, 0.0f);
                }
                else if (nazwa_stolu_tmp == "Stol okragly 90")
                {
                    podstawowa_ilosc_osob = 3;
                    widok_stol1.transform.position = new Vector3(724.7f, 218.4f, 0.0f);
                    widok_stol2.transform.position = new Vector3(612.5f, 215.7f, 0.0f);
                    widok_stol3.transform.position = new Vector3(511.3f, 212.7f, 0.0f);
                    widok_stol4.transform.position = new Vector3(796.7f, 205.7f, 0.0f);
                    widok_stol5.transform.position = new Vector3(396.5f, 207.7f, 0.0f);
                    widok_stol6.transform.position = new Vector3(448.1f, 190.2f, 0.0f);
                    widok_stol7.transform.position = new Vector3(618.6f, 201.3f, 0.0f);
                }
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
            scena5.SetActive(true);
            licznik_scen++;
        }
    }

    bool ustawienie_warunki()
    {
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (ustawienie_stolu == "Pojedyncze stoly")
            {
                return true;
            }
        }
        else if (nazwa_uroczystosci == "Wesele")
        {
            if (ustawienie_stolu == "Blok" || ustawienie_stolu == "Litera U")
            {
                return true;
            }
        }
        else if (nazwa_uroczystosci != "")
        {
            int x = 0;
            x = int.Parse(ilosc_osob_l);
            if (nazwa_stolu_tmp == "Stol kwadratowy" || nazwa_stolu_tmp == "Stol okragly 70")
            {
                if (x < 10 & ustawienie_stolu == "Litera T")
                {
                    return false;
                }
                else if (x < 12 & ustawienie_stolu == "Litera U")
                {
                    return false;
                }
                else if (x < 18 & ustawienie_stolu == "Litera E")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (nazwa_stolu_tmp == "Stol prostokatny" || nazwa_stolu_tmp == "Stol okragly 90")
            {
                if (x < 9 & ustawienie_stolu == "Blok")
                {
                    return false;
                }
                else if (x < 13 & ustawienie_stolu == "Litera T")
                {
                    return false;
                }
                else if (x < 18 & ustawienie_stolu == "Litera U")
                {
                    return false;
                }
                else if (x < 30 & ustawienie_stolu == "Litera E")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        return false;
    }

    bool ilosc_stolow_dalej;
    int wynik_tmp;
    int wynik_tmp2;
    public void get_ilosc_stolow()
    {
        string ile_stolow;
        int ile_stolow_tmp;
        int ilosc_osob_tmp;
        ile_stolow = ilosc_stolow_get.text;
        ilosc_stolow_dalej = false;
        Scene obecna_scena = SceneManager.GetActiveScene();
        string nazwa_sceny = obecna_scena.name;
        int.TryParse(ilosc_osob_l, out ilosc_osob_tmp);
        int.TryParse(ile_stolow, out ile_stolow_tmp);

        if (nazwa_sceny == "2Poziom1")
        {
            wynik_tmp = podstawowa_ilosc_osob * (ile_stolow_tmp - dodatkowa_ilosc_stolow) + dodatkowa_ilosc_osob;
            wynik_tmp2 = podstawowa_ilosc_osob * (ile_stolow_tmp - dodatkowa_ilosc_stolow - 1) + dodatkowa_ilosc_osob;
        }
        else if (nazwa_sceny == "2Poziom2")
        {
            if (typ_przyjecia_string == "Angielskie")
            {
                wynik_tmp = (podstawowa_ilosc_osob + 1) * (ile_stolow_tmp - dodatkowa_ilosc_stolow) + dodatkowa_ilosc_osob;
                wynik_tmp2 = (podstawowa_ilosc_osob + 1) * (ile_stolow_tmp - dodatkowa_ilosc_stolow - 1) + dodatkowa_ilosc_osob;
            }
            else
            {
                wynik_tmp = podstawowa_ilosc_osob * (ile_stolow_tmp - dodatkowa_ilosc_stolow) + dodatkowa_ilosc_osob;
                wynik_tmp2 = podstawowa_ilosc_osob * (ile_stolow_tmp - dodatkowa_ilosc_stolow - 1) + dodatkowa_ilosc_osob;
            }
        }
        Debug.Log(ilosc_osob_tmp);
        Debug.Log(wynik_tmp);
        Debug.Log(wynik_tmp2);
        if (ilosc_osob_tmp <= wynik_tmp && ilosc_osob_tmp > wynik_tmp2)
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
        else if (nazwa_uroczystosci == "Wesele")
        {
            if (nazwa_stolu_tmp == "Stol kwadratowy" || nazwa_stolu_tmp == "Stol prostokatny")
            {
                return true;
            }
        }
        else if (nazwa_uroczystosci != "")
        {
            int x = 0;
            x = int.Parse(ilosc_osob_l);
            if (nazwa_stolu_tmp == "Stol okragly 70" || nazwa_stolu_tmp == "Stol okragly 90")
            {
                if (x <= 100)
                {
                    return true;
                }
            }
            else
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
        if (licznik_scen == 3)
        {
            pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybierając uroczystosc " + nazwa_uroczystosci + " dla " + ilosc_osob_l + " osób powinienieś wybrać salę, która będzie odpowiednia dla tego wydarzenia oraz przede wszystkim najlepiej wykorzystane dostepne miejsce. Za pomoc utraciłeś 1 punkt.";
        }
        if (licznik_scen == 4)
        {
            pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybierając uroczystość " + nazwa_uroczystosci + " dla " + ilosc_osob_l + "osób, pamiętaj o dobrze odpowiedniego stolika. Rozdysponuj stolikami tak, aby najlepiej pomieścić osoby. Pamiętaj również, że do niektórych typów wydarzeń, niektóre stoły się nie nadaja. Za pomoc tracisz 1 punkt.";
        }
        if (licznik_scen == 6)
        {
            pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybrałeś uroczystość " + nazwa_uroczystosci + " dla " + ilosc_osob_l + "osób. Pamiętaj, że w zależności od ustawienia stołu masz dodatkowo miejsca na stole. Miejsce dla jednego konsumenta,na przyjęciu zasiadanym powinno wynosić od 60-75cm. Odleglosc pierwszego nakrycia od krawedzi stolu od 45-55cm. Obecnie, według Twojego ustawienia starczy miejsca na od " + (wynik_tmp2 + 1) + " do " + wynik_tmp + " osob!";
        }
        if (licznik_scen == 5)
        {
            pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Wybraleś uroczystość " + nazwa_uroczystosci + ". Pamiętaj o tym, aby ułożenie było najbardziej odpowiednie do okoliczności, a przede wszystkim... najlepiej pod wzgledem wybranej ilosci osob oraz wielkosci sali";
        }
        if (licznik_scen == 7)
        {
            if (obrus_chec == false)                {
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Na wybrany przez Ciebie stół " + nazwa_stolu_tmp + " powinienieś wybrać inny obrus. Zastanów się nad tym i spróbuj poprawić!";
            }
            else if (Dekoracje3.isOn == true && nazwa_uroczystosci == "Walentynki" || nazwa_uroczystosci == "Stypa")
            { //to nie mam ogólne, tylko na walentynki
                pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Na wybraną przez Ciebie uroczystość " + nazwa_uroczystosci + " powinienieś wybrać bardziej dogodne dekoracje, które wprowadzą elementy romatyczne";                
            }
        }
        if (licznik_scen == 8)
        {
            menu.SetActive(false);
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
        if (licznik_scen == 11)
        {
            pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Dla wybranego " + nazwa_menu + " wybrane przez Ciebie elementy są błędną lub niekompletne. Zobacz jeszcze raz na menu, a następnie ponownie skup się nad przygotowaniem szklanej zastawy. Wszystko masz w menu :) Dodatkowo im większa szklanka tym bardziej na prawo.";
        }
        if (licznik_scen == 12)
        {
            pomoc_text.GetComponent<UnityEngine.UI.Text>().text = "Dla wybranego " + nazwa_menu + " wybrane przez Ciebie elementy są błędną lub niekompletne. Zobacz jeszcze raz na menu, a następnie ponownie skup się nad przygotowaniem sztuccy. Pamiętaj, całość odpowiedzi masz w menu. Dodatkowo pamiętaj po prawej stronie masz takie sztucce, ktore wybierzesz pierwsze. Jaka potrawe podasz najpierw? :) ";
        }
    }

    public void zamknij_pomoc()
    {
        ksiazka_scena.SetActive(false);
        if (scena5_input.activeSelf == false)
        {
            scena5_input.SetActive(true);
        }
        if (licznik_scen == 8)
        {
            scena8.SetActive(true);
        }
    }

    public GameObject scena5_input;

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
        if (scena5.activeSelf == true)
        {
            scena5_input.SetActive(false);
        }
        if (scena8.activeSelf == true)
        {
            menu.SetActive(true);
        }
        StartCoroutine(Blad_wait());
    }

    IEnumerator Blad_wait()
    {
        yield return new WaitForSeconds(3);
        blad.SetActive(false);
        if (scena5.activeSelf == true)
        {
            if (ksiazka_scena.activeSelf == false)
            {
                scena5_input.SetActive(true);
            }
        }
    }

    public void zapisz_scena_stol()
    {
        if (ilosc_stolow_dalej == true)
        {
            licznik_scen++;
            scena5.SetActive(false);
            scena7.SetActive(true);
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
        if (nazwa_uroczystosci == "Walentynki" || nazwa_uroczystosci == "Stypa")
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
                powiadomienie_blad();
                return false;
            }
        }
        else if (nazwa_uroczystosci == "Wesele")
        {
            if (Dekoracje3.isOn == true)
            {
                ilosc_punktow = ilosc_punktow + 1;
                punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                byl_punkt_dekoracje = true;
                return true;
            }
        }
        return true;
    }
    int licznik_punkty;
    public void zatwierdz_bielizna()
    {
        menu.SetActive(false);
        menu_zatwierdz.SetActive(false);
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

    string nazwa_menu;
    public GameObject menu_teskst;

    public void sprawdz_menu()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;
        nazwa_menu = tekst.ToString();
        //        nazwa_sali = tekst.ToString();
        Debug.Log(tekst);
        menu.SetActive(true);
        menu_zatwierdz.SetActive(true);
        if (tekst == "Romantyczna kolacja")
        {
            menu_teskst.GetComponent<UnityEngine.UI.Text>().text = "<b><size=17>MENU: \n ROMANTYCZKA KOLACJA </size>\n \n ZUPA \n Rosol</b> \n <i><size=12>- z musem z białych warzyw i jabłka \n - z puree z zielonego gorszku \n - z masłem szałwiowym</size></i> \n \n <b>DANIE GŁÓWNE \n Polędwica z tuńczyka </b>\n <i><size=12>- z sosem z syropu klonowego i sosu sojowego \n - w sezamie na orientalnej sałatwce z mango i kolendra </size></i>\n \n <b>DESER \n Suflet </b>\n <i><size=12>- waniliowy z pomarańczą \n - czekoladowo - kokosowy \n - z białą czekaldą i malinami</size></i> \n \n <b>NAPOJE \n Wino czerwone \n Wino białe</b>";
        }
        else if (tekst == "Menu codzienne")
        {
            menu_teskst.GetComponent<UnityEngine.UI.Text>().text = "<b><size=17>MENU: \n MENU CODZIENNE</size> \n \n ZUPA \n Serowa</b> \n <i><size=12>ciepłe tosty, parmezan</size></i> \n \n <b>Rosół</b> \n <i><size=12> - z makaronem \n - ręcznie lepionymi kołdunami </size></i> \n \n <b>DANIE GŁÓWNE \n Tradycyjny kotlet schabowy</b> \n <i><size=12>kapusta zasmażana, ziemniaki</size></i> \n \n <b>DESER \n Sernik </b>\n <i><size=12>- z wiśniami \n - z lodami waniliowymi \n </size></i> \n <b>NAPOJE \n Sok </b> \n <i><size=12> - pomaranczowy \n - jablkowy </size></i> \n \n <b>Herbata</b>";
        }
        else if (tekst == "Obiad wystawny")
        {
            menu_teskst.GetComponent<UnityEngine.UI.Text>().text = "<b><size=17>MENU: \n OBIAD WYSTAWNY</size> \n \n ZUPA </b> \n <b>Rosół</b> \n <i><size=12> - z makaronem \n - ręcznie lepionymi kołdunami </size></i> \n \n <b>DANIE GŁÓWNE \n Polędwica z kurczaka </b>\n <i><size=12>- z sosem botwinkowym \n - w kremowym sosie ze szparagami \n - w sosie z whiksy </size></i>\n \n <b>DESER \n Suflet </b>\n <i><size=12>- waniliowy z pomarańczą \n - czekoladowo - kokosowy \n - z białą czekaldą i malinami</size></i> \n \n <b>NAPOJE \n Wino czerwone \n Wino białe \n Whisky </b>";
        }
        else if (tekst == "Oferta rozszerzona")
        {
            menu_teskst.GetComponent<UnityEngine.UI.Text>().text = "<b><size=17>MENU: \n OFERTA ROZSZERZONA \n \n </size></b> \n \n Menu zawiera: \n - zupe \n - dane glowne \n - przystawke \n - kolacje \n - wybor alkoholi \n - wybor napojow \n \n <i>Do wybrania menu prosze o kontakt z klientem ws. calosciowego ustalenia wszystkich dan </i>";
        }
    }

    public void zatwiedz_menu()
    {
        bool czy_kolejna = false;
        if (nazwa_menu == "Romantyczna kolacja")
        {
            if (menu_warunki() == true)
            {
                //jeżeli kilka to dodać ifa z boolenem, że już wykorzystane (podczas cofania)
                czy_kolejna = true;
            }
            else
            {
                menu.SetActive(false);
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Menu codzienne")
        {
            if (menu_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                menu.SetActive(false);
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Obiad wystawny")
        {
            if (menu_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                menu.SetActive(false);
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Oferta rozszerzona")
        {
            if (menu_warunki() == true)
            {
                czy_kolejna = true;
            }
            else
            {
                menu.SetActive(false);
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
        else
        {
            menu.SetActive(false);
        }
    }

    bool menu_warunki()
    {
        Debug.Log("JESTEM 2");
        if (nazwa_uroczystosci == "Walentynki")
        {
            if (nazwa_menu == "Romantyczna kolacja")
            {
                return true;
            }
        }
        else if (nazwa_uroczystosci == "Urodziny" || nazwa_uroczystosci == "Imieniny")
        {
            if (nazwa_menu == "Menu codzienne")
            {
                return true;
            }
        }
        else if (nazwa_uroczystosci == "Stypa" || nazwa_uroczystosci == "Wielkanoc")
        {
            if (nazwa_menu == "Obiad wystawny")
            {
                return true;
            }
        }
        else if (nazwa_uroczystosci == "Wesele" || nazwa_uroczystosci == "Spotkanie biznesowe")
        {
            if (nazwa_menu == "Oferta rozszerzona" || nazwa_menu == "Obiad wystawny")
            {
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


    public void aktywne_toggle_off(InputField aktywnosc)
    {
        if (aktywnosc.interactable == false)
        {
            aktywnosc.interactable = true;
        }
        else
        {
            aktywnosc.interactable = false;
            aktywnosc.text = "";
        }
    } 

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
//    public Toggle ceramika11;
    public GameObject scena11_srodek_proste;
    public GameObject scena11_srodek_rozszerzone;
    bool nastepna_scena_ceramika;
    public void ceramika_sprawdzian()
    {
        nastepna_scena_ceramika = false;
        if (nazwa_menu == "Romantyczna kolacja")
        {
            if (talerz1.isOn == true && talerz2.isOn == true && ceramika3.isOn == true && ceramika7.isOn == true && ceramika4.isOn == false && ceramika5.isOn == false && ceramika6.isOn == false && ceramika8.isOn == false && ceramika9.isOn == false && ceramika10.isOn == false)
            {
                ilosc_punktow = ilosc_punktow + 2;
                nastepna_scena_ceramika = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Menu codzienne")
        {
            if (talerz1.isOn == true && talerz2.isOn == true && ceramika3.isOn == true && ceramika8.isOn == true && ceramika9.isOn == true && ceramika4.isOn == false && ceramika5.isOn == false && ceramika6.isOn == false && ceramika7.isOn == false && ceramika10.isOn == false)
            {
                ilosc_punktow = ilosc_punktow + 2;
                nastepna_scena_ceramika = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Obiad wystawny")
        {
            if (talerz1.isOn == true && talerz2.isOn == true && ceramika3.isOn == true && ceramika5.isOn == true && ceramika7.isOn == true && ceramika4.isOn == false && ceramika6.isOn == false && ceramika8.isOn == false && ceramika9.isOn == false && ceramika10.isOn == false)
            {
                ilosc_punktow = ilosc_punktow + 2;
                nastepna_scena_ceramika = true;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Oferta rozszerzona")
        {
            Debug.Log("ZOOOOOOOOOOOOOOOOOOOOOOOMBIE");
            if (talerz2.isOn == true && ceramika3.isOn == true && ceramika4.isOn == true && ceramika8.isOn == true && ceramika9.isOn == true && talerz1.isOn == false && ceramika5.isOn == false && ceramika6.isOn == false && ceramika7.isOn == false && ceramika10.isOn == false)
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
            widok_stol_all.SetActive(false);
            widok_sali.GetComponent<SpriteRenderer>().sprite = widok_podloga;
            if (nazwa_menu == "Romantyczna kolacja" || nazwa_menu == "Menu codzienne")
            {
                scena11_srodek_proste.SetActive(true);
            }
            else
            {
                scena11_srodek_rozszerzone.SetActive(true);
            }
            
        }
    }

    public InputField szklo1;
    public InputField szklo2;
    public InputField szklo3;
    public InputField szklo4;
    public InputField szklo5;
    public InputField szklo6;
    public InputField szklo7;
    public InputField szklo8;
//    public InputField szklo9;

    public Toggle szklo11;
    public Toggle szklo22;
    public Toggle szklo33;

    public void toggle_blokuj_szklo()
    {
        if (scena11_srodek_proste.activeSelf == true)
        {
            if (szklo11.isOn == true)
            {
                szklo22.interactable = false;
                szklo33.interactable = false;
            }
            else if (szklo22.isOn == true)
            {
                szklo11.interactable = false;
                szklo33.interactable = false;
            }
            else if (szklo33.isOn == true)
            {
                szklo11.interactable = false;
                szklo22.interactable = false;
            }
            else
            {
                szklo11.interactable = true;
                szklo22.interactable = true;
                szklo33.interactable = true;
            }
        }
    }

    public InputField sztucce1;
    public InputField sztucce2;
    public InputField sztucce3;
    public InputField sztucce4;
    public InputField sztucce5;
    public InputField sztucce6;
    public InputField sztucce7;
    public InputField sztucce8;

    public void block_object(GameObject obiektt)
    {
        if (obiektt.activeSelf == true)
        {
            obiektt.SetActive(false);
        }
        else
        {
            obiektt.SetActive(true);
        }
    }

    public GameObject cat;
    public GameObject ghost;
    public GameObject[] szklo_game;
    public InputField[] szklo_input;
    public Toggle[] szklo_toggle;
    int y;
    IEnumerator Timewiat()
    {
        yield return new WaitForSeconds(1);
        cat.SetActive(false);
        ghost.SetActive(false);
    }

    public void szklo_wyswietl_proste()
    {
     //   szklo_input[y].text = "";
        //   cat.SetActive(false);
        //   ghost.SetActive(false);
        int x = Random.Range(0, 15);
        y = Random.Range(1, 8);
        int yy = 0;
        Debug.Log("DZIEL" + x%4);
        Debug.Log("YYYYYYYYYYYYYYYY" + y);
        
        if (scena11_srodek_proste.activeSelf == true)
        {
            yy = Random.Range(1, 6);
            obiekt_wyswietl_proste(szklo_game[0], szklo_input[0].text);
            obiekt_wyswietl_proste(szklo_game[1], szklo_input[1].text);
            obiekt_wyswietl_proste(szklo_game[2], szklo_input[2].text);
            obiekt_wyswietl_proste(szklo_game[3], szklo_input[3].text);
            obiekt_wyswietl_proste(szklo_game[4], szklo_input[4].text);
            obiekt_wyswietl_proste(szklo_game[5], szklo_input[5].text);
            obiekt_wyswietl_proste(szklo_game[6], szklo_input[6].text);
            obiekt_wyswietl_proste(szklo_game[7], szklo_input[7].text);
            if (x % 4 == 0)
            {
                if (y % 2 == 0)
                {
                    Debug.Log("KOT ACTIVE " + y % 2);
                    cat.SetActive(true);
                }
                else if (y % 2 == 1)
                {
                    Debug.Log("DUCH ACTIVE: " + y % 2);
                    ghost.SetActive(true);
                }
                if (szklo_toggle[y].isOn == true)
                {
                    szklo_toggle[y].isOn = false;
                }
                else
                {
                    szklo_toggle[y].isOn = true;
                    if (szklo_game[y].activeSelf == false)
                    {
                        szklo_game[y].SetActive(true);
                    }
                    Debug.Log("SZKLO KOT JESTEM");
                    obiekt_wyswietl_proste(szklo_game[y], yy.ToString());
                    szklo_input[y].text = yy.ToString();
                    StartCoroutine(Timewiat());
                }
            }
        }
        else if (scena11_srodek_rozszerzone.activeSelf == false)
        {
            yy = Random.Range(1, 9);
            obiekt_wyswietl_rozszerzone(szklo_game[0], szklo_input[0].text);
            obiekt_wyswietl_rozszerzone(szklo_game[1], szklo_input[1].text);
            obiekt_wyswietl_rozszerzone(szklo_game[2], szklo_input[2].text);
            obiekt_wyswietl_rozszerzone(szklo_game[3], szklo_input[3].text);
            obiekt_wyswietl_rozszerzone(szklo_game[4], szklo_input[4].text);
            obiekt_wyswietl_rozszerzone(szklo_game[5], szklo_input[5].text);
            obiekt_wyswietl_rozszerzone(szklo_game[6], szklo_input[6].text);
            obiekt_wyswietl_rozszerzone(szklo_game[7], szklo_input[7].text);
            if (x % 4 == 0)
            {
                if (y % 2 == 0)
                {
                    Debug.Log("KOT ACTIVE " + y % 2);
                    cat.SetActive(true);
                }
                else if (y % 2 == 1)
                {
                    Debug.Log("DUCH ACTIVE: " + y % 2);
                    ghost.SetActive(true);
                }
                if (szklo_toggle[y].isOn == true)
                {
                    szklo_toggle[y].isOn = false;
                }
                else
                {
                    szklo_toggle[y].isOn = true;
                    if (szklo_game[y].activeSelf == false)
                    {
                        szklo_game[y].SetActive(true);
                    }
                    Debug.Log("SZKLO KOT JESTEM");
                    obiekt_wyswietl_rozszerzone(szklo_game[y], yy.ToString());
                    szklo_input[y].text = yy.ToString();
                    StartCoroutine(Timewiat());
                }
            }
        }
    }

    public GameObject[] sztucce_game;
    public InputField[] sztucce_input;
    public Toggle[] sztucce_toggle;

    public void sztucce_wyswietl_proste()
    {
    //    szklo_input[y].text = "";
        int x = Random.Range(0, 15);
        y = Random.Range(1, 8);
        int yy = 0;
        Debug.Log("DZIEL" + x % 4);
        Debug.Log(y);
        if (scena11_srodek_proste.activeSelf == true)
        {
            yy = Random.Range(1, 6);
            obiekt_wyswietl_proste(sztucce_game[0], sztucce_input[0].text);
            obiekt_wyswietl_proste(sztucce_game[1], sztucce_input[1].text);
            obiekt_wyswietl_proste(sztucce_game[2], sztucce_input[2].text);
            obiekt_wyswietl_proste(sztucce_game[3], sztucce_input[3].text);
            obiekt_wyswietl_proste(sztucce_game[4], sztucce_input[4].text);
            obiekt_wyswietl_proste(sztucce_game[5], sztucce_input[5].text);
            obiekt_wyswietl_proste(sztucce_game[6], sztucce_input[6].text);
            obiekt_wyswietl_proste(sztucce_game[7], sztucce_input[7].text);
            if (x % 4 == 0)
            {
                if (y % 2 == 0)
                {
                    Debug.Log("KOT ACTIVE " + y % 2);
                    cat.SetActive(true);
                }
                else if (y % 2 == 1)
                {
                    Debug.Log("DUCH ACTIVE: " + y % 2);
                    ghost.SetActive(true);
                }
                if (sztucce_toggle[y].isOn == true)
                {
                    sztucce_toggle[y].isOn = false;
                }
                else
                {
                    sztucce_toggle[y].isOn = true;
                    if (sztucce_game[y].activeSelf == false)
                    {
                        sztucce_game[y].SetActive(true);
                    }
                    Debug.Log("SZKLO KOT JESTEM");
                    obiekt_wyswietl_proste(sztucce_game[y], yy.ToString());
                    sztucce_input[y].text = yy.ToString();
                    StartCoroutine(Timewiat());
                }
            }
        }
        else if (scena11_srodek_rozszerzone.activeSelf == false)
        {
            yy = Random.Range(1, 9);
            obiekt_wyswietl_rozszerzone(sztucce_game[0], sztucce_input[0].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[1], sztucce_input[1].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[2], sztucce_input[2].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[2], sztucce_input[3].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[4], sztucce_input[4].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[5], sztucce_input[5].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[6], sztucce_input[6].text);
            obiekt_wyswietl_rozszerzone(sztucce_game[7], sztucce_input[7].text);
            if (x % 4 == 0)
            {
                if (y % 2 == 0)
                {
                    Debug.Log("KOT ACTIVE " + y % 2);
                    cat.SetActive(true);
                }
                else if (y % 2 == 1)
                {
                    Debug.Log("DUCH ACTIVE: " + y % 2);
                    ghost.SetActive(true);
                }
                if (sztucce_toggle[y].isOn == true)
                {
                    sztucce_toggle[y].isOn = false;
                }
                else
                {
                    sztucce_toggle[y].isOn = true;
                    if (sztucce_game[y].activeSelf == false)
                    {
                        sztucce_game[y].SetActive(true);
                    }
                    Debug.Log("SZKLO KOT JESTEM");
                    obiekt_wyswietl_rozszerzone(sztucce_game[y], yy.ToString());
                    sztucce_input[y].text = yy.ToString();
                    StartCoroutine(Timewiat());
                }
            }
        }
    }
    int licznik_szklo = 0;

    public void obiekt_wyswietl_proste(GameObject wyswietl, string numer)
    {
    //    Debug.Log(wyswietl);
    //    Debug.Log(numer);
        if (numer == "1")
        {
            wyswietl.transform.position = new Vector3(484.47f, 211.47f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "2")
        {
            wyswietl.transform.position = new Vector3(738.5f, 206.47f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "3")
        {
            wyswietl.transform.position = new Vector3(780.47f, 209.0f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "4")
        {
            wyswietl.transform.position = new Vector3(740.47f, 340.48f, 0.0f);
         //   wyswietl.SetActive(true);
        }
        if (numer == "5")
        {
            wyswietl.transform.position = new Vector3(781.47f, 325.48f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "6")
        {
            wyswietl.transform.position = new Vector3(618.47f, 329.98f, 0.0f);
          //  wyswietl.SetActive(true);
        }
        licznik_szklo++;
    }
    
    public void obiekt_wyswietl_rozszerzone(GameObject wyswietl, string numer)
    {
        Debug.Log(wyswietl);
        Debug.Log(numer);
        if (numer == "1")
        {
            wyswietl.transform.position = new Vector3(479.47f, 213.47f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "2")
        {
            wyswietl.transform.position = new Vector3(507.47f, 218.67f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "3")
        {
            wyswietl.transform.position = new Vector3(725.47f, 207.47f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "4")
        {
            wyswietl.transform.position = new Vector3(762.47f, 204.48f, 0.0f);
         //   wyswietl.SetActive(true);
        }
        if (numer == "5")
        {
            wyswietl.transform.position = new Vector3(796.47f, 211.48f, 0.0f);
        //    wyswietl.SetActive(true);
        }
        if (numer == "6")
        {
            wyswietl.transform.position = new Vector3(782.47f, 329.48f, 0.0f);
          //  wyswietl.SetActive(true);
        }
        if (numer == "7")
        {
            wyswietl.transform.position = new Vector3(743.47f, 340.48f, 0.0f);
          //  wyswietl.SetActive(true);
        }
        if (numer == "8")
        {
            wyswietl.transform.position = new Vector3(715.47f, 370.48f, 0.0f);
          //  wyswietl.SetActive(true);
        }
        if (numer == "9")
        {
            wyswietl.transform.position = new Vector3(618.47f, 329.97f, 0.0f);
          //  wyswietl.SetActive(true);
        }
    //    tablica[licznik_szklo] = wyswietl;
        licznik_szklo++;
    }


    public void szkolo_proste_check()
    {
        if (nazwa_menu == "Romantyczna kolacja")
        {
            if (szklo1.text == "5" || szklo2.text == "5" || szklo3.text == "5")
            {
                if (szklo4.text == "4")
                {
                    if (szklo6.interactable == false && szklo5.interactable == false && szklo7.interactable == false && szklo8.interactable == false && szklo8.interactable == false)
                    {
                        ilosc_punktow = ilosc_punktow + 2;
                        punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                        Debug.Log("JESTEM");
                        licznik_scen++;
                        licznik_szklo = 0;
                        scena11.SetActive(false);
                        scena12.SetActive(true);
                    }
                    else
                    {
                        powiadomienie_blad();
                    }

                }
                else
                {
                    powiadomienie_blad();
                }
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Menu codzienne")
        {
            if (szklo4.text == "4" && szklo6.text == "5")
            {
                if (szklo1.interactable == false && szklo2.interactable == false && szklo3.interactable == false && szklo5.interactable == false && szklo7.interactable == false && szklo8.interactable == false)
                {
                    ilosc_punktow = ilosc_punktow + 2;
                    punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                    Debug.Log("JESTEM");
                    licznik_scen++;
                    licznik_szklo = 0;
                    scena11.SetActive(false);
                    scena12.SetActive(true);
                }
                else
                {
                    powiadomienie_blad();
                }
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Obiad wystawny")
        {
            if (szklo1.text == "6" || szklo2.text == "6" || szklo3.text == "6")
            {
                if (szklo4.text == "8" && szklo7.text == "7")
                {
                    if (szklo5.interactable == false && szklo6.interactable == false && szklo8.interactable == false)
                    {
                        ilosc_punktow = ilosc_punktow + 2;
                        punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                        Debug.Log("JESTEM");
                        licznik_scen++;
                        licznik_szklo = 0;
                        scena11.SetActive(false);
                        scena12.SetActive(true);
                    }
                    else
                    {
                        powiadomienie_blad();
                    }
                }
                else
                {
                    powiadomienie_blad();
                }
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Oferta rozszerzona")
        {
            if (szklo1.text == "6" || szklo2.text == "6" || szklo3.text == "6")
            {
                if (szklo4.text == "8" || szklo6.text == "8")
                {
                    if (szklo7.text == "7")
                    {
                        if (szklo5.interactable == false && szklo8.interactable == false)
                        {
                            ilosc_punktow = ilosc_punktow + 2;
                            punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                            Debug.Log("JESTEM");
                            licznik_scen++;
                            licznik_szklo = 0;
                            scena11.SetActive(false);
                            scena12.SetActive(true);
                        }
                        else
                        {
                            powiadomienie_blad();
                        }
                    }
                    else
                    {
                        powiadomienie_blad();
                    }
                }
                else
                {
                    powiadomienie_blad();
                }
            }
            else
            {
                powiadomienie_blad();
            }
        }
    }

    public GameObject scena_win;
    public GameObject obiekty_all;
    public GameObject wyjdz_cofnij_button;

    public void sztucce_proste_chec()
    {
        if (nazwa_menu == "Romantyczna kolacja")
        {
            if (sztucce1.text == "3" && sztucce2.text == "2" && sztucce3.interactable == false && sztucce4.text == "6" && sztucce5.interactable == false && sztucce6.interactable == false && sztucce7.interactable == false && sztucce8.text == "1")
            {
                ilosc_punktow = ilosc_punktow + 3;
                punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                Debug.Log("KONIEC GRY");
                scena12.SetActive(false);
                scena_win.SetActive(true);
                scena11_srodek_rozszerzone.SetActive(false);
                scena11_srodek_proste.SetActive(false);
                wyjdz_cofnij_button.SetActive(false);
                obiekty_all.SetActive(false);
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_podloga;
                licznik_szklo = 0;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Menu codzienne")
        {
            if (sztucce1.text == "3" && sztucce2.text == "2" && sztucce3.text == "1" && sztucce4.text == "6" && sztucce5.interactable == false && sztucce6.interactable == false && sztucce7.interactable == false && sztucce8.interactable == false)
            {
                ilosc_punktow = ilosc_punktow + 3;
                punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                Debug.Log("KONIEC GRY");
                scena12.SetActive(false);
                scena_win.SetActive(true);
                scena11_srodek_rozszerzone.SetActive(false);
                scena11_srodek_proste.SetActive(false);
                wyjdz_cofnij_button.SetActive(false);
                obiekty_all.SetActive(false);
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_podloga;
                licznik_szklo = 0;
            }
            else
            {
                powiadomienie_blad();
            }
        }
        else if (nazwa_menu == "Obiad wystawny" || nazwa_menu == "Oferta rozszerzona")
        {
            if (sztucce1.text == "5" && sztucce2.text == "3" && sztucce3.text == "2" && sztucce4.text == "9" && sztucce5.text == "4" && sztucce6.interactable == false && sztucce7.text == "1" && sztucce8.interactable == false)
            {
                ilosc_punktow = ilosc_punktow + 3;
                punkty.GetComponent<UnityEngine.UI.Text>().text = ilosc_punktow.ToString();
                Debug.Log("KONIEC GRY");
                scena12.SetActive(false);
                scena_win.SetActive(true);
                scena11_srodek_rozszerzone.SetActive(false);
                scena11_srodek_proste.SetActive(false);
                wyjdz_cofnij_button.SetActive(false);
                obiekty_all.SetActive(false);
                widok_sali.GetComponent<SpriteRenderer>().sprite = widok_podloga;
                licznik_szklo = 0;
            }
            else
            {
                powiadomienie_blad();
            }
        }
    }
}