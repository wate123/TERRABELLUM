using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {
    public float direction;
    public float force;
    //private bool isClick = false;

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        if (Input.GetMouseButton(0)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-direction, direction), Random.Range(force, force+20)));
            //isClick = true;
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        //yield return new WaitForSeconds(2f);
        //isClick = false;

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
