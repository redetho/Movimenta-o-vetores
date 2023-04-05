using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoInicialFinal : MonoBehaviour
{
    //declara��o de vari�veis
    public Transform goal;
    public float speed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pega a dire��o do objetivo e caminha at� l�, quando estiver pr�ximo o suficiente ele para.
        Vector3 direction = goal.position - this.transform.position;
        if(direction.magnitude > 0.2)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        
    }
}
