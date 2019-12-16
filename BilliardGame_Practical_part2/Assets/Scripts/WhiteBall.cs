using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : MonoBehaviour
{


    ColouredBall white;
    int x;
    int y;
    // Start is called before the first frame update
    void Start()
    {
    x  = Random.Range(-1,1);
    y  = Random.Range(15,20);

     white = FindObjectOfType<ColouredBall>();
    }

    // Update is called once per frame
    void Update()
    {
        LaunchBall();
        
        
    }

    private void LaunchBall(){
        if(Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(x,y);
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        white.DestroyBallWhenItHitsHole(collision, gameObject);
        
    }



  
}
