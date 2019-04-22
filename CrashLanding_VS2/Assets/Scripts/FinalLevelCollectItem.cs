using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelCollectItem : MonoBehaviour {

    public Item item;
    public static int collected = 0;
    public GameObject WinCollider;

    void Awake() {
        collected++;
        WinCollider.SetActive(false);
    }

    void OnTriggerEnter(Collider plyr) {

        if (plyr.gameObject.tag == "Player"){
            collected--;
            Inventory.instance.Add(item);
            Destroy(gameObject);

            if(collected == 0){
              WinCollider.SetActive(true);
            }
        }
    }
  }
