using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentTest001 : MainAgentScript
{
    public override void AgentActionStage()
    {
        Debug.Log(gameObject.name + " Action!");
    }

    public override void AgentIdleStage()
    {
        Debug.Log(gameObject.name + " Idle!");
    }

    
}
