using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "NewAgents", menuName = "ScriptableObjects/Agents", order = 0)]
public class SO_Agents : ScriptableObject
{
    public GameObject agentObject;
    public string agentName;
    public string agentDescription;
    public ENUM_AgentsTag.AgentsType agentType;
    public Sprite agentSmolIcon;

    public TextAsset[] randomTextPopup;
}
