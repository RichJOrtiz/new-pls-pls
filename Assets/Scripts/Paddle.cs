using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    //configuration parameters
    [SerializeField] float screenWidthUnits = 16f; //16 because camera size is 6 and playing on 4:3, f used for float
    [SerializeField] float minPaddlePos = 1f;
    [SerializeField] float maxPaddlePos = 15f;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*take x pos of mouse and divide by width to get value from 0-1 and then multiply by width
        to see x pos of mouse in world units */
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        //clamp is used to restrict something idk how to describe it :(
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minPaddlePos, maxPaddlePos);
        
        transform.position = paddlePos;
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
