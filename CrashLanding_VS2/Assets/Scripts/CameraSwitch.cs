using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Camera Switch
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;
    public GameObject cameraFour;
    public GameObject cameraFive;
    public GameObject cameraSix;
    public float speed;

    // Camera Switch
    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;
    AudioListener cameraThreeAudioLis;
    AudioListener cameraFourAudioLis;
    AudioListener cameraFiveAudioLis;
    AudioListener cameraSixAudioLis;

    // Use this for initialization
    void Start()
    {

        //Get Camera Listeners
        cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();
        cameraThreeAudioLis = cameraThree.GetComponent<AudioListener>();
        cameraFourAudioLis = cameraFour.GetComponent<AudioListener>();
        cameraFiveAudioLis = cameraFive.GetComponent<AudioListener>();
        cameraSixAudioLis = cameraSix.GetComponent<AudioListener>();

        //Camera Position Set
        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        //Change Camera Keyboard
        switchCamera();

    }

    //UI JoyStick Method
    public void cameraPositonM()
    {
        cameraChangeCounter();
    }

    //Change Camera Keyboard
    /*void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            cameraChangeCounter();
        }
    }*/

    void switchCamera()
    {
        if (Input.GetButtonDown("Camera"))
        {
            cameraChangeCounter();
        }
    }

    //Camera Counter
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++; // Counter I already need for Plan A(?)
        cameraPositionChange(cameraPositionCounter);
    }

    //Camera change Logic
    void cameraPositionChange(int camPosition)
    {
        //if (camPosition > 1) // Old logic
        //{
        //    camPosition = 0;
        //}

        if (camPosition > 6)
        {
            camPosition = 0;
        }

        // Plan A:
        // If they press 'E' increment a counter up '6', if it passes '6' reset it back to '0', begin again. 

        // Plan B:
        // Make a for loop, that keeps incrementing the index of the camera each time they press 'E' to change, 
        // if it reaches the max number, then reset the value to '0' so it starts again from the beginning.

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            cameraOne.SetActive(true);
            cameraOneAudioLis.enabled = true;

            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
            cameraThreeAudioLis.enabled = false;
            cameraThree.SetActive(false);
            cameraFourAudioLis.enabled = false;
            cameraFour.SetActive(false);
            cameraFiveAudioLis.enabled = false;
            cameraFive.SetActive(false);
            cameraSixAudioLis.enabled = false;
            cameraSix.SetActive(false);
        }

        //Set camera position 2
        if (camPosition == 1)
        {
            cameraTwo.SetActive(true);
            cameraTwoAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            cameraThreeAudioLis.enabled = false;
            cameraThree.SetActive(false);
            cameraFourAudioLis.enabled = false;
            cameraFour.SetActive(false);
            cameraFiveAudioLis.enabled = false;
            cameraFive.SetActive(false);
            cameraSixAudioLis.enabled = false;
            cameraSix.SetActive(false);
        }

        //Set camera position 3
        if (camPosition == 2)
        {
            cameraThree.SetActive(true);
            cameraThreeAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
            cameraFourAudioLis.enabled = false;
            cameraFour.SetActive(false);
            cameraFiveAudioLis.enabled = false;
            cameraFive.SetActive(false);
            cameraSixAudioLis.enabled = false;
            cameraSix.SetActive(false);
        }

        //Set camera position 4
        if (camPosition == 3)
        {
            cameraFour.SetActive(true);
            cameraFourAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
            cameraThreeAudioLis.enabled = false;
            cameraThree.SetActive(false);
            cameraFiveAudioLis.enabled = false;
            cameraFive.SetActive(false);
            cameraSixAudioLis.enabled = false;
            cameraSix.SetActive(false);
        }

        //Set camera position 5
        if (camPosition == 4)
        {
            cameraFive.SetActive(true);
            cameraFiveAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
            cameraThreeAudioLis.enabled = false;
            cameraThree.SetActive(false);
            cameraFourAudioLis.enabled = false;
            cameraFour.SetActive(false);
            cameraSixAudioLis.enabled = false;
            cameraSix.SetActive(false);
        }

        //Set camera position 6
        if (camPosition == 5)
        {
            cameraSix.SetActive(true);
            cameraSixAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
            cameraThreeAudioLis.enabled = false;
            cameraThree.SetActive(false);
            cameraFourAudioLis.enabled = false;
            cameraFour.SetActive(false);
            cameraFiveAudioLis.enabled = false;
            cameraFive.SetActive(false);
        }
    }
}
