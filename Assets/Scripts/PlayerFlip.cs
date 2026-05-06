using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isFacingRight = true;

    void Awake()
    {
        // Obtém o componente SpriteRenderer anexado ao objeto
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Pega a entrada horizontal: -1 (esquerda), 0 (parado), 1 (direita)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Se mover para a direita e estiver virado para a esquerda, inverta
        if (horizontalInput > 0 && !isFacingRight)
        {
            Flip();
        }
        // Se mover para a esquerda e estiver virado para a direita, inverta
        else if (horizontalInput < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        // Inverte o estado
        isFacingRight = !isFacingRight;

        // Inverte a propriedade flipX do Sprite Renderer
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}