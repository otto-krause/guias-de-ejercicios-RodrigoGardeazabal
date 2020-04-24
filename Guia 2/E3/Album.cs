using System;
using System.Collections.Generic;

namespace E3
{
    public class Album
    {
        List<Mundial> Albumdemundial =new List<Mundial>();
        public int fig(string nom,string pos,string pai,int figu,int otro,int opcion)
        {
            int i=0,repetida=0,cantdel=0,cantmed=0,totaldefig=0,completo=0;
            if(otro==1)
            {
                Albumdemundial.Add(new Mundial("Yuri","defensor","rusia",7));
                Albumdemundial.Add(new Mundial("Ezequiel","Arquero","rusia",4));
                Albumdemundial.Add(new Mundial("Brahian","delantero","japon",352));
                Albumdemundial.Add(new Mundial("Oscar","delantero","australia",100));
                Albumdemundial.Add(new Mundial("Gaston","defensor","marruecos",54));
                Albumdemundial.Add(new Mundial("Cristiano","mediocampista","egipto",12));
                Albumdemundial.Add(new Mundial("Igor","portero","rusia",1));
                Albumdemundial.Add(new Mundial("Jupiter","delantero","rusia",5));
                Albumdemundial.Add(new Mundial("Buzz","mediocampista","portugal",65));
                Albumdemundial.Add(new Mundial("Enzo","delantero","egipto",21));
                Albumdemundial.Add(new Mundial("Qrow","delantero","iran",71));
                Albumdemundial.Add(new Mundial("Edson","portero","arabia saudita",29));
                Albumdemundial.Add(new Mundial("Woody","delantero","arabia saudita",33));
                Albumdemundial.Add(new Mundial("Oak","delantero","marruecos",45));
                Albumdemundial.Add(new Mundial("Bruno","mediocampista","portugal",63));
                Albumdemundial.Add(new Mundial("Sebastian","mediocampista","serbia",189));
                Albumdemundial.Add(new Mundial("Luis","delantero","rusia",2));
                Albumdemundial.Add(new Mundial("Adrien","delantero","francia",95));
                Albumdemundial.Add(new Mundial("Nino","mediocampista","francia",94));
                Albumdemundial.Add(new Mundial("Camilo","defensor","uruguay",40));
                Albumdemundial.Add(new Mundial("Marrue","delantero","marruecos",52));
                Albumdemundial.Add(new Mundial("Sui","delantero","suiza",212));
                otro=2;
            }
            foreach (var j in Albumdemundial)
            {
                completo++;
            }
            if(completo<=352)
            {
                if(pai=="rusia")
                {
                    i=0;
                    foreach (var j in Albumdemundial)
                    {
                        if("rusia"==Albumdemundial[i].paises())
                        {
                            totaldefig++;
                        }
                        i++; 
                    }
                    if(totaldefig<11)
                    {
                        if(figu>=1&&figu<=11)
                        {
                            i=0;
                            foreach (var j in Albumdemundial)
                            {
                                if(figu==Albumdemundial[i].figur())
                                {
                                    repetida++;
                                }
                                i++; 
                            }
                            if(repetida>0)
                            {
                                Console.WriteLine("La figurita esta repetida");
                            }
                            else
                            {
                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                i=0;
                                foreach (var k in Albumdemundial)
                                {
                                    if("delantero"==Albumdemundial[i].posici())
                                    {
                                        cantdel++;
                                    }
                                    if(Albumdemundial[i].posic())
                                    {
                                        cantmed++;
                                    }
                                    i++;
                                }        
                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                            }
                        }
                        else
                        {
                            Console.WriteLine("las figuritas de Rusia son del 1 al 11");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Rusia ya esta completo");
                    }
                }
                else
                {
                    if(pai=="egipto")
                    {
                        i=0;
                        foreach (var j in Albumdemundial)
                        {
                            if("egipto"==Albumdemundial[i].paises())
                            {
                                totaldefig++;
                            }
                            i++; 
                        }
                        if(totaldefig<11)
                        {
                            if(figu>=12&&figu<=22)
                            {
                                i=0;
                                foreach (var j in Albumdemundial)
                                {
                                    if(figu==Albumdemundial[i].figur())
                                    {
                                        repetida++;
                                    }
                                    i++; 
                                }
                                if(repetida>0)
                                {
                                    Console.WriteLine("La figurita esta repetida");
                                }
                                else
                                {
                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                    i=0;
                                    foreach (var k in Albumdemundial)
                                    {
                                        if("delantero"==Albumdemundial[i].posici())
                                        {
                                            cantdel++;
                                        }
                                        if(Albumdemundial[i].posic())
                                        {
                                            cantmed++;
                                        }
                                        i++;
                                    }        
                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                }
                            }
                            else
                            {
                                Console.WriteLine("las figuritas de Egipto son del 12 al 22");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Egipto ya esta completo");
                        }
                    }
                    else
                    {
                        if(pai=="arabia saudita")
                        {
                            i=0;
                            foreach (var j in Albumdemundial)
                            {
                                if("arabia saudita"==Albumdemundial[i].paises())
                                {
                                    totaldefig++;
                                }
                                i++; 
                            }
                            if(totaldefig<11)
                            {
                                if(figu>=23&&figu<=33)
                                {
                                    i=0;
                                    foreach (var j in Albumdemundial)
                                    {
                                        if(figu==Albumdemundial[i].figur())
                                        {
                                            repetida++;
                                        }
                                        i++; 
                                    }
                                    if(repetida>0)
                                    {
                                        Console.WriteLine("La figurita esta repetida");
                                    }
                                    else
                                    {
                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                        i=0;
                                        foreach (var k in Albumdemundial)
                                        {
                                            if("delantero"==Albumdemundial[i].posici())
                                            {
                                                cantdel++;
                                            }
                                            if(Albumdemundial[i].posic())
                                            {
                                                cantmed++;
                                            }
                                            i++;
                                        }        
                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("las figuritas de Arabia Saudita son del 23 al 33");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Arabia Saudita ya esta completo");
                            }
                        }
                        else
                        {
                            if(pai=="uruguay")
                            {
                                i=0;
                                foreach (var j in Albumdemundial)
                                {
                                    if("uruguay"==Albumdemundial[i].paises())
                                    {
                                        totaldefig++;
                                    }
                                    i++; 
                                }
                                if(totaldefig<11)
                                {
                                    if(figu>=34&&figu<=44)
                                    {
                                        i=0;
                                        foreach (var j in Albumdemundial)
                                        {
                                            if(figu==Albumdemundial[i].figur())
                                            {
                                                repetida++;
                                            }
                                            i++; 
                                        }
                                        if(repetida>0)
                                        {
                                            Console.WriteLine("La figurita esta repetida");
                                        }
                                        else
                                        {
                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                            i=0;
                                            foreach (var k in Albumdemundial)
                                            {
                                                if("delantero"==Albumdemundial[i].posici())
                                                {
                                                    cantdel++;
                                                }
                                                if(Albumdemundial[i].posic())
                                                {
                                                    cantmed++;
                                                }
                                                i++;
                                            }        
                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("las figuritas de Uruguay son del 34 al 44");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Uruguay ya esta completo");
                                }
                            }
                            else
                            {
                                if(pai=="marruecos")
                                {
                                    i=0;
                                    foreach (var j in Albumdemundial)
                                    {
                                        if("marruecos"==Albumdemundial[i].paises())
                                        {
                                            totaldefig++;
                                        }
                                        i++; 
                                    }
                                    if(totaldefig<11)
                                    {
                                        if(figu>=45&&figu<=55)
                                        {
                                            i=0;
                                            foreach (var j in Albumdemundial)
                                            {
                                                if(figu==Albumdemundial[i].figur())
                                                {
                                                    repetida++;
                                                }
                                                i++; 
                                            }
                                            if(repetida>0)
                                            {
                                                Console.WriteLine("La figurita esta repetida");
                                            }
                                            else
                                            {
                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                i=0;
                                                foreach (var k in Albumdemundial)
                                                {
                                                    if("delantero"==Albumdemundial[i].posici())
                                                    {
                                                        cantdel++;
                                                    }
                                                    if(Albumdemundial[i].posic())
                                                    {
                                                        cantmed++;
                                                    }
                                                    i++;
                                                }        
                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("las figuritas de Marruecos son del 45 al 55");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Marruecos ya esta completo");
                                    }
                                }
                                else
                                {
                                    if(pai=="portugal")
                                    {
                                        i=0;
                                        foreach (var j in Albumdemundial)
                                        {
                                            if("portugal"==Albumdemundial[i].paises())
                                            {
                                                totaldefig++;
                                            }
                                            i++; 
                                        }
                                        if(totaldefig<11)
                                        {
                                            if(figu>=56&&figu<=66)
                                            {
                                                i=0;
                                                foreach (var j in Albumdemundial)
                                                {
                                                    if(figu==Albumdemundial[i].figur())
                                                    {
                                                        repetida++;
                                                    }
                                                    i++; 
                                                }
                                                if(repetida>0)
                                                {
                                                    Console.WriteLine("La figurita esta repetida");
                                                }
                                                else
                                                {
                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                    i=0;
                                                    foreach (var k in Albumdemundial)
                                                    {
                                                        if("delantero"==Albumdemundial[i].posici())
                                                        {
                                                            cantdel++;
                                                        }
                                                        if(Albumdemundial[i].posic())
                                                        {
                                                            cantmed++;
                                                        }
                                                        i++;
                                                    }        
                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("las figuritas de Portugal son del 56 al 66");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Portugal ya esta completo");
                                        }
                                    }
                                    else
                                    {
                                        if(pai=="iran")
                                        {
                                            i=0;
                                            foreach (var j in Albumdemundial)
                                            {
                                                if("iran"==Albumdemundial[i].paises())
                                                {
                                                    totaldefig++;
                                                }
                                                i++; 
                                            }
                                            if(totaldefig<11)
                                            {
                                                if(figu>=67&&figu<=77)
                                                {
                                                    i=0;
                                                    foreach (var j in Albumdemundial)
                                                    {
                                                        if(figu==Albumdemundial[i].figur())
                                                        {
                                                            repetida++;
                                                        }
                                                        i++; 
                                                    }
                                                    if(repetida>0)
                                                    {
                                                        Console.WriteLine("La figurita esta repetida");
                                                    }
                                                    else
                                                    {
                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                        i=0;
                                                        foreach (var k in Albumdemundial)
                                                        {
                                                            if("delantero"==Albumdemundial[i].posici())
                                                            {
                                                                cantdel++;
                                                            }
                                                            if(Albumdemundial[i].posic())
                                                            {
                                                                cantmed++;
                                                            }
                                                            i++;
                                                        }        
                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("las figuritas de Iran son del 67 al 77");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Iran ya esta completo");
                                            }
                                        }
                                        else
                                        {
                                            if(pai=="españa")
                                            {
                                                i=0;
                                                foreach (var j in Albumdemundial)
                                                {
                                                    if("españa"==Albumdemundial[i].paises())
                                                    {
                                                        totaldefig++;
                                                    }
                                                    i++; 
                                                }
                                                if(totaldefig<11)
                                                {
                                                    if(figu>=78&&figu<=88)
                                                    {
                                                        i=0;
                                                        foreach (var j in Albumdemundial)
                                                        {
                                                            if(figu==Albumdemundial[i].figur())
                                                            {
                                                                repetida++;
                                                            }
                                                            i++; 
                                                        }
                                                        if(repetida>0)
                                                        {
                                                            Console.WriteLine("La figurita esta repetida");
                                                        }
                                                        else
                                                        {
                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                            i=0;
                                                            foreach (var k in Albumdemundial)
                                                            {
                                                                if("delantero"==Albumdemundial[i].posici())
                                                                {
                                                                    cantdel++;
                                                                }
                                                                if(Albumdemundial[i].posic())
                                                                {
                                                                    cantmed++;
                                                                }
                                                                i++;
                                                            }        
                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("las figuritas de España son del 78 al 88");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("España ya esta completo");
                                                }
                                            }
                                            else
                                            {
                                                if(pai=="francia")
                                                {
                                                    i=0;
                                                    foreach (var j in Albumdemundial)
                                                    {
                                                        if("francia"==Albumdemundial[i].paises())
                                                        {
                                                            totaldefig++;
                                                        }
                                                        i++; 
                                                    }
                                                    if(totaldefig<11)
                                                    {
                                                        if(figu>=89&&figu<=99)
                                                        {
                                                            i=0;
                                                            foreach (var j in Albumdemundial)
                                                            {
                                                                if(figu==Albumdemundial[i].figur())
                                                                {
                                                                    repetida++;
                                                                }
                                                                i++; 
                                                            }
                                                            if(repetida>0)
                                                            {
                                                                Console.WriteLine("La figurita esta repetida");
                                                            }
                                                            else
                                                            {
                                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                i=0;
                                                                foreach (var k in Albumdemundial)
                                                                {
                                                                    if("delantero"==Albumdemundial[i].posici())
                                                                    {
                                                                        cantdel++;
                                                                    }
                                                                    if(Albumdemundial[i].posic())
                                                                    {
                                                                        cantmed++;
                                                                    }
                                                                    i++;
                                                                }        
                                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("las figuritas de Francia son del 89 al 99");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Francia ya esta completo");
                                                    }
                                                }
                                                else
                                                {
                                                    if(pai=="australia")
                                                    {
                                                        i=0;
                                                        foreach (var j in Albumdemundial)
                                                        {
                                                            if("australia"==Albumdemundial[i].paises())
                                                            {
                                                                totaldefig++;
                                                            }
                                                            i++; 
                                                        }
                                                        if(totaldefig<11)
                                                        {
                                                            if(figu>=100&&figu<=110)
                                                            {
                                                                i=0;
                                                                foreach (var j in Albumdemundial)
                                                                {
                                                                    if(figu==Albumdemundial[i].figur())
                                                                    {
                                                                        repetida++;
                                                                    }
                                                                    i++; 
                                                                }
                                                                if(repetida>0)
                                                                {
                                                                    Console.WriteLine("La figurita esta repetida");
                                                                }
                                                                else
                                                                {
                                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                    i=0;
                                                                    foreach (var k in Albumdemundial)
                                                                    {
                                                                        if("delantero"==Albumdemundial[i].posici())
                                                                        {
                                                                            cantdel++;
                                                                        }
                                                                        if(Albumdemundial[i].posic())
                                                                        {
                                                                            cantmed++;
                                                                        }
                                                                        i++;
                                                                    }        
                                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("las figuritas de Australia son del 100 al 110");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Australia ya esta completo");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if(pai=="peru")
                                                        {
                                                            i=0;
                                                            foreach (var j in Albumdemundial)
                                                            {
                                                                if("peru"==Albumdemundial[i].paises())
                                                                {
                                                                    totaldefig++;
                                                                }
                                                                i++; 
                                                            }
                                                            if(totaldefig<11)
                                                            {
                                                                if(figu>=111&&figu<=121)
                                                                {
                                                                    i=0;
                                                                    foreach (var j in Albumdemundial)
                                                                    {
                                                                        if(figu==Albumdemundial[i].figur())
                                                                        {
                                                                            repetida++;
                                                                        }
                                                                        i++; 
                                                                    }
                                                                    if(repetida>0)
                                                                    {
                                                                        Console.WriteLine("La figurita esta repetida");
                                                                    }
                                                                    else
                                                                    {
                                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                        i=0;
                                                                        foreach (var k in Albumdemundial)
                                                                        {
                                                                            if("delantero"==Albumdemundial[i].posici())
                                                                            {
                                                                                cantdel++;
                                                                            }
                                                                            if(Albumdemundial[i].posic())
                                                                            {
                                                                                cantmed++;
                                                                            }
                                                                            i++;
                                                                        }        
                                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("las figuritas de Peru son del 111 al 121");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Peru ya esta completo");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if(pai=="dinamarca")
                                                            {
                                                                i=0;
                                                                foreach (var j in Albumdemundial)
                                                                {
                                                                    if("dinamarca"==Albumdemundial[i].paises())
                                                                    {
                                                                        totaldefig++;
                                                                    }
                                                                    i++; 
                                                                }
                                                                if(totaldefig<11)
                                                                {
                                                                    if(figu>=122&&figu<=132)
                                                                    {
                                                                        i=0;
                                                                        foreach (var j in Albumdemundial)
                                                                        {
                                                                            if(figu==Albumdemundial[i].figur())
                                                                            {
                                                                                repetida++;
                                                                            }
                                                                            i++; 
                                                                        }
                                                                        if(repetida>0)
                                                                        {
                                                                            Console.WriteLine("La figurita esta repetida");
                                                                        }
                                                                        else
                                                                        {
                                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                            i=0;
                                                                            foreach (var k in Albumdemundial)
                                                                            {
                                                                                if("delantero"==Albumdemundial[i].posici())
                                                                                {
                                                                                    cantdel++;
                                                                                }
                                                                                if(Albumdemundial[i].posic())
                                                                                {
                                                                                    cantmed++;
                                                                                }
                                                                                i++;
                                                                            }        
                                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("las figuritas de Dinamarca son del 122 al 132");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Dinamarca ya esta completo");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if(pai=="argentina")
                                                                {
                                                                    i=0;
                                                                    foreach (var j in Albumdemundial)
                                                                    {
                                                                        if("argentina"==Albumdemundial[i].paises())
                                                                        {
                                                                            totaldefig++;
                                                                        }
                                                                        i++; 
                                                                    }
                                                                    if(totaldefig<11)
                                                                    {
                                                                        if(figu>=133&&figu<=143)
                                                                        {
                                                                            i=0;
                                                                            foreach (var j in Albumdemundial)
                                                                            {
                                                                                if(figu==Albumdemundial[i].figur())
                                                                                {
                                                                                    repetida++;
                                                                                }
                                                                                i++; 
                                                                            }
                                                                            if(repetida>0)
                                                                            {
                                                                                Console.WriteLine("La figurita esta repetida");
                                                                            }
                                                                            else
                                                                            {
                                                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                i=0;
                                                                                foreach (var k in Albumdemundial)
                                                                                {
                                                                                    if("delantero"==Albumdemundial[i].posici())
                                                                                    {
                                                                                        cantdel++;
                                                                                    }
                                                                                    if(Albumdemundial[i].posic())
                                                                                    {
                                                                                        cantmed++;
                                                                                    }
                                                                                    i++;
                                                                                }        
                                                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("las figuritas de Argentina son del 133 al 143");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Argentina ya esta completo");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if(pai=="islandia")
                                                                    {
                                                                        i=0;
                                                                        foreach (var j in Albumdemundial)
                                                                        {
                                                                            if("islandia"==Albumdemundial[i].paises())
                                                                            {
                                                                                totaldefig++;
                                                                            }
                                                                            i++; 
                                                                        }
                                                                        if(totaldefig<11)
                                                                        {
                                                                            if(figu>=144&&figu<=154)
                                                                            {
                                                                                i=0;
                                                                                foreach (var j in Albumdemundial)
                                                                                {
                                                                                    if(figu==Albumdemundial[i].figur())
                                                                                    {
                                                                                        repetida++;
                                                                                    }
                                                                                    i++; 
                                                                                }
                                                                                if(repetida>0)
                                                                                {
                                                                                    Console.WriteLine("La figurita esta repetida");
                                                                                }
                                                                                else
                                                                                {
                                                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                    i=0;
                                                                                    foreach (var k in Albumdemundial)
                                                                                    {
                                                                                        if("delantero"==Albumdemundial[i].posici())
                                                                                        {
                                                                                            cantdel++;
                                                                                        }
                                                                                        if(Albumdemundial[i].posic())
                                                                                        {
                                                                                            cantmed++;
                                                                                        }
                                                                                        i++;
                                                                                    }        
                                                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("las figuritas de Islandia son del 144 al 154");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Islandia ya esta completo");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if(pai=="croacia")
                                                                        {
                                                                            i=0;
                                                                            foreach (var j in Albumdemundial)
                                                                            {
                                                                                if("croacia"==Albumdemundial[i].paises())
                                                                                {
                                                                                    totaldefig++;
                                                                                }
                                                                                i++; 
                                                                            }
                                                                            if(totaldefig<11)
                                                                            {
                                                                                if(figu>=155&&figu<=165)
                                                                                {
                                                                                    i=0;
                                                                                    foreach (var j in Albumdemundial)
                                                                                    {
                                                                                        if(figu==Albumdemundial[i].figur())
                                                                                        {
                                                                                            repetida++;
                                                                                        }
                                                                                        i++; 
                                                                                    }
                                                                                    if(repetida>0)
                                                                                    {
                                                                                        Console.WriteLine("La figurita esta repetida");
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                        i=0;
                                                                                        foreach (var k in Albumdemundial)
                                                                                        {
                                                                                            if("delantero"==Albumdemundial[i].posici())
                                                                                            {
                                                                                                cantdel++;
                                                                                            }
                                                                                            if(Albumdemundial[i].posic())
                                                                                            {
                                                                                                cantmed++;
                                                                                            }
                                                                                            i++;
                                                                                        }        
                                                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("las figuritas de Croacia son del 155 al 165");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Croacia ya esta completo");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if(pai=="nigeria")
                                                                            {
                                                                                i=0;
                                                                                foreach (var j in Albumdemundial)
                                                                                {
                                                                                    if("nigeria"==Albumdemundial[i].paises())
                                                                                    {
                                                                                        totaldefig++;
                                                                                    }
                                                                                    i++; 
                                                                                }
                                                                                if(totaldefig<11)
                                                                                {
                                                                                    if(figu>=166&&figu<=176)
                                                                                    {
                                                                                        i=0;
                                                                                        foreach (var j in Albumdemundial)
                                                                                        {
                                                                                            if(figu==Albumdemundial[i].figur())
                                                                                            {
                                                                                                repetida++;
                                                                                            }
                                                                                            i++; 
                                                                                        }
                                                                                        if(repetida>0)
                                                                                        {
                                                                                            Console.WriteLine("La figurita esta repetida");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                            i=0;
                                                                                            foreach (var k in Albumdemundial)
                                                                                            {
                                                                                                if("delantero"==Albumdemundial[i].posici())
                                                                                                {
                                                                                                    cantdel++;
                                                                                                }
                                                                                                if(Albumdemundial[i].posic())
                                                                                                {
                                                                                                    cantmed++;
                                                                                                }
                                                                                                i++;
                                                                                            }        
                                                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Console.WriteLine("las figuritas de Nigeria son del 166 al 176");
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Nigeria ya esta completo");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                if(pai=="costa rica")
                                                                                {
                                                                                    i=0;
                                                                                    foreach (var j in Albumdemundial)
                                                                                    {
                                                                                        if("costa rica"==Albumdemundial[i].paises())
                                                                                        {
                                                                                            totaldefig++;
                                                                                        }
                                                                                        i++; 
                                                                                    }
                                                                                    if(totaldefig<11)
                                                                                    {
                                                                                        if(figu>=1&&figu<=11)
                                                                                        {
                                                                                            i=0;
                                                                                            foreach (var j in Albumdemundial)
                                                                                            {
                                                                                                if(figu==Albumdemundial[i].figur())
                                                                                                {
                                                                                                    repetida++;
                                                                                                }
                                                                                                i++; 
                                                                                            }
                                                                                            if(repetida>0)
                                                                                            {
                                                                                                Console.WriteLine("La figurita esta repetida");
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                i=0;
                                                                                                foreach (var k in Albumdemundial)
                                                                                                {
                                                                                                    if("delantero"==Albumdemundial[i].posici())
                                                                                                    {
                                                                                                        cantdel++;
                                                                                                    }
                                                                                                    if(Albumdemundial[i].posic())
                                                                                                    {
                                                                                                        cantmed++;
                                                                                                    }
                                                                                                    i++;
                                                                                                }        
                                                                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("las figuritas de Costa Rica son del 177 al 187");
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Console.WriteLine("Costa Rica ya esta completo");
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    if(pai=="serbia")
                                                                                    {
                                                                                        i=0;
                                                                                        foreach (var j in Albumdemundial)
                                                                                        {
                                                                                            if("serbia"==Albumdemundial[i].paises())
                                                                                            {
                                                                                                totaldefig++;
                                                                                            }
                                                                                            i++; 
                                                                                        }
                                                                                        if(totaldefig<11)
                                                                                        {
                                                                                            if(figu>=188&&figu<=198)
                                                                                            {
                                                                                                i=0;
                                                                                                foreach (var j in Albumdemundial)
                                                                                                {
                                                                                                    if(figu==Albumdemundial[i].figur())
                                                                                                    {
                                                                                                        repetida++;
                                                                                                    }
                                                                                                    i++; 
                                                                                                }
                                                                                                if(repetida>0)
                                                                                                {
                                                                                                    Console.WriteLine("La figurita esta repetida");
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                    i=0;
                                                                                                    foreach (var k in Albumdemundial)
                                                                                                    {
                                                                                                        if("delantero"==Albumdemundial[i].posici())
                                                                                                        {
                                                                                                            cantdel++;
                                                                                                        }
                                                                                                        if(Albumdemundial[i].posic())
                                                                                                        {
                                                                                                            cantmed++;
                                                                                                        }
                                                                                                        i++;
                                                                                                    }        
                                                                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.WriteLine("las figuritas de Serbia son del 188 al 198");
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("Serbia ya esta completo");
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if(pai=="Brasil")
                                                                                        {
                                                                                            i=0;
                                                                                            foreach (var j in Albumdemundial)
                                                                                            {
                                                                                                if("Brasil"==Albumdemundial[i].paises())
                                                                                                {
                                                                                                    totaldefig++;
                                                                                                }
                                                                                                i++; 
                                                                                            }
                                                                                            if(totaldefig<11)
                                                                                            {
                                                                                                if(figu>=199&&figu<=209)
                                                                                                {
                                                                                                    i=0;
                                                                                                    foreach (var j in Albumdemundial)
                                                                                                    {
                                                                                                        if(figu==Albumdemundial[i].figur())
                                                                                                        {
                                                                                                            repetida++;
                                                                                                        }
                                                                                                        i++; 
                                                                                                    }
                                                                                                    if(repetida>0)
                                                                                                    {
                                                                                                        Console.WriteLine("La figurita esta repetida");
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                        i=0;
                                                                                                        foreach (var k in Albumdemundial)
                                                                                                        {
                                                                                                            if("delantero"==Albumdemundial[i].posici())
                                                                                                            {
                                                                                                                cantdel++;
                                                                                                            }
                                                                                                            if(Albumdemundial[i].posic())
                                                                                                            {
                                                                                                                cantmed++;
                                                                                                            }
                                                                                                            i++;
                                                                                                        }        
                                                                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    Console.WriteLine("las figuritas de Brasil son del 199 al 209");
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.WriteLine("Brasil ya esta completo");
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if(pai=="Suiza")
                                                                                            {
                                                                                                i=0;
                                                                                                foreach (var j in Albumdemundial)
                                                                                                {
                                                                                                    if("Suiza"==Albumdemundial[i].paises())
                                                                                                    {
                                                                                                        totaldefig++;
                                                                                                    }
                                                                                                    i++; 
                                                                                                }
                                                                                                if(totaldefig<11)
                                                                                                {
                                                                                                    if(figu>=210&&figu<=220)
                                                                                                    {
                                                                                                        i=0;
                                                                                                        foreach (var j in Albumdemundial)
                                                                                                        {
                                                                                                            if(figu==Albumdemundial[i].figur())
                                                                                                            {
                                                                                                                repetida++;
                                                                                                            }
                                                                                                            i++; 
                                                                                                        }
                                                                                                        if(repetida>0)
                                                                                                        {
                                                                                                            Console.WriteLine("La figurita esta repetida");
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                            i=0;
                                                                                                            foreach (var k in Albumdemundial)
                                                                                                            {
                                                                                                                if("delantero"==Albumdemundial[i].posici())
                                                                                                                {
                                                                                                                    cantdel++;
                                                                                                                }
                                                                                                                if(Albumdemundial[i].posic())
                                                                                                                {
                                                                                                                    cantmed++;
                                                                                                                }
                                                                                                                i++;
                                                                                                            }        
                                                                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.WriteLine("las figuritas de Suiza son del 210 al 220");
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    Console.WriteLine("Suiza ya esta completo");
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if(pai=="alemania")
                                                                                                {
                                                                                                    i=0;
                                                                                                    foreach (var j in Albumdemundial)
                                                                                                    {
                                                                                                        if("alemania"==Albumdemundial[i].paises())
                                                                                                        {
                                                                                                            totaldefig++;
                                                                                                        }
                                                                                                        i++; 
                                                                                                    }
                                                                                                    if(totaldefig<11)
                                                                                                    {
                                                                                                        if(figu>=221&&figu<=231)
                                                                                                        {
                                                                                                            i=0;
                                                                                                            foreach (var j in Albumdemundial)
                                                                                                            {
                                                                                                                if(figu==Albumdemundial[i].figur())
                                                                                                                {
                                                                                                                    repetida++;
                                                                                                                }
                                                                                                                i++; 
                                                                                                            }
                                                                                                            if(repetida>0)
                                                                                                            {
                                                                                                                Console.WriteLine("La figurita esta repetida");
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                i=0;
                                                                                                                foreach (var k in Albumdemundial)
                                                                                                                {
                                                                                                                    if("delantero"==Albumdemundial[i].posici())
                                                                                                                    {
                                                                                                                        cantdel++;
                                                                                                                    }
                                                                                                                    if(Albumdemundial[i].posic())
                                                                                                                    {
                                                                                                                        cantmed++;
                                                                                                                    }
                                                                                                                    i++;
                                                                                                                }        
                                                                                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("las figuritas de Alemania son del 221 al 231");
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.WriteLine("Alemania ya esta completo");
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if(pai=="mexico")
                                                                                                    {
                                                                                                        i=0;
                                                                                                        foreach (var j in Albumdemundial)
                                                                                                        {
                                                                                                            if("mexico"==Albumdemundial[i].paises())
                                                                                                            {
                                                                                                                totaldefig++;
                                                                                                            }
                                                                                                            i++; 
                                                                                                        }
                                                                                                        if(totaldefig<11)
                                                                                                        {
                                                                                                            if(figu>=232&&figu<=242)
                                                                                                            {
                                                                                                                i=0;
                                                                                                                foreach (var j in Albumdemundial)
                                                                                                                {
                                                                                                                    if(figu==Albumdemundial[i].figur())
                                                                                                                    {
                                                                                                                        repetida++;
                                                                                                                    }
                                                                                                                    i++; 
                                                                                                                }
                                                                                                                if(repetida>0)
                                                                                                                {
                                                                                                                    Console.WriteLine("La figurita esta repetida");
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                    i=0;
                                                                                                                    foreach (var k in Albumdemundial)
                                                                                                                    {
                                                                                                                        if("delantero"==Albumdemundial[i].posici())
                                                                                                                        {
                                                                                                                            cantdel++;
                                                                                                                        }
                                                                                                                        if(Albumdemundial[i].posic())
                                                                                                                        {
                                                                                                                            cantmed++;
                                                                                                                        }
                                                                                                                        i++;
                                                                                                                    }        
                                                                                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                Console.WriteLine("las figuritas de Mexico son del 232 al 242");
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("Mexico ya esta completo");
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if(pai=="suecia")
                                                                                                        {
                                                                                                            i=0;
                                                                                                            foreach (var j in Albumdemundial)
                                                                                                            {
                                                                                                                if("suecia"==Albumdemundial[i].paises())
                                                                                                                {
                                                                                                                    totaldefig++;
                                                                                                                }
                                                                                                                i++; 
                                                                                                            }
                                                                                                            if(totaldefig<11)
                                                                                                            {
                                                                                                                if(figu>=243&&figu<=253)
                                                                                                                {
                                                                                                                    i=0;
                                                                                                                    foreach (var j in Albumdemundial)
                                                                                                                    {
                                                                                                                        if(figu==Albumdemundial[i].figur())
                                                                                                                        {
                                                                                                                            repetida++;
                                                                                                                        }
                                                                                                                        i++; 
                                                                                                                    }
                                                                                                                    if(repetida>0)
                                                                                                                    {
                                                                                                                        Console.WriteLine("La figurita esta repetida");
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                        i=0;
                                                                                                                        foreach (var k in Albumdemundial)
                                                                                                                        {
                                                                                                                            if("delantero"==Albumdemundial[i].posici())
                                                                                                                            {
                                                                                                                                cantdel++;
                                                                                                                            }
                                                                                                                            if(Albumdemundial[i].posic())
                                                                                                                            {
                                                                                                                                cantmed++;
                                                                                                                            }
                                                                                                                            i++;
                                                                                                                        }        
                                                                                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    Console.WriteLine("las figuritas de Suecia son del 243 al 253");
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                Console.WriteLine("Suecia ya esta completo");
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if(pai=="corea del sur")
                                                                                                            {
                                                                                                                i=0;
                                                                                                                foreach (var j in Albumdemundial)
                                                                                                                {
                                                                                                                    if("corea del sur"==Albumdemundial[i].paises())
                                                                                                                    {
                                                                                                                        totaldefig++;
                                                                                                                    }
                                                                                                                    i++; 
                                                                                                                }
                                                                                                                if(totaldefig<11)
                                                                                                                {
                                                                                                                    if(figu>=254&&figu<=264)
                                                                                                                    {
                                                                                                                        i=0;
                                                                                                                        foreach (var j in Albumdemundial)
                                                                                                                        {
                                                                                                                            if(figu==Albumdemundial[i].figur())
                                                                                                                            {
                                                                                                                                repetida++;
                                                                                                                            }
                                                                                                                            i++; 
                                                                                                                        }
                                                                                                                        if(repetida>0)
                                                                                                                        {
                                                                                                                            Console.WriteLine("La figurita esta repetida");
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                            i=0;
                                                                                                                            foreach (var k in Albumdemundial)
                                                                                                                            {
                                                                                                                                if("delantero"==Albumdemundial[i].posici())
                                                                                                                                {
                                                                                                                                    cantdel++;
                                                                                                                                }
                                                                                                                                if(Albumdemundial[i].posic())
                                                                                                                                {
                                                                                                                                    cantmed++;
                                                                                                                                }
                                                                                                                                i++;
                                                                                                                            }        
                                                                                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        Console.WriteLine("las figuritas de Corea del sur son del 254 al 264");
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    Console.WriteLine("Corea del Sur ya esta completo");
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if(pai=="belgica")
                                                                                                                {
                                                                                                                    i=0;
                                                                                                                    foreach (var j in Albumdemundial)
                                                                                                                    {
                                                                                                                        if("belgica"==Albumdemundial[i].paises())
                                                                                                                        {
                                                                                                                            totaldefig++;
                                                                                                                        }
                                                                                                                        i++; 
                                                                                                                    }
                                                                                                                    if(totaldefig<11)
                                                                                                                    {
                                                                                                                        if(figu>=265&&figu<=275)
                                                                                                                        {
                                                                                                                            i=0;
                                                                                                                            foreach (var j in Albumdemundial)
                                                                                                                            {
                                                                                                                                if(figu==Albumdemundial[i].figur())
                                                                                                                                {
                                                                                                                                    repetida++;
                                                                                                                                }
                                                                                                                                i++; 
                                                                                                                            }
                                                                                                                            if(repetida>0)
                                                                                                                            {
                                                                                                                                Console.WriteLine("La figurita esta repetida");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                i=0;
                                                                                                                                foreach (var k in Albumdemundial)
                                                                                                                                {
                                                                                                                                    if("delantero"==Albumdemundial[i].posici())
                                                                                                                                    {
                                                                                                                                        cantdel++;
                                                                                                                                    }
                                                                                                                                    if(Albumdemundial[i].posic())
                                                                                                                                    {
                                                                                                                                        cantmed++;
                                                                                                                                    }
                                                                                                                                    i++;
                                                                                                                                }        
                                                                                                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            Console.WriteLine("las figuritas de Belgica son del 265 al 275");
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        Console.WriteLine("Belgica ya esta completo");
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if(pai=="panama")
                                                                                                                    {
                                                                                                                        i=0;
                                                                                                                        foreach (var j in Albumdemundial)
                                                                                                                        {
                                                                                                                            if("panama"==Albumdemundial[i].paises())
                                                                                                                            {
                                                                                                                                totaldefig++;
                                                                                                                            }
                                                                                                                            i++; 
                                                                                                                        }
                                                                                                                        if(totaldefig<11)
                                                                                                                        {
                                                                                                                            if(figu>=276&&figu<=286)
                                                                                                                            {
                                                                                                                                i=0;
                                                                                                                                foreach (var j in Albumdemundial)
                                                                                                                                {
                                                                                                                                    if(figu==Albumdemundial[i].figur())
                                                                                                                                    {
                                                                                                                                        repetida++;
                                                                                                                                    }
                                                                                                                                    i++; 
                                                                                                                                }
                                                                                                                                if(repetida>0)
                                                                                                                                {
                                                                                                                                    Console.WriteLine("La figurita esta repetida");
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                    i=0;
                                                                                                                                    foreach (var k in Albumdemundial)
                                                                                                                                    {
                                                                                                                                        if("delantero"==Albumdemundial[i].posici())
                                                                                                                                        {
                                                                                                                                            cantdel++;
                                                                                                                                        }
                                                                                                                                        if(Albumdemundial[i].posic())
                                                                                                                                        {
                                                                                                                                            cantmed++;
                                                                                                                                        }
                                                                                                                                        i++;
                                                                                                                                    }        
                                                                                                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                Console.WriteLine("las figuritas de Panama son del 276 al 286");
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            Console.WriteLine("Panama ya esta completo");
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if(pai=="tunez")
                                                                                                                        {
                                                                                                                            i=0;
                                                                                                                            foreach (var j in Albumdemundial)
                                                                                                                            {
                                                                                                                                if("tunez"==Albumdemundial[i].paises())
                                                                                                                                {
                                                                                                                                    totaldefig++;
                                                                                                                                }
                                                                                                                                i++; 
                                                                                                                            }
                                                                                                                            if(totaldefig<11)
                                                                                                                            {
                                                                                                                                if(figu>=287&&figu<=297)
                                                                                                                                {
                                                                                                                                    i=0;
                                                                                                                                    foreach (var j in Albumdemundial)
                                                                                                                                    {
                                                                                                                                        if(figu==Albumdemundial[i].figur())
                                                                                                                                        {
                                                                                                                                            repetida++;
                                                                                                                                        }
                                                                                                                                        i++; 
                                                                                                                                    }
                                                                                                                                    if(repetida>0)
                                                                                                                                    {
                                                                                                                                        Console.WriteLine("La figurita esta repetida");
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                        i=0;
                                                                                                                                        foreach (var k in Albumdemundial)
                                                                                                                                        {
                                                                                                                                            if("delantero"==Albumdemundial[i].posici())
                                                                                                                                            {
                                                                                                                                                cantdel++;
                                                                                                                                            }
                                                                                                                                            if(Albumdemundial[i].posic())
                                                                                                                                            {
                                                                                                                                                cantmed++;
                                                                                                                                            }
                                                                                                                                            i++;
                                                                                                                                        }        
                                                                                                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    Console.WriteLine("las figuritas de Tunez son del 287 al 297");
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                Console.WriteLine("Tunez ya esta completo");
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if(pai=="inglaterra")
                                                                                                                            {
                                                                                                                                i=0;
                                                                                                                                foreach (var j in Albumdemundial)
                                                                                                                                {
                                                                                                                                    if("inglaterra"==Albumdemundial[i].paises())
                                                                                                                                    {
                                                                                                                                        totaldefig++;
                                                                                                                                    }
                                                                                                                                    i++; 
                                                                                                                                }
                                                                                                                                if(totaldefig<11)
                                                                                                                                {
                                                                                                                                    if(figu>=298&&figu<=308)
                                                                                                                                    {
                                                                                                                                        i=0;
                                                                                                                                        foreach (var j in Albumdemundial)
                                                                                                                                        {
                                                                                                                                            if(figu==Albumdemundial[i].figur())
                                                                                                                                            {
                                                                                                                                                repetida++;
                                                                                                                                            }
                                                                                                                                            i++; 
                                                                                                                                        }
                                                                                                                                        if(repetida>0)
                                                                                                                                        {
                                                                                                                                            Console.WriteLine("La figurita esta repetida");
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                            i=0;
                                                                                                                                            foreach (var k in Albumdemundial)
                                                                                                                                            {
                                                                                                                                                if("delantero"==Albumdemundial[i].posici())
                                                                                                                                                {
                                                                                                                                                    cantdel++;
                                                                                                                                                }
                                                                                                                                                if(Albumdemundial[i].posic())
                                                                                                                                                {
                                                                                                                                                    cantmed++;
                                                                                                                                                }
                                                                                                                                                i++;
                                                                                                                                            }        
                                                                                                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        Console.WriteLine("las figuritas de Inglaterra son del 298 al 308");
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    Console.WriteLine("Inglaterra ya esta completo");
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if(pai=="polonia")
                                                                                                                                {
                                                                                                                                    i=0;
                                                                                                                                    foreach (var j in Albumdemundial)
                                                                                                                                    {
                                                                                                                                        if("polonia"==Albumdemundial[i].paises())
                                                                                                                                        {
                                                                                                                                            totaldefig++;
                                                                                                                                        }
                                                                                                                                        i++; 
                                                                                                                                    }
                                                                                                                                    if(totaldefig<11)
                                                                                                                                    {
                                                                                                                                        if(figu>=309&&figu<=319)
                                                                                                                                        {
                                                                                                                                            i=0;
                                                                                                                                            foreach (var j in Albumdemundial)
                                                                                                                                            {
                                                                                                                                                if(figu==Albumdemundial[i].figur())
                                                                                                                                                {
                                                                                                                                                    repetida++;
                                                                                                                                                }
                                                                                                                                                i++; 
                                                                                                                                            }
                                                                                                                                            if(repetida>0)
                                                                                                                                            {
                                                                                                                                                Console.WriteLine("La figurita esta repetida");
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                                i=0;
                                                                                                                                                foreach (var k in Albumdemundial)
                                                                                                                                                {
                                                                                                                                                    if("delantero"==Albumdemundial[i].posici())
                                                                                                                                                    {
                                                                                                                                                        cantdel++;
                                                                                                                                                    }
                                                                                                                                                    if(Albumdemundial[i].posic())
                                                                                                                                                    {
                                                                                                                                                        cantmed++;
                                                                                                                                                    }
                                                                                                                                                    i++;
                                                                                                                                                }        
                                                                                                                                                Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            Console.WriteLine("las figuritas de Polonia son del 309 al 319");
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        Console.WriteLine("Polonia ya esta completo");
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if(pai=="senegal")
                                                                                                                                    {
                                                                                                                                        i=0;
                                                                                                                                        foreach (var j in Albumdemundial)
                                                                                                                                        {
                                                                                                                                            if("senegal"==Albumdemundial[i].paises())
                                                                                                                                            {
                                                                                                                                                totaldefig++;
                                                                                                                                            }
                                                                                                                                            i++; 
                                                                                                                                        }
                                                                                                                                        if(totaldefig<11)
                                                                                                                                        {
                                                                                                                                            if(figu>=320&&figu<=330)
                                                                                                                                            {
                                                                                                                                                i=0;
                                                                                                                                                foreach (var j in Albumdemundial)
                                                                                                                                                {
                                                                                                                                                    if(figu==Albumdemundial[i].figur())
                                                                                                                                                    {
                                                                                                                                                        repetida++;
                                                                                                                                                    }
                                                                                                                                                    i++; 
                                                                                                                                                }
                                                                                                                                                if(repetida>0)
                                                                                                                                                {
                                                                                                                                                    Console.WriteLine("La figurita esta repetida");
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                                    i=0;
                                                                                                                                                    foreach (var k in Albumdemundial)
                                                                                                                                                    {
                                                                                                                                                        if("delantero"==Albumdemundial[i].posici())
                                                                                                                                                        {
                                                                                                                                                            cantdel++;
                                                                                                                                                        }
                                                                                                                                                        if(Albumdemundial[i].posic())
                                                                                                                                                        {
                                                                                                                                                            cantmed++;
                                                                                                                                                        }
                                                                                                                                                        i++;
                                                                                                                                                    }        
                                                                                                                                                    Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                Console.WriteLine("las figuritas de Senegal son del 320 al 330");
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            Console.WriteLine("Senegal ya esta completo");
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if(pai=="colombia")
                                                                                                                                        {
                                                                                                                                            i=0;
                                                                                                                                            foreach (var j in Albumdemundial)
                                                                                                                                            {
                                                                                                                                                if("colombia"==Albumdemundial[i].paises())
                                                                                                                                                {
                                                                                                                                                    totaldefig++;
                                                                                                                                                }
                                                                                                                                                i++; 
                                                                                                                                            }
                                                                                                                                            if(totaldefig<11)
                                                                                                                                            {
                                                                                                                                                if(figu>=331&&figu<=341)
                                                                                                                                                {
                                                                                                                                                    i=0;
                                                                                                                                                    foreach (var j in Albumdemundial)
                                                                                                                                                    {
                                                                                                                                                        if(figu==Albumdemundial[i].figur())
                                                                                                                                                        {
                                                                                                                                                            repetida++;
                                                                                                                                                        }
                                                                                                                                                        i++; 
                                                                                                                                                    }
                                                                                                                                                    if(repetida>0)
                                                                                                                                                    {
                                                                                                                                                        Console.WriteLine("La figurita esta repetida");
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                                        i=0;
                                                                                                                                                        foreach (var k in Albumdemundial)
                                                                                                                                                        {
                                                                                                                                                            if("delantero"==Albumdemundial[i].posici())
                                                                                                                                                            {
                                                                                                                                                                cantdel++;
                                                                                                                                                            }
                                                                                                                                                            if(Albumdemundial[i].posic())
                                                                                                                                                            {
                                                                                                                                                                cantmed++;
                                                                                                                                                            }
                                                                                                                                                            i++;
                                                                                                                                                        }        
                                                                                                                                                        Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Console.WriteLine("las figuritas de Colombia son del 331 al 341");
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                Console.WriteLine("Colombia ya esta completo");
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if(pai=="japon")
                                                                                                                                            {
                                                                                                                                                i=0;
                                                                                                                                                foreach (var j in Albumdemundial)
                                                                                                                                                {
                                                                                                                                                    if("japon"==Albumdemundial[i].paises())
                                                                                                                                                    {
                                                                                                                                                        totaldefig++;
                                                                                                                                                    }
                                                                                                                                                    i++; 
                                                                                                                                                }
                                                                                                                                                if(totaldefig<11)
                                                                                                                                                {
                                                                                                                                                    if(figu>=342&&figu<=352)
                                                                                                                                                    {
                                                                                                                                                        i=0;
                                                                                                                                                        foreach (var j in Albumdemundial)
                                                                                                                                                        {
                                                                                                                                                            if(figu==Albumdemundial[i].figur())
                                                                                                                                                            {
                                                                                                                                                                repetida++;
                                                                                                                                                            }
                                                                                                                                                            i++; 
                                                                                                                                                        }
                                                                                                                                                        if(repetida>0)
                                                                                                                                                        {
                                                                                                                                                            Console.WriteLine("La figurita esta repetida");
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            Albumdemundial.Add(new Mundial(nom,pos,pai,figu));
                                                                                                                                                            i=0;
                                                                                                                                                            foreach (var k in Albumdemundial)
                                                                                                                                                            {
                                                                                                                                                                if("delantero"==Albumdemundial[i].posici())
                                                                                                                                                                {
                                                                                                                                                                    cantdel++;
                                                                                                                                                                }
                                                                                                                                                                if(Albumdemundial[i].posic())
                                                                                                                                                                {
                                                                                                                                                                    cantmed++;
                                                                                                                                                                }
                                                                                                                                                                i++;
                                                                                                                                                            }        
                                                                                                                                                            Console.WriteLine("Hay "+cantdel+" delanteros\nHay "+cantmed+" mediocampistas");
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        Console.WriteLine("las figuritas de Japon son del 342 al 352");
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Console.WriteLine("Japon ya esta completo");
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                Console.WriteLine("Ingrese un pais del mundial");
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }    
                    }
                }
            }
            else
            {
                Console.WriteLine("Felicidades su album ya esta completo con "+cantdel+" delanteros\n y "+cantmed+" mediocampistas");
            } 
            return otro;
        }
    }
}