using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFOV : MonoBehaviour
{
    public float fov = 100f;
    public GameObject pet;
    public bool petInVision;

    private void Update()
    {
        petInVision = CheckPetInVision(pet);
    }

    public bool CheckPetInVision(GameObject pet)
    {
        Vector3 direction = pet.transform.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);

        if (angle < fov / 2)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit))
            {
                if (hit.collider.gameObject == pet)
                {
                    return true;
                }
            }
        }
        return false;
    }
}