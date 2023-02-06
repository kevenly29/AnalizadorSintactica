using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexicoCompiladores
{
     class SintAscSLR
    {

        public const int NOPROD = 40; 
        public const int NODDS = 1000; 
        public const int NOACTIONS = 1000; 
        public const int NOGOTOS = 1000;
        Pila _pila; 
        int[,] _action;
        int _noActions;
        int _noGoTos; 
        int[,] _goTo; 
        int[] _dd;
        int _noDds; 
        Item[] _c;
        int _noItems;
        // Metodos
       /* public  SintacticoAsc()   // Constructor------------------------------
        { 
            _pila = new Pila();
            _dd = new int[NODDS];
            _noDds = 0;
            _action = new int[1000 * (_vts.Length - 1), 4];
            _goTo = new int[1000 * (_vns.Length - 1), 3];
            _noActions = 0;
            _noGoTos = 0;
            _noItems=0;
        }  // Fin del constructor ---------------------------------------------
           public void Inicia()  //---------------------------------------------
        {
            _pila.Inicia();   
            _noDds = 0;
            _noActions = 0;
            _noGoTos = 0;
            _c = new Item[1000];
            _noItems = 0; 
            for (int i = 0; i < _c.Length; i++) 
                _c[i] = new Item();
            //crea item 0 y calcula la cerradura del mismo---------------
            int [,] arre={{-1,0}};
            _c[_noItems++] = Cerradura(new Item(arre, 1));
            //crea item 1 y lo asigna ----------------------------------
            int[,] arreItem1 ={ { -1, 1 } };
            _c[_noItems++] = new Item(arreItem1, 1);
            //calcula la coleccion canonica de la gramatica-------------
            for (int i = 0; i < _noItems; i++) 
                if (i != 1)
                    AgregarConjItems(i);
            //crear los goTos del item  S'->.S gramatica aumentada------------
            _goTo[_noGoTos, 0] = 0; 
            _goTo[_noGoTos, 1] = 1;
            _goTo[_noGoTos++, 2] = 1; 
            //genera cambios y reducciones de la tabla M----------------------
            for (int i = 0; i < 1000; i++)   
            {            
                GeneraCambios(i);
                GeneraReducciones(i);
            }       
        }  // fin de Inicia() -------------------------------------------------------------------
           public Item Cerradura(Item oItem)  // Cerradura de un item-------------------------------------
            {
            
            bool cambios = true; 
            while (cambios)
            {
                for (int i = 0; i< oItem.NoItems; i++)
                {   
                    int noItemsAgregado = AgregarItems(i, ref oItem);
                    if (noItemsAgregado > 0)
                    { 
                        cambios = true;   
                        break;
                    }
                    else 
                        cambios = false; 
                }
            }           
            return oItem;

    }  // Fin de Cerradura() ----------------------------------------------------------------------
       public void AgregarConjItems(int i)  //-------------------------------------------------------
      {
            bool[] marcaItems = new bool[NOPROD];
            for (int j = 0; j < NOPROD; j++)
                marcaItems[j] = false;
            marcaItems[0] = i == 0 ? true : false;
            for(int j=0;j< _c[i].NoItems;j++) 
                if (!marcaItems[j])
                { 
                    int noProd = _c[i].NoProd(j);
                    int posPto = _c[i].PosPto(j);
                    if (posPto != _prod[noProd, 1])
                    {                      
                        Item oNuevoItem = new Item();
                        int indSimGoTo = _prod[noProd, posPto + 2];
                        for(int k=0;k< _c[i].NoItems;k++)
                            if (!marcaItems[k])
                            {
                                int nP = _c[i].NoProd(k);
                                int pP = _c[i].PosPto(k); 
                                if (indSimGoTo == _prod[nP, pP + 2]) 
                                {
                                    oNuevoItem.Agregar(nP, pP + 1);  
                                    marcaItems[k] = true;   
                                }
                            }
                        int edoYaExiste;   
                        _goTo[_noGoTos, 0] = i;
                        _goTo[_noGoTos, 1] = indSimGoTo;
                        oNuevoItem = Cerradura(oNuevoItem);
                        if (!EstaNuevoItem(oNuevoItem,out edoYaExiste))//verifica si el item no existe
        {
                            _goTo[_noGoTos++,2]=_noItems;
                            _c[_noItems++] = oNuevoItem;
                        }
                        else 
                            _goTo[_noGoTos++,2]=edoYaExiste;//calcular el goTo cuando el item no existe
                                                            }
                } 
        }  // Fin de AgregarConjItems()--------------------------------------------------------------------
         public int AgregarItems(int i, ref Item oItem)  //--------------------------------------------------
              {
            int noItemsAgregado = 0;     
            int posPto = oItem.PosPto(i);        
            int noProd = oItem.NoProd(i);        
            int indVns = noProd == -1 ? 1 : (posPto == _prod[noProd, 1] ? 0 : (_prod[noProd, posPto + 2] < 0 ? 0 : _prod[noProd, posPto + 2])); 
            if(indVns>0)        
                for(int j=0;j<NOPROD;j++)   
                    if (indVns == _prod[j, 0] && !oItem.ExisteItem(j,0)) 
                        //busca si existe una produccion con
                        {
                        //ese indice y que no existael item
                        oItem.Agregar(j, 0);  
                        noItemsAgregado++; 
                    }         
            return noItemsAgregado;
        }  // Fin de AgregarItems() -------------------------------------------------------------------------
        public bool EstaNuevoItem(Item oNuevoItem,out int edoYaExiste)  //-----------------------------------
          {   
            edoYaExiste = -1;   
            for(int i=0;i< _noItems;i++)    
                if (_c[i].NoItems == oNuevoItem.NoItems)     
                {           
                    int aciertos = 0;
                    for(int j=0;j< _c[i].NoItems;j++)
  for(int k=0;k<oNuevoItem.NoItems;k++)

            if (_c[i].NoProd(j) == oNuevoItem.NoProd(k) && _c[i].PosPto(j) == oNuevoItem.PosPto(k)) 
            {
            aciertos++;
            break;  
                          
 }


if (aciertos == _c[i].NoItems) //si numero de items son iguales a los aciertos, entonces ya existe
                               {
        edoYaExiste = i;
        return true;
                     } 
}      
       return false;
}  // Fin de EstaNuevoItem()  ------------------------------------------------------------------
   public void GeneraReducciones(int i)  
    // reducciones del Item _c[i] ----------------------------
    {
    for (int j = 0; j < _c[i].NoItems; j++) 
    { 
        int noProd = _c[i].NoProd(j);   
        int posPto = _c[i].PosPto(j);  
        if (i == 1) //cuando el item es 1 se realiza lo siguiente
                    {
            _action[_noActions, 0] = i;
            _action[_noActions, 1] = _vts.Length-1;
            _action[_noActions, 2] = 2;
            _action[_noActions++, 3] = -1; 
        }    
        else    
        if (noProd != -1 && posPto == _prod[noProd, 1])
        {
            int indVns= _prod[noProd, 0]; 
            for (int k = 1; k <=_sig[indVns,0]; k++)
            {
                _action[_noActions, 0] = i;
                _action[_noActions, 1] = _sig[indVns,k];  
                _action[_noActions, 2] = 1;
                _action[_noActions++, 3] = noProd;
            } 
        }    
    }         
}  // Fin de GeneraReducciones()----------------------------------------
   public  void GeneraCambios(int i)
    // cambios del Item _c[i]-------------------------
    {
    for (int j = 0; j < _c[i].NoItems; j++) 
    {          
        int noProd = _c[i].NoProd(j);
        int posPto = _c[i].PosPto(j); 
        if (noProd != -1) 
        {   
            if (posPto != _prod[noProd, 1]) 
            { 
                int indSim = _prod[noProd, posPto + 2]; 
                if (indSim < 0)
                {
                    int edoTrans = -1; 
                    for (int k = 0; k < _noGoTos; k++)  
                        if (_goTo[k, 0] == i && _goTo[k, 1] == indSim) 
                        {
                            edoTrans = _goTo[k, 2];
                            break;
                        }   
                    _action[_noActions, 0] = i; 
                    _action[_noActions, 1] = -indSim;
                    _action[_noActions, 2] = 0;
                    _action[_noActions++, 3] = edoTrans;
                }     
            } 


}
    }
}  // Fin de GeneraCambios() --------------------------------------------------------------------
   public int Analiza(Lexico oAnalex)    
{             
    int ae = 0;
    oAnalex.Añade("$", "$");   
    _pila.Push(new SimbGram("0")); 
    while (true)   
    {  
        string s = _pila.Tope.Elem;
        string a = oAnalex.Token[ae]; 
        string accion = Accion(s,a);
        switch (accion[0])   
        {
            case 's': _pila.Push(new SimbGram(a));
                _pila.Push(new SimbGram(accion.Substring(1)));  // caso en que la acciones un cambio
             ae++; 
                break;
            case 'r': SacarDosBeta(accion);//sacar dos veces Beta simbolos de la pila
            MeterAGoTo(accion);  //meter Vns y goTos a la pila
          _dd[_noDds++]=Convert.ToInt32(accion.Substring(1));  // caso en que la accion es una
          break;                                               // reduccion
          case 'a': return 0;  // aceptacion
          case 'e': return 1;  // error
          }
    }  
}  // Fin de Analiza() ----------------------------------------------------------------------------------
  public string Accion(string s, string a)  // ------------------------------------------------------------
   {       
    //metodo que determina que accion se realizara
    int tipo=-1, no=-1;  
    int edo = Convert.ToInt32(s); 
    int inda = 0;
    bool enc = false;  
    for(int i=1;i<_vts.Length;i++) 
        if (_vts[i].Equals(a))   
        {      
            inda = i;   
            break;  
        }     
    for(int i=0;i<_noActions;i++)     
        if (_action[i, 0] == edo && _action[i, 1] == inda)   
        {      
            tipo = _action[i, 2];    
            no = _action[i, 3];    
            enc = true;      
        }           
    if (!enc)    
        return "error";  
    else    
        switch (tipo)    
        {  
            case 0: return "s" + no.ToString();   
            case 1: return "r" + no.ToString(); 
            case 2: return "acc";    
            default: return "error";  
        }    
}  // Fin de Accion() ------------------------------------------------------------------
public void SacarDosBeta(string accion)  //--------------------------------------------
   {
    int noProd = Convert.ToInt32(accion.Substring(1));
    int noVeces = _prod[noProd, 1] * 2;    
    for (int i = 1; i <= noVeces; i++) 
        _pila.Pop(); 

 
}  // Fin de SacarDosBeta() ------------------------------------------------------------
  public void MeterAGoTo(string accion)  
    //-----------------------------------------------
   {
    int sPrima = Convert.ToInt32(_pila.Tope.Elem);   
    int noProd = Convert.ToInt32(accion.Substring(1));
    _pila.Push(new SimbGram(_vns[_prod[noProd, 0]])); 
    for(int i=0;i<_noGoTos;i++)    
        if (sPrima == _goTo[i, 0] && _prod[noProd, 0] == _goTo[i, 1]) 
        {            
            _pila.Push(new SimbGram(_goTo[i,2].ToString()));  
            break;
        } 
}  // Fin de MeterAGoTo() --------------------------------------------------------------
       */
} // fin de la clase SintAscSLR 
}


