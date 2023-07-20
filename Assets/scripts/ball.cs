using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;

public class ball : MonoBehaviour
{
    public GameObject bob;
    public GameObject string1;
    public GameObject string2;
    private float locationx;
    private Vector3 bobloc;
    private float rotate;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        locationx = (string1.transform.localScale.z - 31);
        rotate =( string2.transform.rotation.x)-90;
        bobloc = string1.transform.position;
        bobloc.y = locationx * -0.049f;
        bob.transform.position = bobloc;
        quaternion rotation=quaternion.Euler(0,rotate,0);
        bob.transform.rotation = rotation;
    }
}