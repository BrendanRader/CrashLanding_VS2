﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CL_Health : MonoBehaviour
{
    //starting health
    [SerializeField]
    private int startHealth = 5;

    //keep track of current health
    private int currentHealth;

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

    // Update is called once per frame
    void Update()
    {

    }
}
