using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bRat : MonoBehaviour
{
    [SerializeField] private string ratName;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float distance;

    public Transform target;

    // At the start, find the player
    protected virtual void Start()
    {
        FindPlayer();
    }

    void FindPlayer()
    {
        target = GameObject.FindGameObjectWithTag("Player")?.GetComponent<Transform>();
        if (target == null)
        {
            Debug.LogError("Player not found! Make sure the player has the 'Player' tag.");
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
            Debug.LogWarning("Target is null. Ensure the player is tagged correctly.");
        }
    }
}
