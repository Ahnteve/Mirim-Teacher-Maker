using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour {

    public Image over;
    public Button nextButton;

    private int count=0;

	public void OnChanged()
    {
        over.sprite = Resources.Load<Sprite>("Sprites/over/bowl"+(GetComponent<Slider>().value+1));
        //Debug.Log("Sprites/over/bowl" + (GetComponent<Slider>().value) + 1);
        count++;
        if(count > 30)
        {
            nextButton.gameObject.SetActive(true);
        }
    }
}
