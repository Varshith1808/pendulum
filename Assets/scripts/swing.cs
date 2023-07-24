using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class swing : MonoBehaviour
{
    public GameObject bob;
    private Vector3 cords;
    private float speed = 10;
    public float angle ;
    private float langle;
    private float rangle = 90;
    private float i;
    private float j=0;
    private float k;
    // Start is called before the first frame update
    private void Start()
    {
        k = angle + 0.01f;
        bob.transform.Rotate(k, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        langle = (bob.transform.rotation.eulerAngles.x) ;
        if (langle>=180)
        {
            langle =( langle- 360);
        }
// rangle = bob.transform.rotation.eulerAngles.x-(2*langle);
      
       if (langle > angle)
        { 
            i = 1;
          
        }
       if (i==1)
        {
            transform.Rotate(-30 * Time.deltaTime, 0, 0);
            Debug.Log(langle);



       }
        if (langle < -angle){i = 0;}
        if (i == 0)
        {
            transform.Rotate(30 * Time.deltaTime, 0, 0);
            Debug.Log(langle);



        }

    }
}