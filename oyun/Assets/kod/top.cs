using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class top : MonoBehaviour {
    
    public bool haraket = true;
    private Rigidbody rg;
    public float hız;
    public GameObject puan;
    public Text puantext;
    private int poin;

	
	void Start () {
        rg = GetComponent<Rigidbody>();
        poin = 0;
        SetCountText();
	}
	
	
	void Update ()
    {
        if (Input.GetAxis("Axis 1") > 0f)
            Debug.Log("değer geliyor");
        rg.transform.Translate(Input.GetAxis("Axis 1") *hız*Time.deltaTime,0,0-(Input.GetAxis("Axis 2") *hız*Time.deltaTime));
        //rg.transform.Translate(Input.acceleration.x*hız*Time.deltaTime,0,0-(Input.acceleration.z*hız*Time.deltaTime));	
        //rg.transform.Translate(Input.GetAxis("Horizontal") * hız * Time.deltaTime, 0, Input.GetAxis("Vertical") * hız * Time.deltaTime);
       // rg.transform.Rotate(transform.localRotation.x,transform.localRotation.y, Input.GetAxis("Vertical") * hız * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Application.LoadLevel(0);
        }
        if (collision.gameObject.tag == "point")
        {
            Destroy(collision.gameObject);
            poin = poin + 1;
            Debug.Log("puan geldi");
            SetCountText();
        }
    }
    void SetCountText()
    {
        puantext.text = "Puan: " + poin.ToString();
        
    }
}
