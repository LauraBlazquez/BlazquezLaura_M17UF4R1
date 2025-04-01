using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Pet_Chase", menuName = "StatesSO/Pet_Chase")]
public class Pet_Chase : PetStateSO
{
    public override void OnStateEnter(PetController ec)
    {
    }

    public override void OnStateExit(PetController ec)
    {
        ec.gameObject.GetComponent<PetBehaviour>().StopChase();
    }

    public override void OnStateUpdate(PetController ec)
    {
        ec.gameObject.GetComponent<PetBehaviour>().Chase();
    }
}