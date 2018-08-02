using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycast : MonoBehaviour {

    public GameObject escapePod1;
    public GameObject particle1;
    public GameObject escapePod2;
    public GameObject particle2;
    public GameObject escapePod3;
    public GameObject particle3;
    public GameObject moveableWall;
    public List<AudioSource> soundList;

    public float podSpeed = 4.0f;

    private float endTimer;
    private bool endState = false;  

    private void Start()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

        RaycastHit hit;

        float distanceOfRay = 2;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distanceOfRay))
        {
            if (Input.GetMouseButtonUp(0) & hit.collider.tag == "Button1")
            {
                Pod1();
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
            if (Input.GetMouseButtonUp(0) & hit.collider.tag == "Button2")
            {
                Pod2();
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
            if (Input.GetMouseButtonUp(0) & hit.collider.tag == "Button3")
            {
                Pod3();
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
            if (Input.GetMouseButtonUp(0) & hit.collider.tag == "Button4")
            {
                Wall();
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
        }
        if (endState == true)
        {
            EndGame();
        }

	}

    private void Pod1()
    {
        Debug.Log("Button 1 pressed");
        escapePod1.GetComponent<Rigidbody>().AddForce(escapePod1.transform.forward * podSpeed);
        particle1.SetActive(true);
        
    }
    private void Pod2()
    {
        Debug.Log("Button 2 pressed");
        escapePod2.GetComponent<Rigidbody>().AddForce(escapePod1.transform.forward * podSpeed);
        particle2.SetActive(true);
    }

    private void Pod3()
    {
        Debug.Log("Button 3 pressed");
        escapePod3.GetComponent<Rigidbody>().AddForce(escapePod1.transform.forward * -podSpeed);
        particle3.SetActive(true);
        endState = true;
        
    }
    private void Wall()
    {
        Debug.Log("Button 4 pressed");
        moveableWall.SetActive(false);
    }

    private void EndGame()
    {
        endTimer += Time.deltaTime;
        Debug.Log(endTimer);
        foreach (var audio in soundList)
        {
            audio.volume -= 0.5f * Time.deltaTime;
            //print(audio.volume + "goingin");
        }
        if (endTimer >= 5)
        {
            Application.Quit();
            Debug.Log("Game over");
        }
    }

}
