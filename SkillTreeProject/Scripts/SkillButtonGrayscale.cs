using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButtonGrayscale : MonoBehaviour
{
    [SerializeField] private Material material;

    void Awake()
    {
        Image image = GetComponent<Image>();
        material = Instantiate(image.material);
        image.material = material;
    }

    public void MakeButtonGrayscale()
    {
        material.SetFloat("Grayscale", 1);
    }

    public void MakeButtonColor()
    {
        material.SetFloat("Grayscale", 0);
    }

}
