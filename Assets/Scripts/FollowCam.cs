using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform Top;
    public  GameObject Cam;
    Vector3 Mesafe;
    private void Start()
    {
        Mesafe = Cam.transform.position - Top.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Cam.transform.position = Top.transform.position+Mesafe;

    }
}
