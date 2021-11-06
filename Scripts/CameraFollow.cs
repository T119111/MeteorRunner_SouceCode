using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーを追従
        if (player != null)
        {
            Vector3 targetPos = player.position + offset;
            targetPos.x = 0;
            targetPos.y = 4;
            transform.position = targetPos;
        }
    }
}
