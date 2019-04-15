using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour {

    public int value;

	public void OnClick()
    {
        GameObject.Find("HowtoplayScreen").GetComponent<HowtoplayScreen>().UpdateScreen(value);

    }
}
