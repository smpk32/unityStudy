using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;

    public Camera mainCamera;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        InvokeRepeating("PrintString",2, 1f);
        
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;

        if (Input.GetMouseButton(0))
        {

            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {

                Vector3 dir = new Vector3(hit.point.x, transform.position.y, hit.point.z); //방향 구하기

                transform.position = dir;
            }

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            CheckInvoke();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            StopInvoke();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }

    public void PrintString()
    {
        Debug.Log("1111");
    }

    public void StopInvoke()
    {
        CancelInvoke("PrintString");
        Debug.Log("STOP");
    }
    public void CheckInvoke()
    {
        Debug.Log("Invoke 상태 : " + IsInvoking("PrintString"));
    }



    
}
