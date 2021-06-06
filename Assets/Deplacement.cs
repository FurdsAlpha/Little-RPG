using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public GameObject goUpButton;
    public GameObject goRightButton;
    public GameObject goLeftButton;
    public GameObject goDownButton;

    private Transform _other;
    // Recuperer les salle via RoomsTemplate
    //Pour chaque salle de x Derection ajouter le bouton corespondant

    public void GoUpButton()
    {
        Instantiate(goUpButton, _other.position + new Vector3 (0,3,0), Quaternion.identity);
    }
    
    public void GoRightButton()
    {
        Instantiate(goRightButton, _other.position + new Vector3 (0,7,0), Quaternion.identity);
    }
    
}
