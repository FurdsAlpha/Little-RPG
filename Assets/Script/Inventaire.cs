using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Arme { none, EpeeSimple, EpeeDouble, ArcSimple }
public enum Armure { none, Poison, Flamme, Gel }
public class Inventaire : MonoBehaviour
{
    //[Header("Script Afillier")]
    private bool onInventaire = false;
    public GameObject inventaireGUI;

    public void OnInventaire()
    {
        if(onInventaire == false)
        {
            onInventaire = true;
            this.transform.position -= new Vector3(600, 0, 0);
            Debug.Log("L'inventaire s'ouvre");
        }
        else
        {
            onInventaire = false;
            this.transform.position += new Vector3(600, 0, 0);
            Debug.Log("L'inventaire se ferme");
        }
    }
    public void checkOnInventaire()
    {
        if (this.transform.position.x >= -10)
        {
            onInventaire = false;
            Debug.Log("l'inventaire est fermé");
        }
        else
        {
            onInventaire = true;
            Debug.Log("l'inventaire est ouvert");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        checkOnInventaire();
    }

    // Update is called once per frame
    void Update()
    {

    }
   
   
    public void ArmeEquiper()
    {

    }
}
