using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject targetObject;
    
    public void LookAtCenter(GameObject obj)
    {
        obj.transform.LookAt(targetObject.transform);
    }
}
