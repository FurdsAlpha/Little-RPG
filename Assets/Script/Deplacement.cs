using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    [Header("Déplacement Basique")]
    public Rigidbody rigidBody;
    public Vector2 direction;
    public float speed;
    [Header("Deplacement Combat")]
    public GameObject adversaire;
    public GameObject Player;
    public GameObject poinDAncrage;
    public LineRenderer ligne;
    public Armes arme;
    Rigidbody rb;

    private void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        Player = this.gameObject;
        //SetPoinEncrage();
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        //transform.RotateAround(poinDAncrage.transform.position, new Vector3(0,0,direction), 20 * Time.deltaTime);
        //SetLignePosition();
        rigidBody.velocity = direction * speed;
    }

    /*public void SetLignePosition()
    {
        ligne.SetPosition(0, Player.transform.position + new Vector3(0, 0,1));
        ligne.SetPosition(1, adversaire.transform.position + new Vector3(0,0,1));
    }*/
    public void OnMove(InputValue value)
    {
        Vector2 Mouvement = value.Get<Vector2>();
        direction = new Vector2(Mouvement.x, Mouvement.y);
    }
    public void OnAttaque()
    {

    }

    /*public void SetPoinEncrage()
    {
        poinDAncrage.transform.position = adversaire.transform.position + Player.transform.position;
        poinDAncrage.transform.position = poinDAncrage.transform.position / 2;
    }*/

    public void SetAdvairsaire()
    {

    }
    /*
     * Player
     * rigidbody
     * speed
     * direction
     * 
     * combat
     * adversaire
     * direction
     * point encrage
     * 
     * 
     * 
     */
}
