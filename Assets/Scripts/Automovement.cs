using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automovement : MonoBehaviour
{
    public GameObject main_camera;
    public GameObject center;

    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 angle=new Vector3(0.0f,20f,0.0f);
        main_camera.transform.RotateAround(center.transform.position,Vector3.up,Time.deltaTime*speed);
        
    }
}
