using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaremaControl : MonoBehaviour
{
    private float vertical;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = speed * Input.GetAxis("Mouse Y");
        transform.Rotate(vertical, 0, 0);
    }
}
