using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    public GameObject tele_point;
    private GameObject player;
    public float twait;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    IEnumerator OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == player.tag){
            //Freeze.
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            yield return new WaitForSeconds(twait);
            player.transform.position = tele_point.transform.position;
            player.transform.GetChild(0).transform.position = player.transform.position;
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
	}
        
	// Update is called once per frame
	void Update () {
		
	}
}
