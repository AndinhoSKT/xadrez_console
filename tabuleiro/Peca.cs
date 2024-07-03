
using System.Runtime.InteropServices;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
           this.posicao = null;
           this.tab = tab;
           this.cor = cor;
           this.qteMovimentos = 0;
        }

        public void incrementarQteMovimento() {  //ver onde é local certo
            qteMovimentos++;
        }

        public void decrementarQteMovimento() {  //ver onde é local certo
            qteMovimentos--;
        }

        public bool existerMovimentoPossiveis()
        {
            bool[,] mat = movimentoPossiveis();
            for (int i=0; i<tab.linhas; i++){
                for (int j = 0; j<tab.colunas; j++){
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentoPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentoPossiveis();
     
  } 
}