using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{
    public GameObject textObject;
    public List<GameObject> textFollowing;
    public GameObject spawningPoint;
    public float rangeBetweenText;

    private void Start()
    {
        textFollowing.Add(textObject);
    }
    private void Update()
    {
        if (Mathf.Abs(spawningPoint.transform.position.x - textObject.transform.position.x) > rangeBetweenText && textFollowing.Count == 1)
        {
            textFollowing.Add(Instantiate(textObject,new Vector2(spawningPoint.transform.position.x - rangeBetweenText, spawningPoint.transform.position.y),Quaternion.identity));
        }
        else if (textFollowing != null)
        {/*
            if (Mathf.Abs(spawningPoint.transform.position.x - textFollowing[textFollowing.Count-1].transform.position.x) > rangeBetweenText)
            {
                textFollowing.Add(Instantiate(textObject, new Vector2(spawningPoint.transform.position.x - rangeBetweenText, spawningPoint.transform.position.y), Quaternion.identity));
            }*/
        }
    }


}
