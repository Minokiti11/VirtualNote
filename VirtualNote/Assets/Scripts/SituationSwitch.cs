using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SituationSwitch : MonoBehaviour
{
    string situation;
    //親オブジェクト(PlayersImage)
    [SerializeField] private GameObject parentObject;
    Drag drag;

    public void SwitchOffence()
    {
        //各プレイヤーを攻撃の座標に設置
        foreach (Transform childTransform in parentObject.transform) //各プレイヤーオブジェクトを取得
        {
            drag = childTransform.gameObject.GetComponent<Drag>();
            if (childTransform.gameObject.name.Contains("Other"))
            {
                childTransform.gameObject.transform.position = transform.TransformPoint(drag.DefensePos);
            }
            else
            {
                childTransform.gameObject.transform.position = transform.TransformPoint(drag.AttackPos);
            }
            
        }
        situation = "Offence";
    }

    public void SwitchDeffence()
    {
        //各プレイヤーを守備の座標に設置する
        foreach (Transform childTransform in parentObject.transform) //各プレイヤーオブジェクトを取得
        {
            drag = childTransform.gameObject.GetComponent<Drag>(); //Dragコンポーネントを取得
            if (childTransform.gameObject.name.Contains("Other"))
            {
                childTransform.gameObject.transform.position = transform.TransformPoint(drag.AttackPos);
            }
            else
            {
                childTransform.gameObject.transform.position = transform.TransformPoint(drag.DefensePos);
            }
            
        }
        situation = "Defense";
    }

    public void ResetPosition()
    {
        foreach (Transform childTransform in parentObject.transform) //各プレイヤーオブジェクトを取得
        {
            drag = childTransform.gameObject.GetComponent<Drag>();
            if (childTransform.gameObject.name.Contains("Other"))
            {
                if (situation == "Offence")
                {
                    childTransform.gameObject.transform.position = transform.TransformPoint(drag.DefensePos);
                }
                else if (situation == "Defense")
                {
                    childTransform.gameObject.transform.position = transform.TransformPoint(drag.AttackPos);
                }
            }
            else
            {
                if (situation == "Offence")
                {
                    childTransform.gameObject.transform.position = transform.TransformPoint(drag.AttackPos);
                }
                else if (situation == "Defense")
                {
                    childTransform.gameObject.transform.position = transform.TransformPoint(drag.DefensePos);
                }
            }

        }
    }
}
