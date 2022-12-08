using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsedCamera : MonoBehaviour
{
    [SerializeField]
    KeyCode ChangeCameraMode;
    bool FirstPerson = true;
    bool ThirdPerson = false;
    public bool OverWiew = false;
    bool NoSpam;
    public Camera FirtPersonCamera;
    public Camera ThirdPersonCamera;
    public Camera OverWeiwCamera;
    [SerializeField]
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(ChangeCameraMode))
        {
            //BehindThirdPerson
            if (FirstPerson == true && NoSpam == false)
            {
                FirstPerson = false;
                FirtPersonCamera.enabled = false;
                ThirdPerson = true;
                ThirdPersonCamera.enabled = true;
                

                NoSpam = true;
                StartCoroutine(NoSpaming());
            }
            //ThirdPerson
            else if (ThirdPerson == true && NoSpam == false)
            {
                ThirdPerson = false;
                ThirdPersonCamera.enabled = false;
                OverWiew = true;
                OverWeiwCamera.enabled = true;

                NoSpam = true;
                StartCoroutine(NoSpaming());
            }
            //FirstPerson
            else if (OverWiew == true && NoSpam == false)
            {
                FirstPerson = true;
                FirtPersonCamera.enabled = true;
                FirtPersonCamera.transform.rotation =
                OverWiew = false;
                OverWeiwCamera.enabled = false;

                NoSpam = true;
                StartCoroutine(NoSpaming());
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            gameObject.transform.Rotate(90, 0, 0);
        }
    }
    IEnumerator NoSpaming()
    {
        yield return new WaitForSeconds(2.00f);
        NoSpam = false;
    }
}
