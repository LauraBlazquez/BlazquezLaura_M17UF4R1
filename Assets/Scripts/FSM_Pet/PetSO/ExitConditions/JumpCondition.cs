using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "JumpCondition", menuName = "PetConditionSO/Jump")]
public class JumpCondition : PetConditionSO
{
    public override bool CheckCondition(PetController pc)
    {
        return pc.ImOnVisionRange;
    }
}