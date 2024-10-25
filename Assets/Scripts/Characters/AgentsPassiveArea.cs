using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentsPassiveArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 178, 255, 0.8f);
        CircleCollider2D areacheck = GetComponent<CircleCollider2D>();
        if (areacheck != null)
        {
            Gizmos.DrawWireSphere(transform.position, areacheck.radius * transform.parent.localScale.x);
        }
    }
}
