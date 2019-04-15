using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowtoPlay : MonoBehaviour {

	public void OnClick()
    {
        SceneManager.LoadScene(10);
    }
}
