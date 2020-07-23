using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeslizanteControlador : MonoBehaviour
{
    public RectTransform subMenu;
    //float posFinal;
    bool abrirMenu = true;
    public float tiempo =0.4f;
    public bool desdeIzquierdo = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    IEnumerator mover(float time, Vector3 posInit, Vector3 posFin){
        float elapsedTime = 0;
        while( elapsedTime < time){
            subMenu.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subMenu.position = posFin;
    }
    void moverMenu (float time , Vector3 posInit, Vector3 posFin){
        StartCoroutine(mover (time, posInit, posFin) );
    }
    
    public void moverPanel(){
        
        //calcularPosIni();
        float tmp =0f;
        if(desdeIzquierdo){
            tmp = abrirMenu? 0 :-subMenu.rect.width;
        }
        else{
            tmp = abrirMenu? Screen.width - subMenu.rect.width : Screen.width;
        }
        
        moverMenu (tiempo, subMenu.position, new Vector3(tmp, subMenu.position.y ,0) );
        
        abrirMenu = !abrirMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
