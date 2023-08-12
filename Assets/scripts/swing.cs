using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class swing : MonoBehaviour
{
    public GameObject bob;
    public InputField len; 
    public InputField ang;
    private Vector3 cords;
    private float speed = 10;
    private float angle ;
    private float langle;
    private float rangle = 90;
    private float i;
    private float time;
    private float k;
    private float length;
    public float gravity=9.8f;
    // Start is called before the first frame update
    public void Start()
    {
        length= (float.Parse(len.text));
        angle = (float.Parse(ang.text));

        k = angle + 0.01f;
        bob.transform.Rotate(k, 0, 0);
        Debug.Log(angle );
        Debug.Log(length);
        time = math.sqrt(length / gravity);
        speed = ((4 * angle) / time);
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
            transform.Rotate(-speed * Time.deltaTime, 0, 0);
            Debug.Log(langle);



       }
        if (langle < -angle){i = 0;}
        if (i == 0)
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
            Debug.Log(langle);



        }

    }
}