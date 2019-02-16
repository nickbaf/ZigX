using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Rigidbody theBody;
    private bool walkingRight = true;

    public Transform aRay;
    private Animator anime;
    public GameObject crystal;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        theBody = GetComponent<Rigidbody>();
        anime = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate()
    {

        if (!gameManager.gStarted)
        {
            return;
        }
        else {

            anime.SetTrigger("hasStarted");
            theBody.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
        }

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

        if (transform.position.y < -2)
        {
            gameManager.EndGame();
        }
    }

    private void Turn()
    {
        if (!gameManager.gStarted)
        {
            return;
        }
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


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crystal")
        {

            gameManager.increaseScore();
            GameObject g = Instantiate(crystal, aRay.transform.position, Quaternion.identity);
            Destroy(g,2);
            Destroy(other.gameObject);
        }
    }
}
