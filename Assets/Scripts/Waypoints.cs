using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    //declara vari�veis
    public Transform[] points;
    public float speed;
    private int currentPoint = 0;
    public Material[] othermat;
    private int num = 0;
    void Update()
    {
        //enquanto tiver pontos para serem visitados, o loop continua
        if(currentPoint < points.Length)
        {
            //caminha at� o ponto, quando alcan�a a mesma posi��o, atualiza para o novo ponto e troca o material.
            transform.position =  Vector3.MoveTowards(transform.position, points[currentPoint].position, speed * Time.deltaTime);
            if(transform.position == points[currentPoint].position)
            {
                currentPoint++;

                GetComponent<Renderer>().material = othermat[num++];
            }
        }
       
    }
}
