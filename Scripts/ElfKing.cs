using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfKing : King
{
    void Start()
    {
        description = "Elf King";
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<Elf>())
        {
            if (collision.gameObject.GetComponent<OrcKing>())
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
                hp -= 1;
                if (hp == 0)
                    Destroy(gameObject);
            }
        }
    }
}
