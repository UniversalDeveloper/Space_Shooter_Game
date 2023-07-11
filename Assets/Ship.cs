using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public int hp;//life of ship
    private void CheckHp() 
    {
        if (hp<=0)
        {
            Destroy(gameObject);

        }
    
    }
    public void TakeDamege(int damage) 
    {
        hp -= damage;
        Debug.Log(name+"take"+ damage+ "and have"+hp);
        CheckHp();
    }
}
