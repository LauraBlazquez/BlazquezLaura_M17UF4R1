using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Follow", menuName = "StatesSO/Follow")]
public class Follow : PetStateSO
{
    public override void OnStateEnter(PetController pc)
    {
        pc.gameObject.GetComponent<PetBehaviour>().destination = GameObject.Find("Player");
    }

    public override void OnStateExit(PetController pc)
    {
    }

    public override void OnStateUpdate(PetController pc)
    {
        pc.gameObject.GetComponent<PetBehaviour>().Follow();
    }
}