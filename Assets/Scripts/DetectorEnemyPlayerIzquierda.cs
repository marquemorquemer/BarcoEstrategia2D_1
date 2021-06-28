using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorEnemyPlayerIzquierda : MonoBehaviour
{
    public float distance;

    public GameObject bullet;

    RaycastHit2D barco;
    void Update()
    {
        barco = Physics2D.Raycast(transform.position, Vector2.left, distance);

        Debug.DrawRay(transform.position, Vector2.left * distance, Color.green);

        if (barco.collider != null)
        {
            if (barco.collider.CompareTag("Player"))
            {
                Invoke("Bullet", 0.5f);
            }
        }
    }

    void Bullet()
    {
        GameObject newBullet;

        newBullet = Instantiate(bullet, transform.position, transform.rotation);
    }
}
