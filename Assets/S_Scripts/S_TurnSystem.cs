using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class S_TurnSystem : MonoBehaviour
{
    public int turnCount;
    public int playerCount;
    //array avec tous les joueurs
    public float[] idPlayers;
    GameObject[] entityList;
    //Dictionnaire qui contient les personnages et leurs informations relatives au tour + un vecteur jsp pk je fais ça mais ça peut servir heiiin
    private Dictionary<Vector3Int, GameObject> entitiesDictionary = new Dictionary<Vector3Int, GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            turnCount++;
            Debug.Log("Compte +1");
            for (int i = 0; i < entityList.Length; i++) 
            {
                Debug.Log(entityList[i]);
            }

            //TriInitiative(entitiesDictionary);
        }
    }

    private void Awake()
    {
        // Search for all waypoints. Warning, there is a 's' after Object.
        entityList = GameObject.FindGameObjectsWithTag("Entity");
    }

    /*
    private void TriInitiative(List<GameObject> laListe)
    {
        for (int i = 0; i < laListe.Count; i++) 
        {
            for (int j = 0; j < laListe.Count; j++) 
            {
                if(laListe[i]. < laListe[j])
                {
                    laListe.
                }
            }
        }
    }*/
}
