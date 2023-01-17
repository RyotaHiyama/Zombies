using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class test : MonoBehaviour
{
    //float CameraZoomSpeed = 15.0f;
    [SerializeField] Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Zoom();
        }    
    }

    void Zoom()
    {
        float z = cam.transform.localPosition.z + 10;
        cam.transform.localPosition = new Vector3(cam.transform.localPosition.x,
                                                  cam.transform.localPosition.y,
                                                  z);
    }
}
