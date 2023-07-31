using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcKing : King
{
    void Start()
    {
        description = "Orc King";
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<Orc>())
        {
            if (collision.gameObject.GetComponent<ElfKing>())
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
