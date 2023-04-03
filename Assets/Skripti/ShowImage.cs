using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour {
    public GameObject bean;
    public GameObject lacis;
    public GameObject tante;
    public GameObject masina;
    public GameObject paKreisi;
    public GameObject paLabi;

    public void BeanImage(bool vertiba)
    {
        bean.SetActive(vertiba);
        paKreisi.GetComponent<Toggle>().interactable = vertiba;
        paLabi.GetComponent<Toggle>().interactable = vertiba;
    }

    public void LacisImage(bool vertiba)
    {
        lacis.SetActive(vertiba);
    }

    public void TanteImage(bool vertiba)
    {
        tante.SetActive(vertiba);
    }

    public void MasinaImage(bool vertiba)
    {
        masina.SetActive(vertiba);
    }

    public void PaKreisiBean()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }

    public void PaLabiBean()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
}
