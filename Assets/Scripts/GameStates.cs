using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    public static GameStateList currentGameState = GameStateList.AGENTSETUP;

    public enum GameStateList
    {
        BUILDING, ACTION, MOVING, LOSE, AGENTSETUP
    }
}
