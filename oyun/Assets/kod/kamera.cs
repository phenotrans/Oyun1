 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {
    Vector2 farePos;
    Vector2 gecisPos;
    public float hassasiyet = 0.05f;
    public float yumusaklik = 0.5f;
    GameObject player;
    void Start ()
    {
        player = this.transform.parent.gameObject;      
	}
	
	void Update ()
    {
        Vector2 md = new Vector2(Input.GetAxis("Axis 1"), 0);
        md = Vector2.Scale(md, new Vector2(hassasiyet * yumusaklik, hassasiyet * yumusaklik));
        gecisPos.x = Mathf.Lerp(gecisPos.x,md.x,1f/yumusaklik);
        farePos += gecisPos;
        player.transform.localRotation = Quaternion.AngleAxis(farePos.x,player.transform.up);
    }
}
