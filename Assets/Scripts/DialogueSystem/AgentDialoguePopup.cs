using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AgentDialoguePopup : MonoBehaviour
{

    public List<SO_Agents> allCharacterInStage;

    public TMP_Text dialoguePopupText;
    public GameObject dialoguePopupBackground;


    public TextAsset RandomTextPopup()
    {
        SO_Agents pickingAgentOnStage = allCharacterInStage[Random.Range(0, allCharacterInStage.Count)];
        TextAsset pickingDialogue = pickingAgentOnStage.agentsRandomTextPopup[Random.Range(0, pickingAgentOnStage.agentsRandomTextPopup.Length)];
        return pickingDialogue;
    }
}
