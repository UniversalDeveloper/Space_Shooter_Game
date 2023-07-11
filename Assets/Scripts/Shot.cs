using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public int damege;
    public int direction;
    public float force;
    public float lifeTime;
    
    void Start()
    {
        FindObjectOfType<Rigidbody2D>().AddForce(Vector2.up*direction*force );
        Destroy(gameObject,lifeTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Enemy")||collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Ship>().TakeDamege(damege);
            Destroy(gameObject );
        }  
    }
}
