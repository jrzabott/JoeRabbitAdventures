using UnityEngine;

public class CameraMoviment : MonoBehaviour
{
    public float cameraSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
