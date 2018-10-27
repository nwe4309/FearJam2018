using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{

    public float interval;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        // Light range:40, intensity: 30 as default
        // Light range:50, intensity: 30 for full room lightup
        // Light range:45 for inbetween

        interval -= Time.deltaTime;

        if(interval <= 0)
        {
            gameObject.GetComponent<Light>().enabled = true;
        }

        if (interval <= -0.5f)
        {  
            gameObject.GetComponent<Light>().enabled = false;
        }

        if(interval <= -0.625f)
        {
            gameObject.GetComponent<Light>().enabled = true;
        }
        
        if(interval <= -0.75f)
        {
            gameObject.GetComponent<Light>().enabled = false;
            interval = Random.Range(5, 15);

        }
    }
}
