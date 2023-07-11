using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject shotPref;
    public Transform firePoint;
    public float attackRate;
    private float innerAttackRate = 0;

    // Update is called once per frame
    void Update()
    {
        if (innerAttackRate>= attackRate)
        {
            Instantiate(shotPref,firePoint.position,Quaternion.identity     );
            innerAttackRate = 0;
        }
        innerAttackRate += Time.deltaTime;
    }
}
