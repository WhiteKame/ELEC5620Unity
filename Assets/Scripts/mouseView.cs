using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseView : MonoBehaviour
{

    private float horizontal;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = speed * Input.GetAxis("Mouse X");

        transform.Rotate(0, horizontal, 0);
    }
}
