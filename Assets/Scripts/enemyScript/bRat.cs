using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script is the base rat script and all the
/// other rats would inherit from this script
/// </summary>
public class bRat : MonoBehaviour
{
    [SerializeField] private string ratName = "ratDad";
    [SerializeField] protected float moveSpeed = 0.5f;
    [SerializeField] protected float distance = 20;

    public Transform target;

    // At the start, find the player


   protected virtual void FindPlayer()
    {
        target = GameObject.FindGameObjectWithTag("Player")?.GetComponent<Transform>();
        if (target == null)
        {
            Debug.Log("Player not found! Make sure the player has the 'Player' tag.");
        }
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        if (target != null && Vector2.Distance(transform.position, target.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
        else if (target == null)
        {
            Debug.Log("Target is null. Ensure the player is tagged correctly.");
        }
    }
}
