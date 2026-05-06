using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFase : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicialFase;
    [SerializeField] private GameObject painelFase;
    [SerializeField] private string nomeDoLevelDeJogo;

    public void AbrirMenuFase()
    {
        painelMenuInicialFase.SetActive(true);
        painelFase.SetActive(true);
    }

    public void FecharMenuFase()
    {
        painelFase.SetActive(false);
        painelMenuInicialFase.SetActive(true);
    }
    
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }
}
