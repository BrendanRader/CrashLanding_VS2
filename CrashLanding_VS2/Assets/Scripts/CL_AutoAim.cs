using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CL_AutoAim : MonoBehaviour
{

    public Transform target;
    public Transform partToRotate;
    public float lookSpeed = 10f;
    public float range = 15f;

    public string playerTag = "enemy";
    int randomTarget;
    Quaternion newRot;
    Vector3 relPos;
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire3") || Input.GetAxis("Fire3") != 0)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(playerTag);
            float shortestDistance = Mathf.Infinity;
            GameObject nearestPlayer = null;
            foreach (GameObject player in enemies)
            {
                float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
                if (distanceToPlayer < shortestDistance)
                {
                    shortestDistance = distanceToPlayer;
                    nearestPlayer = player;
                }
            }

            if (nearestPlayer != null && shortestDistance <= range)
            {
                target = nearestPlayer.transform;
            }
            else
            {
                target = null;
            }

            if (target == null)
                return;

            //Target lock on
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * lookSpeed).eulerAngles;
            partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }
       
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
