using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacman : MonoBehaviour
{

    //Making him move with up down left and right arrow keys
    [SerializeField] public KeyCode pressUp;
  [SerializeField]  public KeyCode pressDown;
   [SerializeField] public KeyCode pressLeft;

   [SerializeField] public KeyCode pressRight;
    
    // Making him move with WASD

    [SerializeField] public KeyCode pressW;
    [SerializeField] public KeyCode pressS;
    [SerializeField] public KeyCode pressA;

    [SerializeField] public KeyCode pressD;






    [SerializeField] float movementSpeed = 15f;

    float xMin, xMax, yMin, yMax ; 
    float padding = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
       SetUpBoundaries(); 
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //Making him move with up down left and right arrow keys

    if (Input.GetKeyDown(pressUp))
        GetComponent<Transform>().eulerAngles = new Vector3 (0,0,90);

     if (Input.GetKeyDown(pressDown))
        GetComponent<Transform>().eulerAngles = new Vector3 (0,0,-90);

     if (Input.GetKeyDown(pressLeft))
        GetComponent<Transform>().eulerAngles = new Vector3 (0,0,180);

     if (Input.GetKeyDown(pressRight))
        GetComponent<Transform>().eulerAngles = new Vector3 (0,0,0);

     // Making him move with WASD
     if (Input.GetKeyDown(pressW))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);

     if (Input.GetKeyDown(pressS))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -90);

     if (Input.GetKeyDown(pressA))
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 180);

     if (Input.GetKeyDown(pressD))
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);




    }


    private void SetUpBoundaries()
    {
        Camera gameCamera = Camera.main;
        
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;

        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }




   // Moving left and right -  X axis
    private float MoveX()
    {
        float deltaX = Input.GetAxis("Horizontal")*Time.deltaTime* movementSpeed ;
        float newXPos = transform.position.x + deltaX;

        return newXPos;


    }
    
    
    // Moving up and down -  Y axis
    private float MoveY()
    {
        float deltaY = Input.GetAxis("Vertical")*Time.deltaTime* movementSpeed;
        float newYPos = transform.position.y + deltaY;

        return newYPos;


    }


    //clamping the values between yMin and yMax
    private void Move()
    {
        float xPos = Mathf.Clamp(MoveX(), xMin, xMax);
        float yPos = Mathf.Clamp(MoveY(), yMin, yMax);
        
        transform.position = new Vector2(xPos, yPos);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "pacman")
        {
            transform.position = new Vector3(0, 0, 0);//(where you want to teleport)
        }
    }

}
