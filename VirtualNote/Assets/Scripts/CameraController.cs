using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerObject;            //回転の中心となるプレイヤー格納用
    public float rotateSpeed = 2.0f;            //回転の速さ

    void Update()
    {
        //rotateCameraの呼び出し
        rotatePlayer();
    }
 
    //プレイヤーを回転させる関数
    private void rotatePlayer()
    {
        //Vector3でX,Y方向の回転の度合いを定義
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, 0);
 
        //transform.RotateAround()を使用してメインカメラを回転させる
        playerObject.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        // playerObject.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
    }
}
