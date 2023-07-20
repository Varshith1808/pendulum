using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Slider scale;
    private float a;

    // Start is called before the first frame update

    
    
    // Update is called once per frame
    void Update()
    {
        a = scale.value*50;
        Vector3 newscale = new Vector3(40, 48,a+60);
        this.transform.localScale = newscale;

    }
}
