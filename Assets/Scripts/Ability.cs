using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour {
    private RaycastHit2D hit2D;
	// Use this for initialization
	void Start () {
		
	}
	
    void ForcePush (){
        
    }

    void Projectile (){
        hit2D = Physics2D.Raycast(transform.position, Vector2.right);
        if (hit2D.collider != null){
            
        }
    }

    void Shield (){
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
