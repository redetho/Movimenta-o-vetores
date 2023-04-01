using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCor : MonoBehaviour{public Material mat;    private void OnCollisionEnter(){GetComponent<Renderer>().material = mat;}}
