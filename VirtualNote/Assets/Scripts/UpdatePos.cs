using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePos : MonoBehaviour
{
    public GameObject Avatar;
    public Vector3 AvatarPos;
    RectTransform rectTransform;

    void Start()
    {
        rectTransform = gameObject.GetComponent<RectTransform>();
        Debug.Log(this.gameObject.name);
        Debug.Log(rectTransform.localPosition);
    }

    void Update()
    {
        AvatarPos = rectTransform.localPosition;
        AvatarPos.z = AvatarPos.y;
        AvatarPos.y = 6.5f;
        Avatar.transform.position = AvatarPos;
    }
}
