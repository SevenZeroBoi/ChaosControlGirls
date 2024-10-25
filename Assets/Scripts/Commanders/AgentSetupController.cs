using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSetupController : MonoBehaviour
{
    private GameObject _movingTargetOBJ;
    private Vector3 _thePastLocation;
    private bool _onMoveAgents;
    private float _cooldowncheck = 0.2f;

    private void OnEnable()
    {
        _thePastLocation = Vector3.zero;
        _cooldowncheck = 0.2f;
        _onMoveAgents = false;
        _movingTargetOBJ = null;
    }
    private void OnDisable()
    {
        if (_movingTargetOBJ != null)
        {
            _movingTargetOBJ.transform.position = _thePastLocation;
        }
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
                    _movingTargetOBJ=null;
                }
                else
                {
                    Debug.Log("HAHA Cant place");
                }
            }
        }
        CooldownCheck();
    }

    void CooldownCheck()
    {
        if (_cooldowncheck > 0 && _onMoveAgents)
        {
            _cooldowncheck -= Time.deltaTime;
        }
    }
}
