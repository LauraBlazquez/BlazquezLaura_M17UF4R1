using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFOV : MonoBehaviour
{
    public float fov = 100f;
    private PetController pc;

    private void Awake()
    {
        pc = GameObject.Find("Pet").GetComponent<PetController>();
    }

    public void CheckPetInVision(GameObject pet)
    {
        Vector3 direction = pet.transform.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);

        if (angle < fov / 2)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit))
            {
                if (hit.collider.name == "Pet")
                {
                    pc.ImOnVisionRange = true;
                    pc.CheckEndingConditions();
                }
            }
        }
        else
        {
            if (pc.ImOnVisionRange)
            {
                pc.ImOnVisionRange = false;
                pc.CheckEndingConditions();
            }
        }
    }
}