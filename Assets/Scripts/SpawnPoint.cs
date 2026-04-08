using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public static Vector3 Position;
    public static Quaternion Rotation;

    void Awake()
    {
        Position = transform.position;
        Rotation = transform.rotation;
    }
}

