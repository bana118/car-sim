using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class ViewCurrentSpeed : MonoBehaviour
{
    public CarController m_Car;
    private Text speedViewer;
    // Use this for initialization
    private void Awake()
    {
        speedViewer = GetComponent<Text>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int currentSpeed = (int)m_Car.CurrentSpeed;
        speedViewer.text = currentSpeed.ToString() + "km/h";
    }
}
