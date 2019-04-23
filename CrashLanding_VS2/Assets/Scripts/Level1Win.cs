using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level1Win : MonoBehaviour
{
void OnTriggerEnter(Collider plyr) {

    if (plyr.gameObject.tag == "Player"){
      SceneManager.LoadScene("Level2");
      }
}
}
