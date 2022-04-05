using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler
{
    //攻撃時の座標の初期値
    public Vector3 AttackPos;
    //守備時の初期値
    public Vector3 DefensePos;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

}
