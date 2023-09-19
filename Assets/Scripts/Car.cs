using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float carSpeed = 10f;
    [SerializeField] private float carSpeedGainPerSecond = .2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarSpeedUp();
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    private void CarSpeedUp()
    {
        carSpeed += carSpeedGainPerSecond * Time.deltaTime;
    }
}
