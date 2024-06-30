using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// This script is entirely dedicated for ratBro and this 
/// script would inherit from the base rat script and would override
/// the move method that the base rat script has
/// </summary>
public class ratBro : bRat
{
    
    protected override void FindPlayer()
    {
        base.FindPlayer(); // Call the base find player method

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
