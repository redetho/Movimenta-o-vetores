using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform goal;
    public float speed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;
        if (direction.magnitude > 0.2)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
    private void OnMouseDown()
    {
        Destroy (this.gameObject);
    }
}
