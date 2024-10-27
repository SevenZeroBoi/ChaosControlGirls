using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentsMain : MonoBehaviour
{
    public SO_Agents agentInfo;
    public Animator agentAnim;

    void OnPlacingTrigger()
    {
        agentAnim.SetTrigger("OnPlaceSetUp");
    }

    void OnStageUpdate()
    {

    }

    void OnDeathTrigger()
    {

    }
    
    enum agentStatus
    {
        NONE, ONHOLD, ONPLACE, ATTACKING, ONDEATH
    }
}