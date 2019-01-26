using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float wanderSpeedRange;
    public float alertDistance;
    private GameObject player;
    private Transform current;

    // control animation
    private Animator animator;
    private AudioClip au;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        current = transform;
        InvokeRepeating("Wander", 0, 0.5f);
	}

    void Wander () {
        Debug.Log("ss");
        current.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-wanderSpeedRange, wanderSpeedRange), 0);
    }

    void Alert () {
        if (Vector2.Distance(player.transform.position, current.position) <= alertDistance ){
            Vector2.MoveTowards(current.position, new Vector2(player.transform.position.x, 0), alertDistance);
        }else {
            // animation on wander

        }
    }
	
	// Update is called once per frame
	void Update () {
        current.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-wanderSpeedRange, wanderSpeedRange) * Time.deltaTime, 0);
	}
}
