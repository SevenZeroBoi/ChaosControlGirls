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


    [Header("Agent Targets")]
    public List<GameObject> currentTargetOBJ;
    


    public enum CommanderState
    {
        FIGHTING, SETUP
    }
}
