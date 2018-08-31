using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public GameObject GateDoorObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter(Collider ColliderObject)
    {
        if(ColliderObject.CompareTag("Player"))
        {
            if(ColliderObject.GetComponent<PlayerScript>().hasKey==true)
            {
                GateDoorObject.transform.localPosition = new Vector3(0, 7, 0.5f);
            }
        }
    }
}