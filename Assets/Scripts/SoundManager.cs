using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public GameObject player;
    public GameObject rain;
    public GameObject thunder;
    public GameObject doorMan;
    AudioSource doorManAudio;

	// Use this for initialization
	void Start ()
    {
        doorManAudio = doorMan.GetComponent<AudioSource>();

        player.GetComponent<AudioSource>().volume = 0.125f;
        rain.GetComponent<AudioSource>().volume = 0.25f;
        thunder.GetComponent<AudioSource>().volume = 0.25f;
        doorManAudio.volume = 0.5f;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
