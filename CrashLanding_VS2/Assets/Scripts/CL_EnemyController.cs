﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CL_EnemyController : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private int damage = 10;

    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Animator>();
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);


            if (distance <= agent.stoppingDistance)
            {
                attack();
                FaceTarget();
            }
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void attack()
    {
        //Call Animation Here!!!!!

        target.GetComponent<CL_PlayerHealth>().TakeDamage(damage);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
