using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Content : MonoBehaviour {
    public TeacherButton tb;
	// Use this for initialization
	void Start () {
        Result result=DataAccess.Instance.SelectAll("d");
        int count = transform.childCount;
        

        while (result.HasResult())
        {
            TeacherButton child=Instantiate(tb, new Vector3(0, 0), Quaternion.identity);
            child.transform.SetParent(transform);
            child.gameObject.SetActive(true);
            child.gameObject.name = result.GetString(0);
            child.transform.localScale = new Vector3(1, 1, 1);
            child.script = result.GetString(1);
            result.Next();
        }

    }

}
