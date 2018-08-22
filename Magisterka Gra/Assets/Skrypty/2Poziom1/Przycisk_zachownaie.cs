using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Przycisk_zachownaie : MonoBehaviour
{
    Button przycisk;
    public GameObject tekst_uroczystosc;
    public GameObject ScenaOff;
    public GameObject ScenaOn;

    public void wykonaj_przycisk()
    {
        przycisk = FindObjectOfType<Button>();
        var tekst = przycisk.GetComponentInChildren<Text>().text;

        tekst_uroczystosc.SetActive(true);
        tekst_uroczystosc.GetComponent<UnityEngine.UI.Text>().text = tekst;
        ScenaOff.SetActive(false);
        ScenaOn.SetActive(true);
        Debug.Log(tekst);
    }
}