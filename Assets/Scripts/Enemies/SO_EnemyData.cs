using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewEnemy", menuName = "ScriptableObjects/Enemies", order = 1)]
public class SO_EnemyData : ScriptableObject
{
    public string enemyName;
    public string enemyDescription;

    public int enemyLevel;
    public int enemyType;
}
