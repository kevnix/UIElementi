using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour {
    public GameObject bean, lacis, tante, masina, paKreisi, paLabi, mainigaisAttels, sizeSlider, rotationSlider;
    public Sprite[] imageArray;

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

    public void drop(int index)
    {
        mainigaisAttels.GetComponent<Image>().sprite = imageArray[index];
    }

    public void changeSize()
    {
        float currSize = sizeSlider.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * currSize, 1f * currSize);
    }

	public void changeRotation(){
		float curr = rotationSlider.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localRotation = Quaternion.Euler (0, 0, curr * 360);
	}
}
