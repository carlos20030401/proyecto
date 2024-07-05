using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IA : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;


    public Transform[] destinations;


    private int i = 0;

    [Header("------------FollowPlayer-------------")]

    public bool followPlayer;

    public float distanceToFollowPath = 2;
    private GameObject player;

    private float distanceToPalyer;

    public float disatnceToFollowPlayer =10;


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPalyer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPalyer <= disatnceToFollowPlayer && followPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }
    }

    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].position;
        if (Vector3.Distance(transform.position, destinations[i].position) <= distanceToFollowPath)
        {
            if (destinations[i] != destinations[destinations.Length - 1] )
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }

    }


    public void FollowPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }


    public void GrenadeImpact()
    {
        Destroy(gameObject);
    }
}
