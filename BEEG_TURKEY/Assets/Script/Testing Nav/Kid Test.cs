using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KidTest : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 3f;
    NavMeshAgent agent;
    Animator animator;

    Random_kid_want rkw;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rkw = GetComponent<Random_kid_want>();

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        // Start the movement when the script begins
        StartCoroutine(MoveWithRandomDelay());
    }

    IEnumerator MoveWithRandomDelay()
    {
        
        while (true)
        {
           MoveToRandomPosition();
           yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        }
    }

    void MoveToRandomPosition()
    {
        // Generate a random point within the navmesh bounds
        Vector2 randomPosition = RandomNavmeshPosition();

        Vector2 direction = (randomPosition - new Vector2(transform.position.x, transform.position.y)).normalized;
        animator.SetFloat("Forward", direction.y);
        animator.SetFloat("Turn", direction.x);
        animator.SetFloat("Velocity", agent.velocity.magnitude);

        // Set the random position as the destination
        agent.SetDestination(randomPosition);
    }

    Vector2 RandomNavmeshPosition()
    {
        // Convert the position to Vector2
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);

        // Initialize the variables to store the random position and the NavMeshHit
        Vector2 randomPosition = Vector2.zero;
        NavMeshHit hit;

        // Try to find a random point within the navmesh bounds
        if (NavMesh.SamplePosition(currentPosition + Random.insideUnitCircle * 10.0f, out hit, 10.0f, NavMesh.AllAreas))
        {
            randomPosition = hit.position;
        }

        return randomPosition;
    }

    private void Update()
    {
        if (rkw.getWant() == Random_kid_want.KidWant.nothing)
        {
            agent.isStopped = false;
            animator.SetFloat("Velocity", agent.velocity.magnitude);
        }
        else
        {
            agent.isStopped = true;
        }
    }
}
