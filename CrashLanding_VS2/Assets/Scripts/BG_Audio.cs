using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource Musicsource;
    // Start is called before the first frame update
    void Start()
    {
        Musicsource.clip = MusicClip;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Musicsource.Play();
    }
}

