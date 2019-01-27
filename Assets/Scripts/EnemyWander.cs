using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWander : MonoBehaviour {
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
        animator = GetComponent<Animator>();
        InvokeRepeating("Wander", 0, 0.5f);
	}


    void Wander () {
        current.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        current.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-wanderSpeedRange, wanderSpeedRange), 0);
    }


	
	// Update is called once per frame
	void Update () {
        //current.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-wanderSpeedRange, wanderSpeedRange) * Time.deltaTime, 0);
	}
}
