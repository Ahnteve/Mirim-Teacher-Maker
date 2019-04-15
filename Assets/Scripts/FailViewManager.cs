using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailViewManager : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        string fail = DataController.Instance.Fail;
        string message = DataController.Instance.Teacher + " 선생님의\n";
        string[] attribute = { "체형", "키", "나이", "성별", "특별 문제"};
        int[] wrong=new int[fail.Length];

        for(int i=0; i<wrong.Length; i++)
        {
            wrong[i] = int.Parse(""+fail[i]);
        }

        if (fail.Length == 1)
        {
            message +=attribute[wrong[0]-1]+"을(를) 맞추지 못 한 것 같군..\n다시 도전해보게나!";
        } else
        {
            for(int i=0; i<wrong.Length; i++)
            {
                message += attribute[wrong[i] - 1];
                if (i != wrong.Length - 1)
                {
                    message += ", ";
                }
            }
            message += "을(를) 맞추지 못 한 것 같군..\n다시 도전해보게나!";
        }

        text.text = message;
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
