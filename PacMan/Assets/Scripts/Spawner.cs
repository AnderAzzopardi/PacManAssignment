using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject myPrefabObject = null;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(
       myPrefabObject, transform.position,Quaternion.identity); 
    }


     void OnCollisionEnter2D( Collision2D myCol){
     
     if(myCol.gameObject.name == "pacman"){
         Destroy(myCol.gameObject);
        }
 }

    // Update is called once per frame
    void Update()
    {
    
    }




}