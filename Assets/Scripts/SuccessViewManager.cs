using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessViewManager : MonoBehaviour {

    public Text text;
    public Image image;

	void Start () {
        text.text = DataController.Instance.Teacher + " 선생님을 만들었군!";

        image.sprite = Resources.Load<Sprite>("Sprites/teachers/"+DataController.Instance.Teacher);
        DataController.Instance.Status += DataController.Instance.Teacher + ",";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
