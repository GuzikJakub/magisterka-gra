using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Przycisk_zachownaie : MonoBehaviour
{
    Button przycisk;
    public GameObject tekst_uroczystosc;
    public GameObject ScenaOff;
    public GameObject ScenaOn;
    public GameObject pop_up_wyjdz;

    public void wybor_uroczystosci()
    {
        var tekst = EventSystem.current.currentSelectedGameObject.name;

        tekst_uroczystosc.SetActive(true);
        tekst_uroczystosc.GetComponent<UnityEngine.UI.Text>().text = tekst;
        ScenaOff.SetActive(false);
        ScenaOn.SetActive(true);
        Debug.Log(tekst);
    }

    public void zamknij()
    {
        pop_up_wyjdz.SetActive(true);
    }
}