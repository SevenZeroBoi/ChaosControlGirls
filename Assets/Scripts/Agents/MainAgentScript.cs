using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public abstract class MainAgentScript : MonoBehaviour
{
    public SO_AgentsData agentData;
    public bool isGettingPick = false;
    public GameObject cursor;
    public abstract void AgentIdle();
    public abstract void AgentAction();
    public void AreaCheck()
    {
       
    }

    public void Awake()
    {
        gameObject.tag = "Agents";
    }
    public void Update()
    {
        Collider2D overlap = Physics2D.OverlapCircle(transform.position, agentData.areaRange);
        
        if (overlap != null )
        {
            GameObject cursor = GameObject.FindGameObjectWithTag("Cursor");
            CursorMoving cscript = cursor.GetComponent<CursorMoving>();

            if (overlap.gameObject.tag == "Cursor" && isGettingPick == false)
            {
                StandingAgent();
                cooldowncheck -= Time.deltaTime;

                if (cooldowncheck <= 0)
                {
                    StandingAgent();
                    if (cscript.isTriggered == true)
                    {
                        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAEEE");
                        isGettingPick = true;
                        cooldowncheck = 2;
                    }
                }
            }
            else if (isGettingPick)
            {
                MovingAgent(cursor);
                cooldowncheck -= Time.deltaTime;
                if (cooldowncheck <= 0)
                {
                    if (overlap.gameObject.tag != "Agents")
                    {
                        if (cscript.isTriggered == true)
                        {
                            Debug.Log("Chekc");
                            isGettingPick = false;
                            cooldowncheck = 2;
                        }

                    }
                }
            }
        }

    }
    float cooldowncheck = 2;



    public void MovingAgent(GameObject cursor)
    {
        transform.position = cursor.transform.position;
        AgentIdle();
    }
    public void StandingAgent()
    {
        transform.position = transform.position;
        AgentAction();
    }

    public void OnDrawGizmos()
    {
        if (agentData != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, agentData.areaRange);
        }
    }
}