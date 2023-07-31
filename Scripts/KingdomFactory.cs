using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingdomFactory : MonoBehaviour
{
    private Vector3 pos;
    public float distanceCastles;

    void Start()
    {
        pos = transform.position;
    }

    protected void createArmy(GameObject soldier, int size)
    {
        Vector2 pos = transform.position;
        float root = Mathf.Sqrt(size);
        float rt = root;
        for (int i = 1; i < size + 1; i++)
        {
            Instantiate(soldier, pos, Quaternion.identity);
            if (i > root - 1)
            {
                root += rt;
                pos.x = transform.position.x;
                pos.y -= 200;
            }
            else
                pos.x += 250;
        }
    }

    protected void createCastle(GameObject castle)
    {
        pos.x += distanceCastles;
        pos.z += 10;
        Instantiate(castle, pos, Quaternion.identity);
        pos.z -= 10;
    }

    protected void createKing(GameObject king)
    {
        Instantiate(king, pos, Quaternion.identity);
    }
}
