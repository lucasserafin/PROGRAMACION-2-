using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacion
{
    class ListaVotacion
    {
        #region Propiedades;
        private string[,] candidato = new string[3,2];        
        private int numPosicion = 0;
        string Resultado = "";
        int count;
        #endregion

        #region Metodos  
        public String CargarDatos(string cCandidato, string cVoto)
        {
          
            candidato[numPosicion,0] = cCandidato;
            candidato[numPosicion,1] = cVoto;
            numPosicion++;

            Resultado += cCandidato + "-------------------------" + cVoto + "\r";
            return Resultado;

        }
        public string recuento()
        {
            count = Convert.ToInt32(candidato[0, 1]) + Convert.ToInt32(candidato[1, 1]) + Convert.ToInt32(candidato[2, 1]);
            string conteo =count.ToString();
            return conteo;
        }
        public string porcentaje ()
        {
            int porciento = (Convert.ToInt32(candidato[0,1])*100)/ count;
            string aux = candidato[0, 0] + " HA GANADO CON EL " + porciento.ToString() + " % DE LOS VOTOS";
            return aux;

        }
        public string perdedor ()
        {
            int dif = Convert.ToInt32(candidato[0, 1]) - Convert.ToInt32(candidato[2, 1]);
            string aux = candidato[2, 0] + " HA PERDIDO"+ "\n" +"CON LA MENOR CANTIDAD DE VOTOS DE " + candidato[2, 1] + "\n \r" + "CON UNA DIFERENCIA CON EL GANADOR DE " + dif.ToString()+ " VOTOS";
            return aux;
        }

        public string ganador()
        {
            string aux="EL GANADOR ES   "+ candidato[0, 0].ToString() + "\n"+"CON UN TOTAL DE VOTOS DE " + candidato[0, 1].ToString();
            return aux;
        }
        public void Ordenar()
        {

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {

                    if (Convert.ToInt32(candidato[i, 1]) < (Convert.ToInt32(candidato[i + 1, 1])))
                    {
                        string auxC = "";
                        string auxV = "";


                        auxC = candidato[i, 0];
                        auxV = candidato[i, 1];
                        candidato[i, 0] = candidato[i + 1, 0];
                        candidato[i, 1] = candidato[i + 1, 1];

                        candidato[i + 1, 0] = auxC;
                        candidato[i + 1, 1] = auxV;


                    }
                    

                }


            }
        }
        public string registro()
        {
            string aux = "";
           
            for (int i = 0; i < 3; i++)
            {
                aux += this.candidato[i, 0] + " ------------------------- " + this.candidato[i, 1] + "\r\n";
                        
                
               
            }
            return aux;
        }
    }
                   
                }

        #endregion

    

