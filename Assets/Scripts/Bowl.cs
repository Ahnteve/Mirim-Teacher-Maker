using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Bowl : MonoBehaviour, IPointerDownHandler
{

    public int amount;
    public Sprite defaltImage;
    public string path;
    public int step;
    public Button nextButton;

    void Start()
    {
        amount = 0;
        path = "";
        step = SceneManager.GetActiveScene().buildIndex - 1;

        if (step == 1)
        {
            defaltImage = Resources.Load<Sprite>("Sprites/bowl/bowl_1-" + amount);
        }
        else if (step < 6)
        {
            string[] recipe = DataController.Instance.Recipe.Split('/');

            for (int i = 0; i < recipe.Length - 1; i++)
            {
                Result result = DataAccess.Instance.Select("materials.txt", "단계", "" + (i + 1));
                //Debug.Log(result.GetString(1));
                string[] temp = result.GetString(1).Split('/');

                for (int j = 0; j < temp.Length; j++)
                {
                    if (recipe[i].Equals(temp[j]))
                    {
                        path += ("_"+(i+1)+"-" + (j+1));
                        break;
                    }

                }

            }

            defaltImage = Resources.Load<Sprite>("Sprites/bowl/bowl" + path);
            Debug.Log("Sprites/bowl/bowl" + path);
            GetComponent<Image>().sprite = defaltImage;
        }else
        {
            defaltImage = Resources.Load<Sprite>("Sprites/bowl/mixbowl");
            GetComponent<Image>().sprite = defaltImage;
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        if (step < 4)
        {
            amount--;
            if (amount <= 0)
            {
                amount = 0;
                GetComponent<Image>().sprite = defaltImage;
                nextButton.gameObject.SetActive(false);
            }
            else
            {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/bowl/bowl" + path + "_" + step + "-" + amount);
            }
        } else
        {
            GetComponent<Image>().sprite = defaltImage;
            nextButton.gameObject.SetActive(false);
        }
    }

    public void Add(int value)
    {
        if (step < 4)
        {
            amount++;
            if (amount > value) amount = value;
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/bowl/bowl" + path + "_" + step + "-" + amount);
            nextButton.gameObject.SetActive(true);
        }
        else if (step != 6)
        {
            amount = value;
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/bowl/bowl" + path + "_" + step + "-" + amount);
            nextButton.gameObject.SetActive(true);
        }
        else 
        {
            amount = value;
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/bowl/mixbowl"+amount);
            nextButton.gameObject.SetActive(true);
        }
    }


}

