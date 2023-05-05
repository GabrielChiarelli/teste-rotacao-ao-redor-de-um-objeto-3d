using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_Mouse : MonoBehaviour
{
    private Camera cameraDoJogo;

    [SerializeField] private float distanciaDaCamera;

    private Vector3 ultimaPosicao;

    private void Awake()
    {
        cameraDoJogo = GetComponent<Camera>();
    }

    void Update()
    {
        RotacionarCamera();
    }

    private void RotacionarCamera()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ultimaPosicao = cameraDoJogo.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direcao = ultimaPosicao - cameraDoJogo.ScreenToViewportPoint(Input.mousePosition);

            cameraDoJogo.transform.position = new Vector3();

            cameraDoJogo.transform.Rotate(new Vector3(1f, 0f, 0f), direcao.y * 180f);
            cameraDoJogo.transform.Rotate(new Vector3(0f, 1f, 0f), -direcao.x * 180f, Space.World);
            cameraDoJogo.transform.Translate(new Vector3(0f, 0f, distanciaDaCamera));

            ultimaPosicao = cameraDoJogo.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
