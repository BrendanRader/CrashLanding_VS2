using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraButton : MonoBehaviour
{
    public GameObject Camera1;

    void Update()
    {
        if (Input.GetKey("x"))
            Camera1.SetActive(true);
    }
}
