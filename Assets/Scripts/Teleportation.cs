using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    // declaring objects
    public GameObject Portal; 
    public GameObject Player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        // when the portal collides with object tagged "player," the object teleports
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Teleport ());
        }
        
    }

    IEnumerator Teleport() // function that activate teleport
    {
        yield return new WaitForSeconds(0.5f); // time it takes when player teleports
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y); // allows player to be moved into a different location
    }

}
