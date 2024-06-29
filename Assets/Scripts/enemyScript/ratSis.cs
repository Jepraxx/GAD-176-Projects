using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ratSis : bRat
{
    
    protected override void Start()
    {
        base.Start(); // Call the base class Start method
      
    }

    
    protected override void Move()
    {
        if (target != null && Vector2.Distance(transform.position, target.position) < distance)
        {
            //ratSis moves in a zigzag pattern towards the player
            float zigzagFrequency = 5f;
            float zigzagMagnitude = 0.5f;
            Vector2 zigzag = new Vector2(Mathf.Sin(Time.time * zigzagFrequency) * zigzagMagnitude, 0);
            transform.position = Vector2.MoveTowards(transform.position + (Vector3)zigzag, target.position, moveSpeed * Time.deltaTime);
        }
    }
}
