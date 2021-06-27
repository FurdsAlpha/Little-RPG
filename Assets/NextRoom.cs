using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{
    public GameObject MyCamera;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        MyCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        MyCamera.transform.position += new Vector3(0,10,0);
    }
}
