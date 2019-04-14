using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    //Rotation Sensitivity
    public float RotationSensitivity = 35.0f;
    public float yMinAngle = -45.0f;
    public float yMaxAngle = 45.0f;
    public float xMinAngle = -45.0f;
    public float xMaxAngle = 45.0f;

    //Rotation Value
    float yRotate = 0.0f;
    float xRotate = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //Rotate Y view
        /* yRotate += Input.GetAxis("Mouse Y") * RotationSensitivity * Time.deltaTime;
         yRotate = Mathf.Clamp(yRotate, yMinAngle, yMaxAngle);
         transform.eulerAngles = new Vector3(yRotate, xRotate, 0.0f);

         //Rotate X view
         xRotate += Input.GetAxis("Mouse X") * RotationSensitivity * Time.deltaTime;
         xRotate = Mathf.Clamp(xRotate, xMinAngle, xMaxAngle);
         transform.eulerAngles = new Vector3(yRotate, xRotate, 0.0f);
         */

         //Rotate Y view
         yRotate += Input.GetAxis("CameraRotateY") * RotationSensitivity * Time.deltaTime;
         yRotate = Mathf.Clamp(yRotate, yMinAngle, yMaxAngle);
         transform.eulerAngles = new Vector3(yRotate, xRotate, 0.0f);
      

         //Rotate X view
         xRotate += Input.GetAxis("CameraRotateX") * RotationSensitivity * Time.deltaTime;
         xRotate = Mathf.Clamp(xRotate, xMinAngle, xMaxAngle);
         transform.eulerAngles = new Vector3(yRotate, xRotate, 0.0f);
       
       
    }
}
