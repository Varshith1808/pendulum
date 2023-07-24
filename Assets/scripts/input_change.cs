using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input_change : MonoBehaviour
{
   public  InputField hi;
    private float temp;
    public GameObject Bob;
    private Vector3 cord=new Vector3(40f,40f,1f);
    private Vector3 cord1;
    private Vector3 cord2=new Vector3(0,0,0);
    private Vector3 cord3;
    public GameObject string1;
    // Start is called before the first frame update
    

    // Update is called once per frame
  public  void change()
    {
       temp=(float.Parse(hi.text));
        cord1=cord;
        cord1.z = cord1.z + temp;
        string1.transform.localScale = cord1;
        cord3 = cord2;
        temp = temp / 100;
        cord3.y -= temp ;
        Bob.transform.position = cord3;
    }
}
