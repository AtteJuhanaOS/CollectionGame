using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    public static int coinCount = 0;

    // Use this for initialization
    void Start ()
    {
        ++CoinScript.coinCount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.right * Time.deltaTime*70);
    }

    private void OnTriggerEnter(Collider colliderObject)
    {
        if(colliderObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        
    }
    void OnDestroy()
    {
        --CoinScript.coinCount;
        if(CoinScript.coinCount<=0)
        {
            GameObject timer = GameObject.Find("LevelTimer");
            Destroy(timer);

            GameObject[] fireworkSystems = GameObject.FindGameObjectsWithTag("Firework");
            foreach(GameObject currentFirework in fireworkSystems)
            {
                currentFirework.GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
