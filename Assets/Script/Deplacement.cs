using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    [Header("Déplacement Setting")]
    public Rigidbody rigidBody;
    public Vector2 MovementDirection;
    public float speed;
    [Header("Combat Setting")]
    public GameObject adversaire;
    public GameObject Self;
    public GameObject poinDAncrage;
    public LineRenderer ligne;
    public float TurnDirection;
    public Armes arme;

    private void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        Self = this.gameObject;
        poinDAncrage = GameObject.FindGameObjectWithTag("PointEncrage");
        SetPoinEncrage();
    }

    void Update()
    {
        if (adversaire == true)
        {
            Move();
        }
        else
        {
            SetLignePosition();
            Turn();
        }
    }

    
    public void OnMove(InputValue value)
    {
        Vector2 Mouvement = value.Get<Vector2>();
        MovementDirection = new Vector2(Mouvement.x, Mouvement.y);
    }
    public void Move()
    {
        rigidBody.velocity = MovementDirection * speed;
    }
    public void OnAttaque()
    {

    }
    public void OnTurn()
    {
        TurnDirection = 1f;
    }
    
    public void OnResetPointEncrage()
    {
        SetPoinEncrage();
    }
    
    public void Turn()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(poinDAncrage.transform.position, new Vector3(0,0,TurnDirection), 20 * Time.deltaTime);
        rigidBody.velocity = MovementDirection * 0.5f;
    }

    public void SetPoinEncrage()
    {
        poinDAncrage.transform.position = (adversaire.transform.position + Self.transform.position)/2;
    }

    public void SetLignePosition()
    {
        ligne.SetPosition(0, Self.transform.position + new Vector3(0, 0, 1));
        ligne.SetPosition(1, adversaire.transform.position + new Vector3(0, 0, 1));
    }
}
