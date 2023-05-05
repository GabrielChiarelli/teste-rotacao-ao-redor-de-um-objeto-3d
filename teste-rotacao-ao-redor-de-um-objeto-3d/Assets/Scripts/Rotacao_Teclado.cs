using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_Teclado : MonoBehaviour
{
    [SerializeField] private Transform pontoParaOlhar;
    
    [SerializeField] private float velocidadeDeRotacaoHorizontal;

    private float inputHorizontal;

    private void Update()
    {
        ReceberInputs();
        RotacionarCamera();
    }

    private void ReceberInputs()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
    }

    private void RotacionarCamera()
    {
        if (inputHorizontal > 0f)
        {
            transform.RotateAround(pontoParaOlhar.position, Vector3.up, velocidadeDeRotacaoHorizontal * Time.deltaTime);
        }
        else if (inputHorizontal < 0f)
        {
            transform.RotateAround(pontoParaOlhar.position, Vector3.up, -velocidadeDeRotacaoHorizontal * Time.deltaTime);
        }
    }
}
