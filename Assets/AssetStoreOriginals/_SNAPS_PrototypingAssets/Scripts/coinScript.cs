using UnityEngine;

public class coinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") //We check for a tag so we know we aren't colliding with a wall. Can be removed if necessary, but should
                                  //just add a Player tag to the player game objects.
        {
            Destroy(gameObject);
            Debug.Log("player collected the coin!");
        }
    }
}
