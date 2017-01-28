using UnityEngine;
using System.Collections;

public class CircleRotateScript : MonoBehaviour {

    [SerializeField]
    private float rotationSpeed = 50f;

    private bool canRotate = false;

    private float angle;

	void Awake () {
        canRotate = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if (canRotate)
        {
            RotateTheCircle();
        }
	}

    void RotateTheCircle()
    {
        angle = transform.rotation.eulerAngles.z;
        angle += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
