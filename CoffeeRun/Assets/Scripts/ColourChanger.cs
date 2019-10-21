using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColourChanger : MonoBehaviour
{


    public float speed;
    public Color firstCol;
    public Color secondCol;
    public bool repeat;
    float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Finish") { 

        if (!repeat)
        {

            float t = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(firstCol, secondCol, t);



        }
        else {

            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(firstCol, secondCol, t);

        }

        }
    }


}
