﻿using UnityEngine;
using System.Collections;

public class NeedleMovementScript : MonoBehaviour {

    [SerializeField]
    private GameObject needleBody;

    private bool canFireNeedle = false;
    private bool touchedTheCircle;

    private float forceY = 70f;

    private Rigidbody2D myBody;

    void Awake ()
    {
        Initialize();
    }

    void Initialize()
    {
        needleBody.SetActive(false);
        myBody = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {
	    if (canFireNeedle)
        {
            myBody.velocity = new Vector2(0, forceY);
        }
	}

    public void FireTheNeedle()
    {
        needleBody.SetActive(true);
        myBody.isKinematic = false;
        canFireNeedle = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (touchedTheCircle)
            return;

        if(target.tag == "Circle")
        {
            canFireNeedle = false;
            touchedTheCircle = true;

            myBody.isKinematic = true;
            gameObject.transform.SetParent(target.transform);

            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.SetScore();
            }
        }
    }
}
