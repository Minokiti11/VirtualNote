using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    public GameObject Player;
    Transform playerTrans;
    Vector3 playerPos;
    Transform myTrans;
    Vector3 myPos;
    void Start()
    {
        playerTrans = Player.GetComponent<Transform>();
        playerPos = playerTrans.position;
        myTrans = GetComponent<Transform>();
        myPos = myTrans.position;
    }

    void Update()
    {
        playerTrans = Player.GetComponent<Transform>();
        playerPos = playerTrans.position;
        myTrans = GetComponent<Transform>();
        myPos = myTrans.position;
        myPos.z = playerPos.z;
        myPos.x = playerPos.x + 5;
        myTrans.position = myPos;
    }
}
