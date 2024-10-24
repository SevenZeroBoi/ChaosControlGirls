using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStates : MonoBehaviour
{
    public static MainGameStates instance; 
    private void Awake()
    {
        instance = this;
    }

    [Header("Current Game States")]
    public CommanderState currentCommanderState;

    [Header("Agent Targets")]
    public GameObject currentTargetOBJ;
    public List<GameObject> allTargetOBJ;

    [Header("Other Controller Storage")]
    public GameObject agentSetupController;



    private void Update()
    {
        //Object Detection
        if (allTargetOBJ.Count != 0) currentTargetOBJ = allTargetOBJ[allTargetOBJ.Count-1];
        else currentTargetOBJ = null;

    }


    public enum CommanderState
    {
        FIGHTING, SETUP
    }
}
