using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examine : MonoBehaviour
{

    public GameObject target;
    public GameObject player;

    Vector3 targetPoint;

	// Use this for initialization
	void Start ()
    {
        targetPoint = target.transform.position;
        targetPoint.y = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 playerPos = player.transform.position;
        playerPos.y = 0;

		if(Vector3.Distance(playerPos,targetPoint) <= 2)
        {

        }
	}
}
