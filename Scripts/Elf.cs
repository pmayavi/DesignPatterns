using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Soldier
{
    void Start()
    {
        description = "Elf";
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<Elf>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
