using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {

    public Item item;
    public static int collected = 0;

    Animator animator;
    bool doorOpen;

    public GameObject particle;

    void Awake() {
        collected++;
        doorOpen = false;
        particle.SetActive(false);
        animator = GameObject.Find("DoorParent").GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider plyr) {

        if (plyr.gameObject.tag == "Player"){
            collected--;
            Inventory.instance.Add(item);
            Destroy(gameObject);

            if(collected == 0){
              doorOpen = true;
              particle.SetActive(true);
                Doors ("Open");
            }
        }
    }

    void Doors(string direction){
      animator.SetTrigger(direction);
      }
    }
