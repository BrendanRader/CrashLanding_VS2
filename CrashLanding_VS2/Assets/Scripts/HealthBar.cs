using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoseHealth();
        }
    }

    void LoseHealth()
    {
        GameObject.Find("Player").GetComponent<CL_Health>().currentHealth -= 5;

        transform.localScale = new Vector3((GameObject.Find("Player").GetComponent<CL_Health>().currentHealth / GameObject.Find("Player").GetComponent<CL_Health>().startHealth), 1, 1);

        if(GameObject.Find("Player").GetComponent<CL_Health>().currentHealth == 0)
        {
            GameObject.Find("Player").SetActive(false);
        }
    }
}
