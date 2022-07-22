using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public GameObject player;
    private Rigidbody hareket;
    public float speed;
    private void Start()
    {
      hareket=gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        Force();
    }
    
    void Force()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");
        hareket.AddForce(hInput * Time.deltaTime * speed, 0, vInput * Time.deltaTime * speed);
       
    }
}
