using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    public static GameStateList currentGameState;

    public enum GameStateList
    {
        BUILDING, ACTION, MOVING, LOSE, AGENTSETUP
    }
}
