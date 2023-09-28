using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;


public class HelperScript : MonoBehaviour
{

    public void FlipObject( bool flip )
    {
        FlipObject( gameObject, flip );
    }


    public void FlipObject(GameObject obj, bool flip )
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        sr.flipX = flip;
    }


    public bool IsFacingLeft()
    {
        return GetComponent<SpriteRenderer>().flipX;
    }


    public void MakeBullet( GameObject prefab,  float xpos, float ypos, float xvel, float yvel )
    {
        // instantiate the object at xpos,ypos
        GameObject instance = Instantiate(prefab, new Vector3(xpos,ypos,0), Quaternion.identity);
        
        // set the velocity of the instantiated object
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3( xvel, yvel, 0 );

        // set the direction of the instance based on the x velocity
        FlipObject( instance, xvel<0);
    }


    


}
