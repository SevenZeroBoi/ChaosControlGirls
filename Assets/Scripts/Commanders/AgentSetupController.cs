using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSetupController : MonoBehaviour
{
    private GameObject _movingTargetOBJ;
    private Vector3 _thePastLocation;
    private bool _onMoveAgents;
    private void OnEnable()
    {
        _thePastLocation = Vector3.zero;
    }
    private void OnDisable()
    {

    }

    private void Update()
    {
        MainSetupController();
    }

    void MainSetupController()
    {
        if (MainGameStates.instance.allTargetOBJ.Count != 0 && Input.GetKeyDown(KeyCode.Space) && !_onMoveAgents)
        {
            _thePastLocation = MainGameStates.instance.allTargetOBJ[MainGameStates.instance.allTargetOBJ.Count - 1].transform.position;
            _movingTargetOBJ = MainGameStates.instance.allTargetOBJ[MainGameStates.instance.allTargetOBJ.Count - 1];
            _onMoveAgents = true;
        }

        if (_onMoveAgents)
        {
            _movingTargetOBJ.transform.position = MouseDetection.instance.gameObject.transform.position;
            if (Input.GetKeyDown(KeyCode.Space) && _cooldowncheck <= 0)
            {
                if (MainGameStates.instance.currentNearByBuildingCounts == 0)
                {
                    _onMoveAgents = false;
                    _cooldowncheck = 0.2f;
                }
                else
                {
                    Debug.Log("HAHA Cant place");
                }
            }
        }
        CooldownCheck();
    }

    private float _cooldowncheck = 0.2f;
    void CooldownCheck()
    {
        if (_cooldowncheck > 0 && _onMoveAgents)
        {
            _cooldowncheck -= Time.deltaTime;
        }
    }
}
