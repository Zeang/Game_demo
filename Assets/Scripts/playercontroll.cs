using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroll : MonoBehaviour {
    public const int HERO_UP = 0;
    public const int HERO_RIGHT = 1;
    public const int HERO_DOWN = 2;
    public const int HERO_LEFT = 3;

    public float speed;
    private int count;
    public Text counttext;
	// Use this for initialization
	void Start () {
        count = 0;
        setCounttext();
	}
    void setCounttext()
    {
        counttext.text = "count:" + count;
    }
	
	// Update is called once per frame
	void Update () {
  
		
	}
    void FixedUpdate()
    {
        float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveh, 0.0f, movev);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
  
        if (other.tag == "pickup")
        {
            other.gameObject.SetActive(false);
            count++;
            setCounttext();
        }
    }
}
