using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PetController : MonoBehaviour
{
    public PetStateSO currentState;
    public List<PetStateSO> States;
    public bool ImOnVisionRange;

    private void Update()
    {
        currentState.OnStateUpdate(this);
    }

    public void CheckEndingConditions()
    {
        foreach (PetConditionSO condition in currentState.EndConditions)
        {
            if (condition.CheckCondition(this) == condition.answer) ExitCurrentNode();
        }
    }

    public void ExitCurrentNode()
    {
        foreach (PetStateSO stateSO in States)
        {
            if (stateSO.StartCondition == null || stateSO.StartCondition.CheckCondition(this) == stateSO.StartCondition.answer)
            {
                EnterNewState(stateSO);
                break;
            }
        }
        currentState.OnStateEnter(this);
    }

    private void EnterNewState(PetStateSO state)
    {
        currentState.OnStateExit(this);
        currentState = state;
        currentState.OnStateEnter(this);
    }
}
