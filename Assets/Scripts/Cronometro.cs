using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public TMP_Text textoCronometro;

    private float tempo;

    void Update()
    {
        // Conta o tempo
        tempo += Time.deltaTime;

        // Converte para minutos e segundos
        int minutos = Mathf.FloorToInt(tempo / 60);
        int segundos = Mathf.FloorToInt(tempo % 60);

        // Atualiza o texto
        textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}