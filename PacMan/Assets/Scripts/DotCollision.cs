using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D( Collider2D myCol){
     
     if(myCol.gameObject.tag == "pacman"){
         Destroy(gameObject);
        }
 }

}
