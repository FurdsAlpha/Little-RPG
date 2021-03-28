using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float life;
    public float damage;

    public GameObject AttaquePanel;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
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
        Instantiate(AttaquePanel, new Vector3(this.transform.position.x, this.transform.position.y, 0) + offset, Quaternion.identity);
    }
}
