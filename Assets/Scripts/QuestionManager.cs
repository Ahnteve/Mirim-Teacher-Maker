using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour {

    public Text question;
    public GameObject exampleGroup;

    void Start () {
        Result result = DataAccess.Instance.Select("d.txt", "이름", DataController.Instance.Teacher);

        question.text = result.GetString(3);
        
        string[] examples=result.GetString(4).Split(',');

        int count = exampleGroup.transform.childCount;
        for (int i = 0; i < count; i++)
        {
            Transform child = exampleGroup.transform.GetChild(i);
            child.GetComponent<Text>().text = examples[i].Trim();
        }

    }
	
	
}
