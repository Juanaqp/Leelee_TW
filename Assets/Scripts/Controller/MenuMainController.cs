using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMainController : MonoBehaviour
{
    private const int V = 4;

    // Start is called before the first frame update
    //public PanelDeslizanteControlador panelIzquierdoDeslizanteControlador;
    public Dictionary<string ,PanelDeslizanteControlador>  dicPanelDerechoDeslizanteControlador;
    void Start()
    {
        dicPanelDerechoDeslizanteControlador = new Dictionary<string ,PanelDeslizanteControlador>();
        dicPanelDerechoDeslizanteControlador.Add("MenuIzquierdo", GameObject.Find("MenuIzquierdo").GetComponent<PanelDeslizanteControlador>());
        
    }
    public void moverPaneldeslizante(string panel){
        dicPanelDerechoDeslizanteControlador[panel].moverPanel() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
