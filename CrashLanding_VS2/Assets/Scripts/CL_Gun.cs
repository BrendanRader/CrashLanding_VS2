using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CL_Gun : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 1.5f)]
    private float fireRate = 1;

    [SerializeField]
    [Range(1, 10)]
    private int damage = 1;

    //Origin of firing
    [SerializeField]
    private Transform firePoint;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            if (Input.GetButton("Fire1") || Input.GetAxis("Fire1") !=0)
            {
                timer = 0f;
                FireGun();
            }
        }
    }

  
    private void FireGun()
    {
        Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.red, 2f);
        Ray ray = new Ray(firePoint.position, firePoint.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 100)) //100 is max distance in meters
        {
            var health = hitInfo.collider.GetComponent<CL_EnemyHealth>(); //calls health script
            if (health != null)
                health.TakeDamage(damage);
        }
    }
}
