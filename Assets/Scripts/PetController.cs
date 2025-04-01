using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PetController : MonoBehaviour
{
    public GameObject target;
    public bool OnVisionRange = false;
    public StateSO currentState;
    public List<StateSO> States;

    void Start()
    {

    }

    public void CheckEndingConditions()
    {
        foreach (ConditionSO condition in currentState.EndConditions)
        {
            if (condition.CheckCondition(this) == condition.answer) ExitCurrentNode();
        }
    }

    public void ExitCurrentNode()
    {
        foreach (StateSO stateSO in States)
        {
            if (stateSO.StartCondition == null || stateSO.StartCondition.CheckCondition(this) == stateSO.StartCondition.answer)
            {
                EnterNewState(stateSO);
                break;
            }
        }
        currentState.OnStateEnter(this);
    }

    private void EnterNewState(StateSO state)
    {
        currentState.OnStateExit(this);
        currentState = state;
        currentState.OnStateEnter(this);
    }
}
