using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SquareController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Math.Abs(gameObject.transform.position.y) < 0.3f && gameObject.transform.position.x < 20) //deo hieu cai logic cua cai nay no nhu the nao nua
        {
            gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        else if (Math.Abs(gameObject.transform.position.x - 20) < 0.3f && gameObject.transform.position.y > -20) //va^n~ de'o duoc.
        {
            gameObject.transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(2, 2, 2f);
        }

        if (Math.Abs(gameObject.transform.position.y - (-20)) < 0.3f && gameObject.transform.position.x > 0)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(3, 3, 3f);
        }

        else if (Math.Abs(gameObject.transform.position.x) < 0.3f && gameObject.transform.position.y < 0)
        {
            gameObject.transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(4, 4, 4f);
        }
        //cho xoay va scale cac goc
        gameObject.transform.Rotate(0, 0, 15);
    }
}
