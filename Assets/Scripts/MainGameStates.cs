using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStates : MonoBehaviour
{
    public static MainGameStates instance;

    [Header("Current Game States")]
    public CommanderState currentCommanderState;

    [Header("Agent Targets")]
    public GameObject currentTargetOBJ;
    public List<GameObject> allTargetOBJ;

    [Header("Um")]
    public int currentNearByBuildingCounts;
    public int currentWallAreaAroundCursor;

    [Header("Other Controller Storage")]
    public GameObject agentSetupController;


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        //Object Detection
        if (allTargetOBJ.Count != 0) currentTargetOBJ = allTargetOBJ[allTargetOBJ.Count-1];
        else currentTargetOBJ = null;

        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangingStates();
        }
        
        if (currentCommanderState != CommanderState.SETUP)
        {
            agentSetupController.SetActive(false);
        }
        else
        {
            agentSetupController.SetActive(true);
        }
    }



    #region Commanding State
    void ChangingStates()
    {
        switch (currentCommanderState)
        {
            case CommanderState.SETUP:
                currentCommanderState = CommanderState.FIGHTING;
                break;
            case CommanderState.FIGHTING:
                currentCommanderState = CommanderState.SETUP;
                break;
            default:
                break;
        }
    }

    public enum CommanderState
    {
        FIGHTING, SETUP
    }
    #endregion

}
