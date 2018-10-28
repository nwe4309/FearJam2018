using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Examine : MonoBehaviour
{

    public GameObject target;
    public GameObject player;

    public GameObject examineTextUI;
    public Sprite imageToShow;
    public GameObject page;

    Vector3 targetPoint;

    bool closeEnough;

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

		if(Vector3.Distance(playerPos,targetPoint) <= 1f)
        {
            examineTextUI.SetActive(true);
            closeEnough = true;

            if (Input.GetKeyDown("e"))
            {
                page.GetComponent<Image>().sprite = imageToShow;
                page.SetActive(true);
            }

        }
        else if(closeEnough)
        {
            examineTextUI.SetActive(false);
            closeEnough = false;
        }

        if (page.activeSelf == true && (Input.GetKeyDown(KeyCode.Escape)))
        {
            page.SetActive(false);
        }


    }
}
