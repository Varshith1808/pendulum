using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class rotate_slider : MonoBehaviour
{
    public Slider scale;
    private float a;


    void Update()
    {
        a = scale.value * 50f;
       this.transform.rotation = quaternion.Euler(a, -90, -90);
        
    }
}
