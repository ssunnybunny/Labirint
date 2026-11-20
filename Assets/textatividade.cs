using UnityEngine;
using UnityEngine.UI;

public class textatividade : MonoBehaviour
{
    public Text text;
    public float hommee;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            hommee++;
        }

        if (hommee == 1)
        {
            text.text = "Olá!";
        }
        if (hommee == 2)
        {
            text.text = "É um prazer receber sua presença.";
        }
        if (hommee == 3)
        {
            text.text = "Hoje, irei falar sobre uma dificuldade em Game Design:";
        }
        if (hommee == 4)
        {
            text.text = "Equilíbrio entre dificuldade e recompensa.";
        }
        if (hommee == 5)
        {
            text.text = "Quase todo jogo tem uma estrutura que exige um nível mínimo de dificuldade, e algum ou múltiplos tipos de recompensa para fazer com que o tempo investido pelo player seja valho.";
        }
        if (hommee == 6)
        {
            text.text = "Usando meu jogo Labirinto como exemplo, irei mostrar como tal conceito se manifesta na maioria dos platformers.";
        }
        if (hommee == 7)
        {
            text.text = "Este jogo é feito para ser curto, então os níveis são programados para serem difíceis, para que o jogador não termine o jogo em 5 minutos. Mas para que o jogo seja divertido, os níveis devem ser feitos de modo que o jogador aprenda os controles e os aperfeiçoe, para que, ao terminar o nível, sinta um nível de recompensa.";
        }
        if (hommee == 8)
        {
            text.text = "Eu estou usando este pulo como exemplo, quero que seja difícil, mas que o player consiga aperfeiçoar sua noção de timing com o pulo anterior para poder passar por este.";
        }
        if (hommee == 9)
        {
            text.text = "É isto! Meu sinceros agradecimentos por me propor um pouco de seu tempo. Beba água e tenha um ótimo dia!";
        }


    }
}
