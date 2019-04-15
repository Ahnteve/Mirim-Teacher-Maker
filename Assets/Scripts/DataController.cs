using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    public string Recipe {
        get
        {
            return PlayerPrefs.GetString("recipe");
        }
        set
        {
            PlayerPrefs.SetString("recipe", value);
        }
    }

    public string Teacher
    {
        get
        {
            return PlayerPrefs.GetString("teacher");
        }
        set
        {
            PlayerPrefs.SetString("teacher", value);
        }
    }

    public string Fail
    {
        get
        {
            return PlayerPrefs.GetString("fail");
        }
        set
        {
            PlayerPrefs.SetString("fail", value);
        }
    }

    public string Status
    {
        get
        {
            return PlayerPrefs.GetString("Status");
        }
        set
        {
            PlayerPrefs.SetString("Status", value);
        }
    }



    private static DataController instance;

    public static DataController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataController>();
                // DataController를 찾아 할당

                if (instance == null)
                {
                    // 그래도 없으면 DataController를 생성
                    GameObject container = new GameObject();
                    instance = container.AddComponent<DataController>();
                }
            }
            return instance;
        }
    }

    public void AddRecipe(int step, int index)
    {
        if (step != 7)
        {
            Result result = DataAccess.Instance.Select("materials.txt", "단계", "" + (step - 1));
            string[] temp = result.GetString(1).Split('/');

            Recipe += temp[index - 1] + "/";
        }
        else
        {
            Recipe += index;
        }
        Debug.Log(Recipe);
    }

}
