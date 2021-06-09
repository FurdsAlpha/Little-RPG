using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{

    public GameObject adversair;
    public GameObject Player;
    public GameObject poinDAncrage;
    public float direction;
    public LineRenderer ligne;

    private void Start()
    {
        poinDAncrage.transform.position = adversair.transform.position + Player.transform.position;
        poinDAncrage.transform.position = poinDAncrage.transform.position / 2;
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(poinDAncrage.transform.position, new Vector3(0,0,direction), 20 * Time.deltaTime);
        SetLignePosition();
        //Debug.Log(Move.ToString());
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Player.transform.position, adversair.transform.position);
    }

    public void SetLignePosition()
    {
        ligne.SetPosition(0, Player.transform.position + new Vector3(0, 0,1));
        ligne.SetPosition(1, adversair.transform.position + new Vector3(0,0,1));
        Debug.Log("La ligne a corectement été positioné");
    }
    public void OnMove(InputValue value)
    {
        direction = value.Get<float>();
        Debug.Log(value.Get<float>());
    }
}
