using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoInicialFinal : MonoBehaviour
{
    //declaração de variáveis
    public Transform goal;
    public float speed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pega a direção do objetivo e caminha até lá, quando estiver próximo o suficiente ele para.
        Vector3 direction = goal.position - this.transform.position;
        if(direction.magnitude > 0.2)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        
    }
}
