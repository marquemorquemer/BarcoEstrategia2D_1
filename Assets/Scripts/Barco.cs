using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour
{
    public Transform canons;
    public Transform canons1;
    public GameObject canon;
    public GameObject canonL;
    public GameObject canonR;

    public bool isPlayer = true;
    public float timeToShoot = 3;


    // Start is called before the first frame update
    void Start()
    {
        if (!isPlayer)
        {
            StartCoroutine(ShootingEnemy());
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        //{
        //    Instantiate(canon, canons.position, canons.rotation);
        //    Instantiate(canon, canons1.position, canons1.rotation);
        //}
        if (isPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                canonL.SetActive(true);
                canonR.SetActive(false);
                Instantiate(canon, canons.position, canons.rotation);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                canonR.SetActive(true);
                canonL.SetActive(false);
                Instantiate(canon, canons1.position, canons1.rotation);
            }

        }
    }

    void ShootBullet(Vector2 dir)
    {
        GameObject bulletGO = Instantiate(canon, canons.position, canons.rotation);
        bulletGO.GetComponent<Bullet>().DirectionBullet(dir);
        if (isPlayer)
        {
            bulletGO.GetComponent<Bullet>().target = "Enemy";
        }
        //if (!isPlayer)
        //{
        //    bulletGO.GetComponent<Bullet>().target = "Player";
        //}
    }

    IEnumerator ShootingEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToShoot);
            Instantiate(canon, canons.position, canons.rotation);
        }
    }
}
