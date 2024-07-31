using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputHandler : MonoBehaviour
{
    public ChangeColor changeColor;
    public CSVWriter csvWriter;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }
    void Update()
    {
        csvWriter.time += Time.deltaTime;
    }
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider)
        {
            return;
        }
        else
        {
            csvWriter.Finaltime = csvWriter.time;
            csvWriter.time = 0;
            changeColor.changeColor(rayHit.collider.gameObject);
            Debug.Log(rayHit.collider.gameObject.name);
        }

           
        }
    }

