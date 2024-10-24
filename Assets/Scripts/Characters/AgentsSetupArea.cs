using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentsSetupArea : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BUILDING")
        {
            MainGameStates.instance.currentNearByBuildingCounts++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BUILDING")
        {
            MainGameStates.instance.currentNearByBuildingCounts--;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        BoxCollider2D areacheck = GetComponent<BoxCollider2D>();
        if (areacheck != null)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawWireCube(areacheck.offset, areacheck.size);
        }
    }
}
