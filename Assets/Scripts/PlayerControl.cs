using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rigBod;
    public float moveInputH;
    public float moveInputV;
    public bool canInteract;
    [SerializeField] public float speed;
    
    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<Rigidbody2D>();
        canInteract = false;
    }

    // Update is called once per frame
    public void Update()
    {
        moveInputH = Input.GetAxis("Horizontal");
        moveInputV = Input.GetAxis("Vertical");

        rigBod.velocity = new Vector2(moveInputH * speed, moveInputV * speed);

        if(canInteract == true && Input.GetKeyDown(KeyCode.I))
        {

        }
    }

    
}
