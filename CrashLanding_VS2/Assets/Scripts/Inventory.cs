using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public static bool InventoryIsActive = false;

    public GameObject InventoryUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (InventoryIsActive)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        InventoryUI.SetActive(false);
        Time.timeScale = 1f;
        InventoryIsActive = false;
    }

    void Pause()
    {
        InventoryUI.SetActive(true);
        Time.timeScale = 0f;
        InventoryIsActive = true;
    }
}