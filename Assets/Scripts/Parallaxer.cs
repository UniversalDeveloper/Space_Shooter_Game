using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour
{
    public GameObject backgroundPref;
    public List< GameObject> background;
    public float speed;
    public int count;
    public float distance;
   // public float distanceToRotate;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            SpawnBackground(new Vector3(0, distance*i,0));
        }        
    }
    private void CheckRotete() 
    {
        float minY = float.MaxValue;
        GameObject lowestBg = null;
        foreach (var bg in background)
        {
            if (bg.transform.position.y<minY)
            {
                minY = bg.transform.position.y;
                lowestBg = bg;
            }
        }
        if (minY<=-distance)
        {
            RotateBackGround(lowestBg);
        }
    }

    private void RotateBackGround(GameObject bgToRotate) 
    {
        float maxY = float.MinValue;
        foreach (var bg in background)
        {
            if (bg.transform.position.y>maxY)
            {
maxY = bg.transform.position.y;
            }
            
        }
        Vector2 pos = bgToRotate.transform.position;
        pos.y = maxY + distance;
        bgToRotate.transform.position = pos;
    
    
    }
    private void SpawnBackground(Vector3 pos)
    {
    GameObject bg=Instantiate(backgroundPref ,pos, Quaternion.identity);
        background.Add(bg); 
    
    }
    private void FixedUpdate()
    {
        Shift();
        CheckRotete();
    }
    private void Shift()
    {
        foreach (var bg in background)
        {
Vector2 pos = bg.transform.position;
        pos.y -= speed * Time.fixedDeltaTime;
        bg.transform.position = pos;
        }
        
    
    }
    
}
