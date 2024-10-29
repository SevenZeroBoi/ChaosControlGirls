using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveChecker : MonoBehaviour
{
    public int currentWave;
    public int chanceOfIntersection;

    void ChangingWave()
    {
        int check = Random.Range(0,chanceOfIntersection);

        if (check == 0)
        {
            //intersection trigger
            currentWave++;
        }

        if (currentWave == 8 || currentWave == 9)
        {
            currentWave++;
        }
    }
}
