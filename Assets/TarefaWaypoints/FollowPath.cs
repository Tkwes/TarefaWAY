using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPath : MonoBehaviour
{
    //variaveis
    public GameObject wpManager; //objeto com script
    GameObject[] wps; //list
    NavMeshAgent agent; //recebe o objeto do navemesh

    //Transform goal;
    //float speed = 5.0f;
    //float accuracy = 1.0f;
    //float rotSpeed = 2.0f;
    //GameObject currentNode;
    //int currentWP = 0;
    //Graph g;

    void Start()
    {
        //atribuido componente na inicializaçao// 
        agent = GetComponent<NavMeshAgent>();


        //buscando variaveis do script wpmanager e atribuidos ao script //
        wps = wpManager.GetComponent<WPManager>().waypoints;


        //g = wpManager.GetComponent<WPManager>().graph;
        //currentNode = wps[0];
    }

    //metodo de movimentação a novo ponto //
    public void GoToHeli()
    {
        //setando posicao no nav usando o way//
        agent.SetDestination(wps[0].transform.position);


        //g.AStar(currentNode, wps[0]);
        //currentWP = 0;
    }
    //metodo de movimentação a novo ponto //
    public void GoToRuin()
    {
        //setando posicao no nav usando o way//
        agent.SetDestination(wps[10].transform.position);


        //g.AStar(currentNode, wps[10]);
        //currentWP = 0;
    }
    //metodo de movimentação a novo ponto //
    public void GoToTanks()
    {
        //setando posicao no nav usando o way//
        agent.SetDestination(wps[6].transform.position);
         

        //g.AStar(currentNode, wps[6]);
        //currentWP = 0;
    }

    void LateUpdate()
    {
        //if(g.getPathLength() == 0 || currentWP == g.getPathLength())
        //{
        //    return;
        //}
        //currentNode = g.getPathPoint(currentWP);

        //if(Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        //{
        //    currentWP++;
        //}
        //if(currentWP < g.getPathLength())
        //{
        //    goal = g.getPathPoint(currentWP).transform;
        //    Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        //    Vector3 direction = lookAtGoal - this.transform.position;
        //    // fazendo o tanque virar para o waypoint
        //    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        //    // fazendo o tanque ir ate o waypoint
        //    this.transform.Translate(0, 0, speed * Time.deltaTime);
        //}
    }
}
