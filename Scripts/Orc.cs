using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Soldier
{
    void Start()
    {
        description = "Orc";
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<Orc>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
