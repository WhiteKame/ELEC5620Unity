using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModel : MonoBehaviour
{
    public GameObject model1;
    public GameObject model2;
    // Start is called before the first frame update
    void Start()
    {
        model2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            if(model2.activeInHierarchy == true){
                    SwitchModel1();
                }
                else{
                    SwitchModel2();
                }
        }
    }

    public void SwitchModel1(){
        model1.SetActive(true);
        model2.SetActive(false);
    }

    public void SwitchModel2(){
        model1.SetActive(false);
        model2.SetActive(true);
    }
}
