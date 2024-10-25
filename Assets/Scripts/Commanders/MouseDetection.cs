using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetection : MonoBehaviour
{
    public static MouseDetection instance;
    private void Awake()
    {
        instance = this;
        Cursor.visible = false;
    }

    private void Update()
    {
        CursorFollowingMouse();
        if (Input.GetKeyDown(KeyCode.O))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void CursorFollowingMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0f;
        transform.position = mousePosition;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        if (MainGameStates.instance != null && MainGameStates.instance.allTargetOBJ.Count != 0)
        {
            Gizmos.DrawLine(gameObject.transform.position, MainGameStates.instance.currentTargetOBJ.transform.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BUILDING")
        {
            MainGameStates.instance.allTargetOBJ.Add(other.gameObject.transform.parent.gameObject);
        }

        if (other.gameObject.tag == "WALL")
        {
            MainGameStates.instance.currentWallAreaAroundCursor++;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "BUILDING")
        {
            MainGameStates.instance.allTargetOBJ.Remove(other.gameObject.transform.parent.gameObject);
        }

        if (other.gameObject.tag == "WALL")
        {
            MainGameStates.instance.currentWallAreaAroundCursor--;
        }
    }
}
