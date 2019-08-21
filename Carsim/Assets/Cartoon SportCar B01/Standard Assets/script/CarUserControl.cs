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

            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
            //Oculus Touch
            /* 
            // 右人差し指トリガー
            float rTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
            // 右中指トリガー
            float rTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);
            //右アナログスティック
            Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
            if (OVRInput.Get(OVRInput.Button.Two)) //バック走行
            {
                m_Car.Move(stickR[0], -rTrigger2, -rTrigger2, rTrigger1);
            }
            else
            {
                m_Car.Move(stickR[0], rTrigger2, rTrigger2, rTrigger1);
            }
            */

        }
    }
}
