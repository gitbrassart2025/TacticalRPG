using System;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class S_TurnSystem : MonoBehaviour
{
    public int turnCount;
    public int playerCount;

    //array avec tous les joueurs
    GameObject[] entityList;
    public int activeEntity;
    private bool trie;

    GameObject EntityPlaying;

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
            NouveauTour();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            NextPlayer(entityList);
        }
    }

    private void Awake()
    {
        //Trouve tous les gameobject avec le tag "entity" et les met dans la liste
        entityList = GameObject.FindGameObjectsWithTag("Entity");
        EntityPlaying = entityList[activeEntity];
    }

    public void NouveauTour()
    {
        turnCount++;
        activeEntity = 0;
        Debug.Log("Compte +1");
        Debug.Log("Joueur actif : " + activeEntity);

        //Debug
        /*for (int i = 0; i < entityList.Length; i++)
        {
            Debug.Log("avant tri : " + entityList[i]);
        }*/
        TriInitiative(entityList);

        //Debug
        /*for (int i = 0; i < entityList.Length; i++)
        {
            Debug.Log("après tri : " + entityList[i]);
        }*/
    }

    //Tri bulles parce que c'est rigolo les bulles
    private void TriInitiative(GameObject[] laListe)
    {
        trie = false;
        for (int i = 0; i < laListe.Length; i++) 
        {
            if (trie)
                return;
            for (int j = 0; j < laListe.Length - 1; j++) 
            {
                trie = true;
                if(laListe[j+1].GetComponent<S_EntityTest>().speed > laListe[j].GetComponent<S_EntityTest>().speed)
                {
                    GameObject temp = laListe[j+1];
                    laListe[j+1] = laListe[j];
                    laListe[j] = temp;
                    trie = false;
                }
            }
        }
    }

    private void NextPlayer(GameObject[] laListe)
    {
        if (activeEntity < laListe.Length - 1)
        {
            activeEntity++;

            //code pour passer au joueur d'après
            EntityPlaying = laListe[activeEntity];

            Debug.Log("Joueur actif : " + activeEntity);
        }
        else
        {
            NouveauTour();
        }
    }
}
