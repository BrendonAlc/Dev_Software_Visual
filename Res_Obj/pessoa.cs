using System;

namespace Res_Obj{
    class Pessoa {
        int idade;
        string nome;
        
            public void setIdade(int n){
                this.idade=n;
            }
            
            public Pessoa(string n, idade i){
                nome = n;
                idade = i;
            }

            public int getIdade(){
                return idade;
            }   
    }
}
