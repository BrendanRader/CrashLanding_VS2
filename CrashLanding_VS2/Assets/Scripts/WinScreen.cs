using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{

  public GameObject WinCanvas;
  public GameObject WinScreenUI;

    // Start is called before the first frame update
    void Awake() {
        WinCanvas.SetActive(true);
    }

    void OnTriggerEnter(Collider plyr){
      if (plyr.gameObject.tag == "Player"){
        WinCanvas.SetActive(true);
        WinScreenUI.SetActive(true);
        Time.timeScale = 0f;
    }
  }
}
