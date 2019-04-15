using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeacherButton : MonoBehaviour {

    private string teacherName;
    public string script;
    private Sprite image;
    private Sprite image2;

    public void Start()
    {
        teacherName = name;
        image = Resources.Load<Sprite>("Sprites/teacher_thum_" + teacherName);
        if (DataController.Instance.Status.Contains(teacherName))
        {
            image2 = Resources.Load<Sprite>("Sprites/teachers/" + teacherName);
        } else
        {
            image2 = Resources.Load<Sprite>("Sprites/teachers/hidden_" + teacherName);
        }
        GetComponent<Image>().sprite = image;
    }


    public void OnClick() {
        ChoiceView.Instance.imageDisplayer.sprite = image2;
        ChoiceView.Instance.scriptDisplayer.text = script;
        
        ChoiceView.Instance.nameDisplayer.text = teacherName;
        
        ChoiceView.Instance.nextButton.gameObject.SetActive(true);

    }
}
