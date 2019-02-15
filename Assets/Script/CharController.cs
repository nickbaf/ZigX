using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Rigidbody theBody;
    private bool walkingRight = true;
    // Start is called before the first frame update
    void Awake()
    {
        theBody = GetComponent<Rigidbody>();

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
