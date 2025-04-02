using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PetStateSO : ScriptableObject
{
    public PetConditionSO StartCondition;
    public List<PetConditionSO> EndConditions;
    public abstract void OnStateEnter(PetController pc);
    public abstract void OnStateUpdate(PetController pc);
    public abstract void OnStateExit(PetController pc);
}