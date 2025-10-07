using UnityEngine;

public class GameManager : MonoBehaviour

{
    public int pontos = 0; 
    public int vidas = 3;

    public void AddPontos(int qtd)
    {
        pontos += qtd;
        Debug.Log("Pontos:" + pontos);
        if (pontos <= 0)
        {
            pontos = 0;
        }
    }
    public void Perdervida (int vida)
    {
        vidas -= vida;
        Debug.Log("vidas:" + vidas);
        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<NewMonoBehaviourScript >().Reiniciaposi();
        if (vidas <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVEr");
        }
    }
}
