using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Deplacement : MonoBehaviour
{
    [Header("Déplacement Settings")]
    public Rigidbody rigidBody;
    public Vector2 MovementDirection;
    public float speed;
    [Header("Combat Settings")]
    public bool enCombat;
    public GameObject adversaire;
    public GameObject Self;
    public GameObject poinDAncrage;
    public LineRenderer ligne;
    public float TurnDirection;
    public Armes arme;
    public float distance;
    [Header("UI Settings")]
    public GameObject attackPanel;
    public TextMeshProUGUI A;
    public TextMeshProUGUI Z;
    public TextMeshProUGUI E;
    public TextMeshProUGUI R;


    private void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        Self = this.gameObject;
        poinDAncrage = GameObject.FindGameObjectWithTag("PointEncrage");
        SetPoinEncrage();
    }

    void Update()
    {
        if (enCombat == true)
        {
            Turn();
            SetLignePosition();
            SetText();
        }
        else
        {
            Move();
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
        SetText();
    }

    public void SetPoinEncrage()
    {
        poinDAncrage.transform.position = (adversaire.transform.position + Self.transform.position)/2;
    }

    public void SetLignePosition()
    {
        ligne.SetPosition(0, Self.transform.position + new Vector3(0, 0, 1));
        ligne.SetPosition(1, adversaire.transform.position + new Vector3(0, 0, 1));
        distance = Mathf.Abs(adversaire.transform.position.x - Self.transform.position.x) + Mathf.Abs(adversaire.transform.position.y - Self.transform.position.y);

        if (arme is ArmeLongRange)
        {
            ArmeLongRange o = arme as ArmeLongRange;
            if (distance < o.DistanceIdeal.y & distance > o.DistanceIdeal.y)
            {
                ligne.material = ligne.materials[0];
            }
            else if (distance > o.DistanceAcceptable.y & distance < o.DistanceAcceptable.y)
            {
                ligne.material = ligne.materials[1];
            }
            else
            {
                ligne.material = ligne.materials[2];
            }
        }
        if (arme is ArmeMidRange)
        {
            ArmeMidRange o = arme as ArmeMidRange;
            if (distance > o.DistanceIdeal.y & distance < o.DistanceIdeal.y)
            {
                ligne.material = ligne.materials[0];
            }
            else if (distance > o.DistanceAcceptable.y & distance < o.DistanceAcceptable.y)
            {
                ligne.material = ligne.materials[1];
            }
            else
            {
                ligne.material = ligne.materials[2];
            }
        }
        if (arme is ArmeLowRange)
        {
            ArmeLowRange o = arme as ArmeLowRange;
            if (distance > o.DistanceIdeal.y & distance < o.DistanceIdeal.y)
            {
                ligne.material = ligne.materials[0];
            }
            else if (distance > o.DistanceAcceptable.y & distance < o.DistanceAcceptable.y)
            {
                ligne.material = ligne.materials[1];
            }
            else
            {
                ligne.material = ligne.materials[2];
            }
        }
    }
    public void SetText()
    {
        A.SetText(arme.A);
        Z.SetText(arme.Z);
        E.SetText(arme.E);
    }
}
