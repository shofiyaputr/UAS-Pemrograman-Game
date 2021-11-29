using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player;
    public Transform bg1;

    void Start()
    {
        
    }

    void Update()
    {
        if (player.position.x != transform.position.x && player.position.x > 0 && player.position.x < 12f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, transform.position.y, transform.position.z), 0.1f);
        }
        bg1.transform.position = new Vector2(transform.position.x, bg1.transform.position.y * 1.0f);
    }
}
