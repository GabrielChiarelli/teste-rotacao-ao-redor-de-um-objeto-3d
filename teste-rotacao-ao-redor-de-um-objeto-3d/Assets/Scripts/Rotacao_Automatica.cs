using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_Automatica : MonoBehaviour
{
    [SerializeField] private float velocidadeDeRotacaoHorizontal;

    private void Update()
    {
        RotacionarCamera();
    }

    private void RotacionarCamera()
    {
        transform.Rotate(0f, velocidadeDeRotacaoHorizontal * Time.deltaTime, 0f);
    }
}
