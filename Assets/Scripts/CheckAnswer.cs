using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckAnswer : MonoBehaviour {

    public Image bowl;

	public void OnClick()
    {

        DataController.Instance.AddRecipe(SceneManager.GetActiveScene().buildIndex, bowl.GetComponent<Bowl>().amount);


        string[] userRecipe = DataController.Instance.Recipe.Split('/');
        Result result=DataAccess.Instance.Select("d.txt", "이름", DataController.Instance.Teacher);
        

        string[] recipe=result.GetString(2).Split('/');

        string fail="";
        

        for(int i=0; i<recipe.Length; i++)
        {
            if (!recipe[i].Equals(userRecipe[i]) && !recipe[i].Equals("다"))
            {
                fail += (i+1);
            }
        }

        if (fail.Length > 0)
        {
            DataController.Instance.Fail = fail;
            SceneManager.LoadScene("Fail");
        } else
        {
            SceneManager.LoadScene("Success");
        }
    }
}
