using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainGameStates : MonoBehaviour
{
    public static MainGameStates instance;

    [Header("Current Commander States")]
    public CommanderState currentCommanderState;

    [Header("Agent Targets")]
    public GameObject currentTargetOBJ;
    public List<GameObject> allTargetOBJ;

    [Header("Checking Collision Overall")]
    public short currentNearByBuildingCounts;
    public short currentWallAreaAroundCursor;

    [Header("Other Controller Storage")]
    public GameObject agentSetupController;

    [Header("Game Stats List")]
    public int currentWave;
    public int playerCoins;
    public int playerMaterials;

    [Header("Character Check")]
    public List<SO_Agents> allCharacterInStage;


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        ObjectDetection();
    }


    void ObjectDetection()
    {
        //Object Detection
        if (allTargetOBJ.Count != 0) currentTargetOBJ = allTargetOBJ[allTargetOBJ.Count - 1];
        else currentTargetOBJ = null;

        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangingStates();
        }

        //state changing temp
        if (currentCommanderState != CommanderState.SETUP)
        {
            agentSetupController.SetActive(false);
        }
        else
        {
            agentSetupController.SetActive(true);
        }
    }


    #region Commander State
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
