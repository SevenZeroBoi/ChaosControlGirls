using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSetupController : MonoBehaviour
{
    private Vector3 _thePastLocation;
    private BoxCollider2D _areaHitBoxContainer;
    private bool _canPlaceAgents;
    private void OnEnable()
    {
        _thePastLocation = Vector3.zero;
        _areaHitBoxContainer = null;
    }
    private void OnDisable()
    {
        if (_areaHitBoxContainer != null)
        {
            _areaHitBoxContainer = null;
        }
    }

    private void Update()
    {
        MainSetupController();
    }

    void MainSetupController()
    {
        if (MainGameStates.instance.allTargetOBJ.Count != 0 && Input.GetKeyDown(KeyCode.Space) && _areaHitBoxContainer == null)
        {
            _areaHitBoxContainer = MainGameStates.instance.currentTargetOBJ.GetComponent<BoxCollider2D>();
        }

        while (_areaHitBoxContainer != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_canPlaceAgents)
                {

                }
                else
                {

                }
            }
        }
    }
}
