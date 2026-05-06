using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Referencia privada do controladorCanvas
    ControladorCanvas controladorCanvas;

    // Chamado 1 vez ao inicializar a cena
    void Start()
    {
        // Busca na cena um objeto com o componente ControladorCanvas
        controladorCanvas = FindFirstObjectByType<ControladorCanvas>();
    }


    // Método que identifica quando outro objeto entra no collisor deste objeto 
    // (Este colisor precisa estar configurado como 'Trigger')
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Checa para ver se o objeto que colidiu com este possuí a tag 'Player'
        if (collision.gameObject.tag == "Player")
        {
            // Ativa o painel de derrota do ControladorCanvas
            controladorCanvas.Ativar_PainelDerrota();
        }
    }
}
