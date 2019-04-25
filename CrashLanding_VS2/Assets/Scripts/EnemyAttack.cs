using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

public Animator animator;

void Awake()
{
  animator = GetComponentInChildren<Animator>();
}

void OnTriggerEnter(Collider plyr) {

    if (plyr.gameObject.tag == "Player"){
    GameObject.Find("Player").GetComponent<CL_PlayerHealth>().currentHealth = GameObject.Find("Player").GetComponent<CL_PlayerHealth>().currentHealth - 5;
    animator.SetTrigger ("slap");
    }
  }
}
