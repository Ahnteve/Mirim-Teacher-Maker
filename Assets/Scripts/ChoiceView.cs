using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceView : MonoBehaviour {

    public Image imageDisplayer;
    public Text scriptDisplayer;
    public Text nameDisplayer;
    public Button nextButton;

    private static ChoiceView instance;

    public static ChoiceView Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ChoiceView>();
                // DataController를 찾아 할당

                if (instance == null)
                {
                    // 그래도 없으면 DataController를 생성
                    GameObject container = new GameObject();
                    instance = container.AddComponent<ChoiceView>();
                }
            }
            return instance;
        }
    }
}
