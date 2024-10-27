using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBulletPattern", menuName = "ScriptableObjects/BulletPatterns", order = 2)]
public class SO_BulletPattern : ScriptableObject
{

    public string bpatternName;
    public string bpatternDescription;
    public int bpatternBaseDamage;


    public void OnHitTrigger()
    {

    }

    public void OnDestroyTrigger()
    {
        
    }
}
