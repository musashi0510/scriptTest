using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
{
int[] array={10,20,30,40,50};
for(int a= 0;a < 5 ;a++)
{
Debug.Log(array[a]);
}
for(int b=4;b >= 0 ;b--)
{
Debug.Log(array[b]);
}
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
