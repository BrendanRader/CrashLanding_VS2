using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CL_EnemyController : MonoBehaviour
{
    public Animator animator;
    public float attackSpeed = 1f;
    private float attackCooldown = 0f;

    [SerializeField]
    private int damage = 10;

    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= Time.deltaTime;
        float distance = Vector3.Distance(target.position, transform.position);
        
        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
                animator.SetTrigger("slap");
                if (attackCooldown <= 0f)
                {
                    attack();
                    attackCooldown = 6f / attackSpeed;
                }
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
        target.GetComponent<CL_PlayerHealth>().TakeDamage(damage);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
