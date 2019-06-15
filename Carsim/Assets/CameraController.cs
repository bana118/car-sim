using UnityEngine;
using UnityEngine.XR;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    public Transform car;
    private Vector3 offset;
    void Start()
    {
        //Vector3 pos = InputTracking.GetLocalPosition(XRNode.CenterEye);
        //print(pos);
        //print(this.transform.position);
        //this.transform.position -= pos;
        //print(this.transform.position);
        //offset = Camera.main.transform.position - car.position;
    	XRDevice.SetTrackingSpaceType(TrackingSpaceType.Stationary);
        InputTracking.Recenter();
    }

    void Update()
    {
        // Rキーで位置トラッキングをリセットする（Stationaryでしか動作しない）
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            InputTracking.Recenter();
        }*/
        //Camera.main.transform.position = car.position - offset;
    }
}