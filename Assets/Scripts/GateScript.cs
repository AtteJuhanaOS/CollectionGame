using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public GameObject GateDoorObject1;
    public GameObject GateDoorObject2;
    private bool openDoor = false;
    private float doorRotation1 = 90.0f;
    private float doorRotation2 = 90.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(openDoor==true)
            if(GateDoorObject1.transform.rotation.z <0.707)
            {
                doorRotation1 = doorRotation1 + (Time.deltaTime * 25);
                doorRotation2 = doorRotation2 - (Time.deltaTime * 25);
                GateDoorObject1.transform.localRotation = Quaternion.Euler(-90, 0, doorRotation1);
                GateDoorObject2.transform.localRotation = Quaternion.Euler(-90, 0, doorRotation2);
            }
	}
    private void OnTriggerEnter(Collider ColliderObject)
    {
        if(ColliderObject.CompareTag("Player"))
        {
            if(ColliderObject.GetComponent<PlayerScript>().hasKey==true)
            {
                openDoor = true;
            }
        }
    }
}