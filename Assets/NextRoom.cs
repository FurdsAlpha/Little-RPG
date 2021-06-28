using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{
    public GameObject[] Enemys;
    private GameObject MyCamera;
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
        if (other.tag == "Player")
        {
            MyCamera.transform.position = this.transform.position + new Vector3(0, 0, -10);
            Enemys[0].SetActive(true);
            Enemys[1].SetActive(true);
            Enemys[2].SetActive(true);
        }
    }
}
