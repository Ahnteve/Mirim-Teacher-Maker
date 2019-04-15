using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene(0);

        DataController.Instance.Recipe = "";
        DataController.Instance.Teacher = "";
        DataController.Instance.Fail = "";

    }
}
