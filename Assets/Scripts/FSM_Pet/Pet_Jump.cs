using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Pet_Jump", menuName = "StatesSO/Pet_Jump")]
public class Pet_Jump : PetStateSO
{
    public override void OnStateEnter(PetController ec)
    {
    }

    public override void OnStateExit(PetController ec)
    {
        ec.gameObject.GetComponent<PetBehaviour>().StopJump();
    }

    public override void OnStateUpdate(PetController ec)
    {
        ec.gameObject.GetComponent<PetBehaviour>().Jump();
    }
}