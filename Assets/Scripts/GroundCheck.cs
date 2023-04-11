using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 6)
        { 
            isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 6)
        { 
            isOnGround = false;
        }
    }
}
