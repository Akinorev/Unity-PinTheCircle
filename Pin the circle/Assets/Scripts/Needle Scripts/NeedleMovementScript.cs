using UnityEngine;
using System.Collections;

public class NeedleMovementScript : MonoBehaviour {

    [SerializeField]
    private GameObject needleBody;

    private bool canShootCircle;
    private bool touchedTheCircle;

    private float speed = 70f;

    private Rigidbody2D myBody;

    void Awake ()
    {

    }

    void Initialize()
    {
        needleBody.SetActive(false);
    }
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
}
