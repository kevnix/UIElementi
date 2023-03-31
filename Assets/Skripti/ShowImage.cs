using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImage : MonoBehaviour {
    public GameObject bean;
    public GameObject lacis;
    public GameObject tante;
    public GameObject masina;

    public void BeanImage(bool vertiba)
    {
        bean.SetActive(vertiba);
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
}
