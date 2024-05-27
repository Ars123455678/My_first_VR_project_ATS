using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InstructionList : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt;
    [SerializeField] private RawImage img;
    
    public void Setup(string text, Texture screen, int id)
    {
        txt.text = $"Инструкция по сборке \n Шаг {id} \n {text}";
        img.texture = screen;
    }
}