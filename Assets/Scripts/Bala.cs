using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Barco barco;

    public int damage = 1;
    public float speed = 10;
    public string target;
    public float timeToDestroy = 3;

    public Vector2 direction;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(target))
        {
            Health health = other.GetComponent<Health>();
            if (health == null)
                return;
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (barco.canons)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        if (barco.canons1)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

    }
    public void DirectionBullet(Vector2 dir)
    {
        direction = dir;
    }
}
