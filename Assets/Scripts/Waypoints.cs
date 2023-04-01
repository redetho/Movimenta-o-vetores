using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public Transform[] points;
    public float speed;
    private int currentPoint = 0;
    public Material[] othermat;
    private int num = 0;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(currentPoint < points.Length)
        {
            transform.position =  Vector3.MoveTowards(transform.position, points[currentPoint].position, speed * Time.deltaTime);
            if(transform.position == points[currentPoint].position)
            {
                currentPoint++;

                GetComponent<Renderer>().material = othermat[num++];
            }
        }
       
    }
}
