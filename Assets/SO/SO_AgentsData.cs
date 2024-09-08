using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "NewAgent", menuName = "ScriptableObjects/AgentData", order = 1)]
public class SO_AgentsData : ScriptableObject
{
    [Header("Characters Details")]
    public string agentName;
    [TextArea(4, 7)]
    public string agentDescption;
    public Sprite agentIcon;
    public FactionList agentFaction;
    public int agentCost;

    [Header("Characters Area Box")]
    public string areaType;
    public float areaRange;

    [Header("Character Ingame Object")]
    public GameObject agentPrefab;

    public enum FactionList
    {
        ICEBORNE, STARDRIVE, PETUNIA
    }
}
