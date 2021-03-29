using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int OpeningDirection;
    // 1 == Down Door needed
    // 2 == Top Door needed
    // 3 == Left Door needed
    // 4 == Right Door needed

    public RoomTemplate Template;
    public GameObject _Template;
    private int rand;
    public bool Spawned;

    public void Start()
    {
        _Template = GameObject.FindGameObjectWithTag("Rooms");
        Template = _Template.GetComponent<RoomTemplate>();
        Invoke("Spawn", 0.1f);
    }
    public void Spawn()
    {

        if (Spawned == false)
        {

            if (OpeningDirection == 1)
            {
                Instantiate(Template.DownRoom[rand], transform.position, Template.DownRoom[rand].transform.rotation);
            }
            else if (OpeningDirection == 2)
            {
                Instantiate(Template.UpRoom[rand], transform.position, Template.UpRoom[rand].transform.rotation);
            }
            else if (OpeningDirection == 3)
            {
                Instantiate(Template.LeftRoom[rand], transform.position, Template.LeftRoom[rand].transform.rotation);
            }
            else if (OpeningDirection == 4)
            {
                Instantiate(Template.RightRoom[rand], transform.position, Template.RightRoom[rand].transform.rotation);
            }
            Spawned = true;
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().Spawned == true)
        {
            Destroy(gameObject);
        }
    }
}

