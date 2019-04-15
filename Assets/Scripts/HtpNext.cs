using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HtpNext : MonoBehaviour {

    public Image image;

	public void OnClick()
    {
        image.sprite = Resources.Load<Sprite>("htp");
    }
}
