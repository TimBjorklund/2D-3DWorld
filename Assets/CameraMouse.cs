using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouse : MonoBehaviour
{
    public float Sensitivity = 100f;
    [SerializeField]
    Transform Head;
    float xRotation = 0f;
    bool FirstPerson;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Head.Rotate(Vector3.up * mouseX);
    }
}
