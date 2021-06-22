using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHaciaMouse : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    Vector3 target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
