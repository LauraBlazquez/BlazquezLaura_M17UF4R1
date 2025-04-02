using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PetBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;
    public GameObject destination;
    public float stoppingDistance = 2f;

    private void Start()
    {
        agent.stoppingDistance = stoppingDistance;
        Follow();
    }

    public void Follow()
    {
        agent.isStopped = false;
        agent.SetDestination(destination.transform.position);
        GetComponent<PetController>().CheckEndingConditions();
    }

    public void StopFollow()
    {
        agent.isStopped = true;
        return;
    }

    public void Jump()
    {
        agent.isStopped = true;
        animator.SetBool("IsHappy", true);
    }

    public void StopJump()
    {
        animator.SetBool("IsHappy", false);
    }
}
