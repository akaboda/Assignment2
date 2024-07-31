using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color newColor;
    private SpriteRenderer _spriteRenderer;
    public int score = 0;

    public InputHandler inputHandler;
    public CSVWriter csvWriter;

    private void Start()
    {
        
    }
    public void changeColor(GameObject g)
    {
        if (g.name == "download")
        {
            csvWriter.wrong = 1;
        }
        csvWriter.WriteCSV();
        _spriteRenderer = g.GetComponent<SpriteRenderer>();
        _spriteRenderer.color = new Color(0f, 0f, 1f, 1f);
    }
}
