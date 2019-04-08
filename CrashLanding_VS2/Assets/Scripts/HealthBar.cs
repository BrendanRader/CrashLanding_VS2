using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public float TotalHealth;
    public float CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = TotalHealth;
    }

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
        CurrentHealth -= 5;
        transform.localScale = new Vector3((CurrentHealth / TotalHealth), 1, 1);
    }
}
