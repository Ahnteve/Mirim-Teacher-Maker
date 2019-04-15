using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour {

    public Image bowl;

	public void OnClick()
    {
        int step = SceneManager.GetActiveScene().buildIndex;

        if (step == 1)
        {
            DataController.Instance.Teacher = ChoiceView.Instance.nameDisplayer.text;
            Debug.Log(DataController.Instance.Teacher);
        }
        else if(step != 6)
        {
            DataController.Instance.AddRecipe(step, bowl.GetComponent<Bowl>().amount);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        
    }
}
