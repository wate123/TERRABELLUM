using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int startHealth = 3;
    [HideInInspector]public int currentHealth;
    private bool isDead = false;

	void Awake () {
        currentHealth = startHealth;
	}
	
    public void TakeDamage(){
        currentHealth -= 1;

        if (currentHealth <= 0 && !isDead){
            Dead();
        }
    }
    void Dead(){
        isDead = true;

        //player dead sound;

        //goto dead animation

    }

	// Update is called once per frame
	void Update () {
		
	}
}
