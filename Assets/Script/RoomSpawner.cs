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

    private RoomTemplate Templates;
    private int rand;
    public bool Spawned;

    public void Start()
    {
        Templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        Invoke("Spawn", 0.2f);
    }
    public void Spawn()
    {
        if (Spawned == false)
        {
            if (OpeningDirection == 1)
            {
                rand = Random.Range(0, Templates.DownRoom.Length);
                Instantiate(Templates.DownRoom[rand], transform.position, Templates.DownRoom[rand].transform.rotation);
                //Debug.Log("Un Room avec une porte vers le bas");
            }
            else if (OpeningDirection == 2)
            {
                rand = Random.Range(0, Templates.UpRoom.Length);
                Instantiate(Templates.UpRoom[rand], transform.position, Templates.UpRoom[rand].transform.rotation);
                //Debug.Log("Un Room avec une porte vers le heut");
            }
            else if (OpeningDirection == 3)
            {
                rand = Random.Range(0, Templates.LeftRoom.Length);
                Instantiate(Templates.LeftRoom[rand], transform.position, Templates.LeftRoom[rand].transform.rotation);
                //Debug.Log("Un Room avec une porte vers la Gauche");
            }
            else if (OpeningDirection == 4)
            {
                rand = Random.Range(0, Templates.RightRoom.Length);
                Instantiate(Templates.RightRoom[rand], transform.position, Templates.RightRoom[rand].transform.rotation);
                //Debug.Log("Un Room avec une porte vers la droite");
            }
            Spawned = true;
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<RoomSpawner>().Spawned == false && Spawned == false == Spawned == false)
        {
            Destroy(gameObject);
        }
        else if (other.GetComponent<RoomSpawner>().Spawned == false && Spawned == false)
        {
            Instantiate(Templates.closedRoom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        Spawned = true;
    }
}

