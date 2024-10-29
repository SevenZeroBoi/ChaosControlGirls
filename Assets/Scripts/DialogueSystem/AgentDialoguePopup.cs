using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AgentDialoguePopup : MonoBehaviour
{


    public TMP_Text dialoguePopupText;
    public GameObject dialoguePopupBackground;


    public TextAsset RandomTextPopup()
    {
        SO_Agents pickingAgentOnStage = MainGameStates.instance.allCharacterInStage[Random.Range(0, MainGameStates.instance.allCharacterInStage.Count)];
        TextAsset pickingDialogue = pickingAgentOnStage.agentsRandomTextPopup[Random.Range(0, pickingAgentOnStage.agentsRandomTextPopup.Length)];
        return pickingDialogue;
    }
}
