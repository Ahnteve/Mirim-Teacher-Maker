using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Stuff : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    public static Vector2 defaultposition;

    public Image target;
    public int value;

    private float width;
    private float height;

    void Start()
    {
        width = GetComponent<RectTransform>().rect.width;
        height = GetComponent<RectTransform>().rect.height;
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        defaultposition = transform.position;
        

    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = Input.mousePosition;
        transform.position = currentPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector2 currentPos = Input.mousePosition;

        float x = target.transform.position.x;
        float y = target.transform.position.y;
        //float right = left + target.GetComponent<RectTransform>().rect.width;
        //float bottom = top + target.GetComponent<RectTransform>().rect.height;
        //Debug.Log("left : " + left + " top : " + top + " right : " + right + " bottom: " + bottom);
        //Debug.Log("currentPos.x : " + currentPos.x + " currentPos.y : " + currentPos.y);

        if (transform.position.x < x + target.GetComponent<RectTransform>().rect.width && transform.position.y < y + target.GetComponent<RectTransform>().rect.height &&
                transform.position.x + height > x && transform.position.y + width > y)
        {
                target.GetComponent<Bowl>().Add(value);
        }

    /*
        if (currentPos.x < right && currentPos.y > top &&
                    currentPos.x > left && currentPos.y < bottom)
        {
            target.GetComponent<Bowl>().Add(value);
        }
        */
        transform.position = defaultposition;
    }

}
