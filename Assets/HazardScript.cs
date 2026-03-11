using UnityEditor.Tilemaps;
using UnityEngine;

public class HazardScript : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D RB;
    
    void Update()
    {
        // if (transform.position.x > Player.transform.position.x)
        //     transform.position += new Vector3(-0.1f, 0, 0);
        
        // transform.position = Vector3.MoveTowards(transform.position,
        //     Player.transform.position, Time.deltaTime * 3);

        Vector2 vel = new Vector2(0, 0);
        vel = Player.transform.position - transform.position;
        vel = vel.normalized * 3;
        RB.linearVelocity = vel;
    }
}
