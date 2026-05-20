using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoVoltar : MonoBehaviour
{
    // Nome da cena para voltar
    public string nomeDaCena;

    // Função chamada pelo botão
    public void Voltar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}