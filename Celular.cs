namespace Atividade04
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool retorno;
        public string celularLigando;
        public string celularDesligando;
        public string ligacao;
        public string mensagem;
        public string seLigar;
        



        /// <summary>
        /// Melhora a resposta do usuário
        /// </summary>
        /// <param name="condicao">texto capturado pelo console</param>
        /// <returns>Se o celular quer ser ligado ou não</returns>
        public bool TraduzirConsole(string condicao){
            if(condicao == "sim" || condicao == "Sim" || condicao == "sIm" ){
                retorno = true;
            }else{
                retorno = false; 
            }
            return retorno;
        }

        /// <summary>
        /// Ligar o celular
        /// </summary>
        /// <returns>Se foi ligado o celular ou não</returns>
        public string LigandoCelular(){
            if(retorno == true){
                celularLigando = "O celular foi ligado";
            }
            return celularLigando;
        }

        public string FazendoLigacao(){
            if(retorno == true){
                ligacao = "Realizando ligação";
            }else{
                ligacao = "Não foi possível realizar a ligação";
            }
            return ligacao;
        }

        public string MandandoMensagem(){
            
            if(retorno == true){
                mensagem = "Digite sua mensagem:";
            }else{
                mensagem = "Não foi possível mandar a sua mensagem";
            }
            return mensagem;
        }

        public string Desligando(){
            if(retorno == true){
                celularDesligando = "O celular foi desligado";
            }else{
                
            }
            return celularDesligando;
        }

    }
}