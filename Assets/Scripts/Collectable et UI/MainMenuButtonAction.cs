﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtonAction : MonoBehaviour
{
    public Button[] boutonNiveau;
    public Button[] collectables;
    void start()
    {
        int niveauActuelle = PlayerPrefs.GetInt("niveauActuelle", 1);

        for (int i = 0; i < boutonNiveau.Length; i++)
        {
            boutonNiveau[i].interactable = false;
        }

        for (int i = 0; i < niveauActuelle - 1; i++)
        {
            boutonNiveau[i].interactable = true;
        }

        if(PlayerPrefs.GetInt("coin") > 0)
        {
            collectables[1].interactable = true;
        }
        if (PlayerPrefs.GetInt("ring") > 0)
        {
            Debug.Log(PlayerPrefs.GetInt("ring"));
            collectables[0].interactable = true;
        }
    }




    /// <summary>
    /// Permet d'afficher un panel transmis en paramètre
    /// </summary>
    /// <param name="PanelAOuvrir">Panel à afficher</param>
    public void AfficherPanel(GameObject PanelAOuvrir)
    {
        PanelAOuvrir.SetActive(true);
    }

    /// <summary>
    /// Permet de ferme aussi le panel actuel
    /// </summary>
    /// <param name="PanelAFermer">Panel à fermer</param>
    public void FermerPanel(GameObject PanelAFermer)
    {
        PanelAFermer.SetActive(false);
    }

    /// <summary>
    /// Permet de charger un niveau
    /// </summary>
    /// <param name="nom">Nom du niveau à charger</param>
    public void ChargerNiveau(string nom)
    {
        SceneManager.LoadScene(nom);
    }

    /// <summary>
    /// Permet de fermer l'application
    /// </summary>
    public void Quitter()
    {
        Application.Quit();
    }

}
