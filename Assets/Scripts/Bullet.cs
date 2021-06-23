using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public Vector3 direction;

    public Rigidbody2D rb;
    public float speed;
    public string target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            if (health == null)
                return;
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
        else
        {
            Health health = other.GetComponent<Health>();
            if (health == null)
                return;
            health.TakeDamage(damage);
            Destroy(gameObject);
        }

    }

    public void DirectionBullet(Vector2 dir)
    {
        direction = dir;
    }
}
