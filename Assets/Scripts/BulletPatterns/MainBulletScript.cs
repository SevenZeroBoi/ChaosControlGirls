using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBulletScript : MonoBehaviour
{
    public SO_Agents agents;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ENEMIES")
        {
            
        }
    }
}
