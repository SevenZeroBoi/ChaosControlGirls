using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStates : MonoBehaviour
{
    public static MainGameStates instance;

    public enum CommanderState
    {
        FIGHTING, SETUP
    }
}
