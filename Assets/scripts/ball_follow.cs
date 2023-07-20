using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_follow : MonoBehaviour
{
    public GameObject bob;
    public GameObject string1;
    private float locationx;
    private Vector3 bobloc;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        locationx = (string1.transform.localScale.z-57);
        bobloc = bob.transform.position;
        bobloc.y = locationx * -0.049f;
        bob.transform.position = bobloc;    
    }
}
