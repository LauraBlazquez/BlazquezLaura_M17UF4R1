using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PetStateSO : ScriptableObject
{
    public ConditionSO StartCondition;
    public List<ConditionSO> EndConditions;
    public abstract void OnStateEnter(PetController pc);
    public abstract void OnStateUpdate(PetController pc);
    public abstract void OnStateExit(PetController pc);
}