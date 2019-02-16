using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Rigidbody theBody;
    private bool walkingRight = true;

    public Transform aRay;
    private Animator anime;
    // Start is called before the first frame update
    void Awake()
    {
        theBody = GetComponent<Rigidbody>();
        anime = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        theBody.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Turn();
        }

        RaycastHit hit;
        if(!Physics.Raycast(aRay.position,-transform.up,out hit, Mathf.Infinity)) //if there is no hit on ground
        {
            anime.SetTrigger("hasGround");
        }
    }

    private void Turn()
    {
        walkingRight = !walkingRight;
        if (walkingRight)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);

        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);
        }
    }
}
