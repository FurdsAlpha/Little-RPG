using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float life;
    public float damage;

    public GameObject[] AttaquePanel;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        AttaquePanel = GameObject.FindGameObjectsWithTag("Attaque Panel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage()
    {
        life -= 1;
    }

    public void OnAttaquePanel()
    {
        AttaquePanel[0].SetActive(true);
        AttaquePanel[0].transform.position = this.transform.position + offset;
        AttaquePanel[0].transform.parent = this.transform;
    }
}
