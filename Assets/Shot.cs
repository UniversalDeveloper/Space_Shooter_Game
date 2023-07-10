using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public int direction;
    public float force;
    
    void Start()
    {
        FindObjectOfType<Rigidbody2D>().AddForce(Vector2.up*direction*force );
    }

}
