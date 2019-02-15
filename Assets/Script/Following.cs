using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{

    public Transform player;
    private Vector3 offset;


    void Awake()
    {

        offset = transform.position - player.position;
        
    }

    private void LateUpdate() //used for cameras
    {
        transform.position = player.position + offset;
    }
}
