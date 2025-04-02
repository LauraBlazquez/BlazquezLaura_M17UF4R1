using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class PetConditionSO : ScriptableObject
{
    public abstract bool CheckCondition(PetController pc);

    public bool answer;
}