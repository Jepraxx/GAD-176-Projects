using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script will be responsible for generating rats later on
/// </summary>

public class generator : MonoBehaviour
{
    float timer = 1;
    public GameObject[] gObj;

    void FixedUpdate()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
        else
        {
            
            int chance = Random.Range(1, 101);
            float pos_x = Random.Range(-4.0f, 4.0f);

            if (chance <= 20)
            {
                Instantiate(gObj[0], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            timer = 2f;// Interval of the spawn timer
        }
    }
}

