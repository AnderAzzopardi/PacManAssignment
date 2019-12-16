using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColouredBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
   


    public void DestroyBallWhenItHitsHole(Collision2D collision, GameObject ball)
    {

        if (collision.gameObject.tag == "hole")
        {
            
             Destroy(ball);
        }

        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        DestroyBallWhenItHitsHole(collision, gameObject);
        
    }

}
