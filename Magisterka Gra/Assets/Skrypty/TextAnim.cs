using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextAnim : MonoBehaviour
{
    public float showTime = 0.01f;
    public string textshow;
    public int ktora_scena;
    public GameObject mytext;
    public GameObject scena;
    public GameObject scena0;
    public GameObject scena1;
    public GameObject scenaown;
    public GameObject tables_all;
    public GameObject scena_error;
    string nazwa_sceny;

    void Start()
    {
  //      mytext = GetComponent<UnityEngine.UI.Text>().text;
        textshow = mytext.GetComponent<UnityEngine.UI.Text>().text;
        Scene obecna_scena = SceneManager.GetActiveScene();
        nazwa_sceny = obecna_scena.name;
        Debug.Log(textshow);
        mytext.GetComponent<UnityEngine.UI.Text>().text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in textshow.ToCharArray())
        {
            mytext.GetComponent<UnityEngine.UI.Text>().text += letter;
//            Debug.Log(letter);
            yield return 0;
            yield return new WaitForSeconds(showTime);
        }
        yield return new WaitForSeconds(2);
        if (ktora_scena == 1)
        {
            if (nazwa_sceny == "2Poziom1")
            {
                scena.SetActive(true);
                scena1.SetActive(true);
                scenaown.SetActive(false);
                tables_all.SetActive(true);
            }
            else if (nazwa_sceny == "2Poziom2")
            {
                scena.SetActive(true);
                scena0.SetActive(true);
                scenaown.SetActive(false);
                tables_all.SetActive(true);
            }

        }
        else if (ktora_scena == 2)
        {
            if (nazwa_sceny == "2Poziom2")
            {
                Application.LoadLevel("1Poczatek_bis");
            }
            else if (nazwa_sceny == "2Poziom1")
            {
                Application.LoadLevel("1Poczatek_wyjdz1");
            }
        }
        else if (ktora_scena == 3)
        {
            Application.LoadLevel("1Poczatek_bis");
        }
    }
}