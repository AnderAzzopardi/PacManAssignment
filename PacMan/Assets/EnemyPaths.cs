using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaths : MonoBehaviour
{
    public AudioClip deathClip;
    [SerializeField] Transform[] waypoints;

    [SerializeField] float enemySpeed = 2f;

    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set the Enemy position to the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, enemySpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }
        if (waypointIndex == waypoints.Length)
            waypointIndex = 0;

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // Remove health by 1
        GameControl.health -= 1;

        //Play death sound
        AudioSource.PlayClipAtPoint(deathClip, transform.position);

        //telport pac man to startng point
        
    }


}