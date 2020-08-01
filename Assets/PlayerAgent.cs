using UnityEngine;
using UnityEngine.AI;

public class PlayerAgent : MonoBehaviour
{

    [SerializeField]
    private Transform END;

    void Start ()
    {
        var playerAgent = GetComponent<NavMeshAgent>();
        playerAgent.destination = END.position;
    }
}