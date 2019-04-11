using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CL_EnemyHealth : MonoBehaviour
{
    //starting health
    public int startHealth = 100;

    //keep track of current health
    public int currentHealth;

    //reset health when enabled
    private void OnEnable()
    {
        currentHealth = startHealth;
    }

    //Method to take damage
    public void TakeDamage(int damageAmount)
    {
        //Subtract damage taken from current health
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
            Die();
    }

    private void Die()
    {
        gameObject.SetActive(false); // disables game object
    }
  }
