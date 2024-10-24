using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetection : MonoBehaviour
{
    [Header("Calling for OBJ")]
    public GameObject cursorHitboxOBJ;

    private void Update()
    {
        CursorFollowingMouse();
    }

    void CursorFollowingMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0f;
        cursorHitboxOBJ.transform.position = mousePosition;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        if (MainGameStates.instance.currentTargetOBJ.Count != 0)
        {
            Gizmos.DrawLine(gameObject.transform.position, MainGameStates.instance.currentTargetOBJ
                [MainGameStates.instance.currentTargetOBJ.Count-1].transform.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CHAMPION")
        {
            MainGameStates.instance.currentTargetOBJ.Add(other.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "CHAMPION")
        {
            MainGameStates.instance.currentTargetOBJ.Remove(other.gameObject);
        }
    }
}
