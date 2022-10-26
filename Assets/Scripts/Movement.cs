using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private GameObject gameObject;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject = GameObject.Find ("User");
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(new Vector3(0,0,moveSpeed*Time.deltaTime));
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(new Vector3(0,0,-moveSpeed*Time.deltaTime));
        }

        if(Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(new Vector3(-moveSpeed*Time.deltaTime,0,0));
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(new Vector3(moveSpeed*Time.deltaTime,0,0));
        }
    }
}
