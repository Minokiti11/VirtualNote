using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
        
    }
    
    void Update()
    {
        this.transform.LookAt(targetObject.transform);
    }
}
