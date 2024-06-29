using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ratBro : bRat
{
    
    protected override void Start()
    {
        base.Start(); // Call the base class Start method
        
    }

    
    protected override void Move()
    {
        if (target != null && Vector2.Distance(transform.position, target.position) < distance)
        {
            //ratBro moves towards the player faster than the base class
            float modifiedSpeed = moveSpeed * 1.5f;
            transform.position = Vector2.MoveTowards(transform.position, target.position, modifiedSpeed * Time.deltaTime);
        }
    }
}
