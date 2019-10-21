using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockChange : MonoBehaviour
{
    public float speed;
    public Color firstCol;
    public Color secondCol;
    public bool repeat;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
     {

     
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Finish")
        {

            if (!repeat)
            {

                float t = (Time.time - startTime) * speed;
                GetComponent<Renderer>().material.color = Color.Lerp(firstCol, secondCol, t);



            }
            else
            {

                float t = (Mathf.Sin(Time.time - startTime) * speed);
                GetComponent<Renderer>().material.color = Color.Lerp(firstCol, secondCol, t);

            }

        }
    }
}

     

