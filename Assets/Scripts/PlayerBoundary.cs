using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    public Vector3 minBoundary; // Giới hạn tối thiểu (xmin, ymin, zmin)
    public Vector3 maxBoundary; // Giới hạn tối đa (xmax, ymax, zmax)

    void Update()
    {
        Vector3 position = transform.position;

        // Kiểm tra và giới hạn vị trí của Player trong các giới hạn đã xác định
        position.x = Mathf.Clamp(position.x, minBoundary.x, maxBoundary.x);
        position.y = Mathf.Clamp(position.y, minBoundary.y, maxBoundary.y);
        position.z = Mathf.Clamp(position.z, minBoundary.z, maxBoundary.z);

        transform.position = position;
    }
}

