using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link
{
    public enum direction { UNI, BI}
    public GameObject node1;
    public GameObject node2;
    public direction dir;
}
public class WPManager : MonoBehaviour
{
    // variaveis
    public GameObject[] waypoints; // list de pontos 
    public Link[] links; //links de direcionamento 
    public Graph graph = new Graph(); //pega o componente

    void Start()
    {
        //troca de pontos apos chegadas 
        if(waypoints.Length > 0)//condicional 
        {
            foreach(GameObject wp in waypoints)//compara os way e posicao 
            {
                graph.AddNode(wp);
            }
            foreach(Link l in links)//condicional 
            {
                graph.AddEdge(l.node1, l.node2);
                if(l.dir == Link.direction.BI)
                {
                    graph.AddEdge(l.node2, l.node1);
                }
            }
        }
    }

    void Update()
    {
        //Cria a linha 
        graph.debugDraw();
    }
}
