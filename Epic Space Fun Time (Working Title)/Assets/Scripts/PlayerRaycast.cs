using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour {

    public GameObject escapePod1;
    public GameObject particle1;
    public GameObject escapePod2;
    public GameObject particle2;
    public GameObject escapePod3;
    public GameObject particle3;

    public float podSpeed = 4.0f;


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
            if (Input.GetMouseButton(0) & hit.collider.tag == "Button1")
            {
                Pod1();
            }
            if (Input.GetMouseButton(0) & hit.collider.tag == "Button2")
            {
                Pod2();
            }
            if (Input.GetMouseButton(0) & hit.collider.tag == "Button3")
            {
                Pod3();
            }
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
    }
}
