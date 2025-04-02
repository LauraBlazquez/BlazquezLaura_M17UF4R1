using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Jump", menuName = "StatesSO/Jump")]
public class Jump : PetStateSO
{
    public override void OnStateEnter(PetController pc)
    {
        pc.gameObject.GetComponent<PetBehaviour>().Jump();
    }

    public override void OnStateExit(PetController pc)
    {
        pc.gameObject.GetComponent<PetBehaviour>().StopJump();
    }

    public override void OnStateUpdate(PetController pc)
    {
        pc.gameObject.GetComponent<PetBehaviour>().Jump();
    }
}