using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    [Header("Deplacement Setting")]
    public GameObject adversaire;
    public GameObject Player;
    public GameObject poinDAncrage;
    private float direction;
    public LineRenderer ligne;
    public Armes arme;

    private void Start()
    {
        Player = this.gameObject;
        SetPoinEncrage();
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(poinDAncrage.transform.position, new Vector3(0,0,direction), 20 * Time.deltaTime);
        SetLignePosition();
    }

    public void SetLignePosition()
    {
        ligne.SetPosition(0, Player.transform.position + new Vector3(0, 0,1));
        ligne.SetPosition(1, adversaire.transform.position + new Vector3(0,0,1));
    }
    public void OnMove(InputValue value)
    {
        direction = value.Get<float>();
    }

    public void SetPoinEncrage()
    {
        poinDAncrage.transform.position = adversaire.transform.position + Player.transform.position;
        poinDAncrage.transform.position = poinDAncrage.transform.position / 2;
    }

    public void SetAdvairsaire()
    {

    }
}
