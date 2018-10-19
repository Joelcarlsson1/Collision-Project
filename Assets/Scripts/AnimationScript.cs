using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("VadNiVill", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("VadNiVill", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Triggered");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetInteger("Najs", 16);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetInteger("Najs", 15);
        }
    }
}
