using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public float speed;
    private float step;
    private Transform target;
    public GameObject targetobj;
    public Vector2 aPosition1 = new Vector2(-4.57f, -0.19f);


    // Start is called before the first frame update
    void Start()
    {

        step = speed * Time.deltaTime;




    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetobj.transform.position, 3 * Time.deltaTime);
    }
}
