using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	public void OnClick()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
