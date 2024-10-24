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

}
