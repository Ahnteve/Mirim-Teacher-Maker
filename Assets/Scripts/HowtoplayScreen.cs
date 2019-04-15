using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowtoplayScreen : MonoBehaviour {

    public int index=1;
    public Button next;
    public Button prev;


    public void UpdateScreen(int value)
    {
        index += value;
        if (index <= 1)
        {
            prev.gameObject.SetActive(false);
        } else if(index > 8)
        {
            next.gameObject.SetActive(false);
        } else
        {
            next.gameObject.SetActive(true);
            prev.gameObject.SetActive(true);
            
        }
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/htp"+index);
    }
}
