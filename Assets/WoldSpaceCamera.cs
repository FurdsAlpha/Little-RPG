using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoldSpaceCamera : MonoBehaviour
{
    Camera MyCamera;
    Canvas self;
    // Start is called before the first frame update
    void Start()
    {
        self = this.gameObject.GetComponent<Canvas>();
        MyCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        self.worldCamera = MyCamera;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
