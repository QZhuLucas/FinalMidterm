using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(0.0f, 0.04500008f, -3.45f);
    }
}