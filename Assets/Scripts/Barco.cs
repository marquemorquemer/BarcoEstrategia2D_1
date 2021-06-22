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




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        //{
        //    Instantiate(canon, canons.position, canons.rotation);
        //    Instantiate(canon, canons1.position, canons1.rotation);
        //}
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
