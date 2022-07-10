using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSelectorText : MonoBehaviour
{
    public Text text;
    string[] AllPlayers = new string[] { "GK", "CB1", "CB2", "RSB", "LSB", "CMF1", "CMF2", "DMF", "RWG", "LWG", "CF" }; // 4-3-3
    public int PlayerNum = 0;
    private string PlayerPosition;
    public GameObject camera;
    public Vector3 cameraOffset;
    private Transform cameraTrans;
    public LookAt lookAt;
    public GameObject playerObject;            //回転の中心となるプレイヤー格納用
    public float rotateSpeed = 2.0f;            //回転の速さ

    void Update()
    {
        playerObject = GameObject.Find (AllPlayers[PlayerNum]);
        text.text = AllPlayers[PlayerNum];
        cameraTrans = camera.transform;
        cameraTrans.parent = playerObject.transform;
        cameraTrans.position = playerObject.transform.position + cameraOffset;

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
    
    public void Plus()
    {
        if (PlayerNum == 10)
        {
            PlayerNum = 0;
        }
        else
        {
            PlayerNum ++;
        }
    }
    public void Minus()
    {
        if (PlayerNum == 0)
        {
            PlayerNum = 10;
        }
        else
        {
            PlayerNum --;
        }
    }
}
