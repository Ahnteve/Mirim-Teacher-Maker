using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour {

    public Text[] texts;

    public float animTime = 0.1f;

    private float start = 0f;
    private float end = 1f;
    private float time = 0f;


    void Start () {
        StartCoroutine("PlayAnimation");
	}
	
	IEnumerator PlayAnimation()
    {
        for(int i=0; i<texts.Length; i++)
        {
            Color color = texts[i].color;
            time = 0f;
            color.a = Mathf.Lerp(start, end, time);

            while (color.a < 1f)
            {
                time += Time.deltaTime / animTime;
                color.a = Mathf.Lerp(start, end, time);
                texts[i].color = color;

                yield return null;
            }
        }
        
    }
}
