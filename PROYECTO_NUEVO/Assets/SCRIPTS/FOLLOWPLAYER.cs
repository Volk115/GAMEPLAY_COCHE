using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOWPLAYER : MonoBehaviour
{
    /*se debe arrastrar a player (desde el ... de la izquierda de la pantalla)
    dentro del apartado player que acabamos de crear */
    public GameObject player;
    private Vector3 Offset = new Vector3(x: 0, y: 5, z: -7);

    void LateUpdate()
    {
        //copia la posicion del player en todo momento
        transform.position = player.transform.position + Offset;

    }

}
