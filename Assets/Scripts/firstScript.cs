using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour {

    public float distance;
    public int count;
    public string message;
    private bool finished;
    public GameObject the_aliveworm;
    public GameObject the_deadworm;

	// Use this for initialization
	void Start () {

         Debug.Log("Hello asshole");
/*
         // distance = 1.25f;
          Debug.Log("the distance value is " + distance);

          count = 25;
          Debug.Log("the count is " + count);

          message = "this is fun";
          Debug.Log(message);

          finished = false;
          Debug.Log("The Value of finished is: " + finished);

            if (count == 0) {
                Debug.Log("the variable is 0");
            }
            else
            {
                Debug.Log("the variable count is not 0");
            }
*/
        //funtions
        int anumber;     //Create an integer variable to store the return value from the function
        anumber = double_it(5);
        Debug.Log("the doubled value is " + anumber);
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if ( Input.GetKey ("right") || Input.GetKey("d"))
        {
            Flip("right");
            transform.Translate(.2f, 0f, 0f);
        }
        if (Input.GetKey("left")||Input.GetKey("a"))
        {
            Flip("left");
            transform.Translate(-.2f, 0f, 0f);
        }
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            transform.Translate(0f, 0.2f, 0f);
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            transform.Translate(0f, -0.2f, 0f);
        }
    }

    public void Flip(string direction)
    {
        var thescale = transform.localScale;

        if(direction =="right")
        {
            thescale.x = 1;
        }
        if(direction == "left")
        {
            thescale.x = -1;
        }
        transform.localScale = thescale;
    }

    int double_it(int input_number)
    {
        var temp = input_number * 2;
        return temp;
    }

    private void OnCollisionEnter2D(Collision2D what_the_bird_hit) 
    {
        if(what_the_bird_hit.gameObject.name == "theworm")
        {
            Debug.Log("OnCollisionEnter2D was called");
            the_aliveworm.SetActive(false);
            the_deadworm.SetActive(true);
        }
        if(what_the_bird_hit.gameObject.name == "launchtree")
        {
            Debug.Log("OnCollisionEnter2D was called");
            the_aliveworm.SetActive(true);
            the_deadworm.SetActive(false);
        }
    }
}
