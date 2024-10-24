using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentsMain : MonoBehaviour
{
    public BoxCollider2D placingAreaCheckOBJ;
    public CircleCollider2D combindingAreaCheckOBJ;

    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        if (placingAreaCheckOBJ != null)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawWireCube(placingAreaCheckOBJ.offset, placingAreaCheckOBJ.size);
        }
    }*/
}
