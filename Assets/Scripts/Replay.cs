using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

	public void OnClick()
    {
        SceneManager.LoadScene("Main1");
        DataController.Instance.Recipe = "";
        DataController.Instance.Fail = "";
    }

}
