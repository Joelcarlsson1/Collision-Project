using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public Rigidbody2D rBody;
    //Add force = Putta saker, relativ till skärmen
    //Add relative force = Putta saker, relativ till gubben
    //Add torque = rotation
    //Move position/roation = sätter rotation/position
    //Velocity = Vilken hastighet objektet har
    //Angular velocity = Vilken hastighet snurrar objektet
    // Use this for initialization
    void Start()
    {
        //rBody.AddForce(new Vector2(0, 20f), ForceMode2D.Impulse);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }       
    }
    //Allt med fysik ska in här, 50 gånger i sekund
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
        rBody.AddForce(new Vector2(10f, 0f));   
        }
        if (Input.GetKey(KeyCode.A))
        {
            rBody.AddForce(new Vector2(-10f, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rBody.AddForce(new Vector2(0f, 10f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rBody.AddForce(new Vector2(0f, -10f));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("You suck");
        SceneManager.LoadScene("SampleScene");
    }
}


