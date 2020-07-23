using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventos : MonoBehaviour
{
    // Start is called before the first frame update

    MenuMainController menuMainController;
    void Start()
    {   
        menuMainController = GameObject.Find("PanelPrincipal").GetComponent<MenuMainController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickBoton(string opcion){
        Debug.Log("se preciono boton:"+ opcion);
    }
    public void onClickMoverMenuDeslizante(string panel){
        Debug.Log("Se preciono deslizante");
        menuMainController.moverPaneldeslizante(panel);
    }
}
