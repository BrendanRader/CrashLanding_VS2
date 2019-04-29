using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CL_PlayerHealth : MonoBehaviour
{
    //starting health
    public int startHealth = 100;

    //keep track of current health
    public int currentHealth;

    public Slider HealthBar;

    public GameObject death;

    //reset health when enabled
    private void OnEnable()
    {
        currentHealth = startHealth;
        HealthBar.value = startHealth;
        death.SetActive(false);
    }

    //Method to take damage
    public void TakeDamage(int damageAmount)
    {
        //Subtract damage taken from current health
        currentHealth -= damageAmount;
        HealthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
            death.SetActive(true);
        }

    }

    private void Die()
    {
        gameObject.SetActive(false); // disables game object
    }
  }
