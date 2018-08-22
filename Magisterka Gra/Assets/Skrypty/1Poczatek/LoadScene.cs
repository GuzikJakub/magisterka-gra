using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

	public void Load_Scene(string name)
    {
        Application.LoadLevel(name);
    }
}
