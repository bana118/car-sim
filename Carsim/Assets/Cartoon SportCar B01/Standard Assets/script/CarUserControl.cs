using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");

            //m_Car.Move(h, v, v, handbrake);
#else
            //m_Car.Move(h, v, v, 0f);
#endif
            //Oculus Touch

            // 右人差し指トリガー
            float rTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
            // 右中指トリガー
            float rTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);
            // 左人差し指トリガー
            float lTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
            // 左中指トリガー
            float lTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);
            if (OVRInput.GetDown(OVRInput.RawButton.A))
            {
                Debug.Log("Aボタンを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.B))
            {
                Debug.Log("Bボタンを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.X))
            {
                Debug.Log("Xボタンを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.Y))
            {
                Debug.Log("Yボタンを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.Start))
            {
                Debug.Log("メニューボタン（左アナログスティックの下にある）を押した");
            }

            if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
            {
                Debug.Log("右人差し指トリガーを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
            {
                Debug.Log("右中指トリガーを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
            {
                Debug.Log("左人差し指トリガーを押した");
            }
            if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
            {
                Debug.Log("左中指トリガーを押した");
            }
            if(OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote)){
                Debug.Log("右コントローラー接続");
            }
            if(OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote)){
                Debug.Log("左コントローラー接続");
            }
            m_Car.Move(0, rTrigger1, rTrigger1, 0f);

        }
    }
}
