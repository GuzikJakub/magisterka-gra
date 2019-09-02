using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnim : MonoBehaviour
{
    public float showTime = 0.01f;
    public string textshow;
    public int ktora_scena;
    public GameObject mytext;
    public GameObject scena;
    public GameObject scena1;
    public GameObject scenaown;
    public GameObject tables_all;
    public GameObject scena_error;

    void Start()
    {
  //      mytext = GetComponent<UnityEngine.UI.Text>().text;
        textshow = mytext.GetComponent<UnityEngine.UI.Text>().text;
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
            scena.SetActive(true);
            scena1.SetActive(true);
            scenaown.SetActive(false);
            tables_all.SetActive(true);
        }
        else if (ktora_scena == 2)
        {
            Application.LoadLevel("1Poczatek");
        }
        
    }
}