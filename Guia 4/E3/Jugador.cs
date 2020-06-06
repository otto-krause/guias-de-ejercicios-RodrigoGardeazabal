using System;
using System.Collections.Generic;

namespace E3
{
    public class Jugador
    {
        string nombre;
        Consola pc = new PC();
        Consola ponystation4= new Ponystation4();
        Consola salada = new Ponystation4Salada();
        Consola caja = new CajaX();
        public Jugador(string nombre)
        {
            this.nombre=nombre;
        }
        public void adquirirJuego(string nombrejuego,string nombreconsola,int añojuego)
        {
            switch (nombreconsola)
            {
                case "PC":
                    pc.crear(nombrejuego,nombreconsola,añojuego);
                    break;
                case "CajaX":
                    caja.crear(nombrejuego,nombreconsola,añojuego);
                    break;
                case "Ponystation4":
                    ponystation4.crear(nombrejuego,nombreconsola,añojuego);
                    break;
                case "Salada":
                    salada.crear(nombrejuego,nombreconsola,añojuego);
                    break;
                default:
                    break;
            }
        }
        public int jugar(int minutos,string nombreconsola)
        {
            switch (nombreconsola)
            {
                case "PC":
                    pc.jugar(minutos);
                    break;
                case "CajaX":
                    caja.jugar(minutos);
                    break;
                case "Ponystation4":
                    ponystation4.jugar(minutos);
                    break;
                case "Salada":
                    salada.jugar(minutos);
                    break;
                default:
                    break;
            }
            return 2;
        }
        public int revisar(string nombreconsola)
        {
            switch (nombreconsola)
            {
                case "PC":
                    return pc.revisarpuntaje();
                case "CajaX":
                    return caja.revisarpuntaje();
                case "Ponystation4":
                    return ponystation4.revisarpuntaje();
                case "Salada":
                    return salada.revisarpuntaje();
                default:
                    break; 
            }
            return 1;
        }
        public string Elmas(string nombreconsola,string opcion1)
        {
            switch (nombreconsola)
            {
                case "PC":
                    if(opcion1=="4")
                        return pc.elmasnuevo();
                    else
                        return pc.elmasviejo();
                case "CajaX":
                    if(opcion1=="4")
                        return caja.elmasnuevo();
                    else
                        Console.WriteLine("F");
                        return caja.elmasviejo();
                case "Ponystation4":
                    if(opcion1=="4")
                        return ponystation4.elmasnuevo();
                    else
                        return ponystation4.elmasviejo();
                case "Salada":
                    if(opcion1=="4")
                        return salada.elmasnuevo();
                    else
                        return salada.elmasviejo();
                default:
                    break;
            }
            return "Error";
        }
        public string masusada()
        {
            if(caja.revisarpuntaje()>pc.revisarpuntaje()&&caja.revisarpuntaje()>ponystation4.revisarpuntaje()&&caja.revisarpuntaje()>salada.revisarpuntaje())
            {
                return "CajaX";
            }
            if(pc.revisarpuntaje()>caja.revisarpuntaje()&&pc.revisarpuntaje()>ponystation4.revisarpuntaje()&&pc.revisarpuntaje()>salada.revisarpuntaje())
            {
                return "PC";
            }
            if(ponystation4.revisarpuntaje()>pc.revisarpuntaje()&&ponystation4.revisarpuntaje()>caja.revisarpuntaje()&&ponystation4.revisarpuntaje()>salada.revisarpuntaje())
            {
                return "Ponystation4";
            }
            if(salada.revisarpuntaje()>pc.revisarpuntaje()&&salada.revisarpuntaje()>ponystation4.revisarpuntaje()&&salada.revisarpuntaje()>caja.revisarpuntaje())
                return "Ponystation4 pro SaladaEdition";
            return "error";
        }
    }
}