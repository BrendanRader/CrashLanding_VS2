using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {


void OnTriggerEnter(Collider plyr) {

    if (plyr.gameObject.tag == "Player"){
    GameObject.Find("Player").GetComponent<CL_PlayerHealth>().currentHealth = GameObject.Find("Player").GetComponent<CL_PlayerHealth>().currentHealth - 5;
    }
  }
}
