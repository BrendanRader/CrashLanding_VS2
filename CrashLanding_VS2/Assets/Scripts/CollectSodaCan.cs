using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSodaCan : MonoBehaviour {

    public static int sodaCans = 0;

    void Awake() {
        sodaCans++;
    }

    void OnTriggerEnter(Collider plyr) {

        if (plyr.gameObject.tag == "Player"){
            sodaCans--;
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<CL_Health>().currentHealth = GameObject.Find("Player").GetComponent<CL_Health>().startHealth;
        }
    }
}
