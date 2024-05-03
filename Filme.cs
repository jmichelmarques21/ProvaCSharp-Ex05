using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Filme{
        private string titulo = "";
        private string genero = "";
        private int duracao;
        private bool disponivel;

        public void setTitulo(string titulo) {
            this.titulo = titulo;
        }

        public string getTitulo(){
            return this.titulo;
        }

        public void setGenero(string genero) {
            this.genero = genero;
        }

        public string getGenero(){
            return this.genero;
        }

        public void setDuracao(int duracao) {
            this.duracao = duracao;
        }

        public int getDuracao(){
            return this.duracao;
        }

        public void setDisponivel(bool disponivel) {
            this.disponivel = disponivel;
        }

        public bool getDisponivel(){
            return this.disponivel;
        }

        public void locarFilme(){
            this.disponivel = false;
        }

        public void devolverFilme(){
            this.disponivel = true;
        }

        public bool verificaDisponibilidade(){
            return this.disponivel;
        }

    }
}