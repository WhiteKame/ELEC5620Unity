using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(firstPersonCamera.enabled == true){
                ShowThirdPersonCamera();
            }
            else{
                ShowFirstPersonCamera();
            }
        }
    }

    public void ShowFirstPersonCamera(){
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    public void ShowThirdPersonCamera(){
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = true;
    }
}
