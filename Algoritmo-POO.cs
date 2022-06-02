// Este algoritmo foi passado nessa aula -> https://www.youtube.com/watch?v=ull_DVFFOq0

// Os códigos apresentados são apenas uma representação de como criar um objeto.
// Pode ser usado em qualquer linguagem.

// Abaixo é apenas um algoritmo, não segue a risca as funções do CSharp.

    // set = 
    // get = Não recebe parametro nenhum, apenas retorna o nome do ATRIBUTO. 

Classe ContaBanco
    // Atributos
    publico numConta: Inteiro;
    protegido tipo: Caractere;
    privado dono: Caractere;
    privado saldo: Real;
    privado status: Lógico;

    // Métodos especiais
    publico Metodo Construtor()
    {
        saldo = 0;
        status= falso;
    }
    FimMetodo
        publico Metodo setNumConta(n:Inteiro)
        {
             numConta = n;
        }
        publico Metodo getNumConta()
        {
            retorne numConta;
        }
        FimMetodo
        publico Metodo setTipo(t:Caractere)
        {
            tipo = t;
        }
        publico Metodo getTipo()
        {
            retorne tipo;
        }
        FimMetodo
        publico Metodo setDono (d:Caractere)
        {
            dono = d;
        }
        FimMetodo
        publico Metodo getDono()
        {
            retorne dono;
        }
        FimMetodo
        publico Metodo setSaldo(s:Real)
        {
            saldo =s;
        }
        FimMetodo
        publico metodo getSaldo()
        {
            retorne saldo;
        }
        FimMetodo
        publico Metodo setStatus(s:Lógico)
        {
            status = s;
        }
        FimMetodo
        publico Metodo getStatus()
        {
            retorne status;
        }
        FimMetodo

    // Métodos
    publico Metodo abrirConta(t:Caractere)
    {
        setTipo(t);
        setStatus(verdadeiro)
        se (t = "CC") entao
            saldo = 50;
        senao se (t = "CP") entao
            saldo = 150; 
        FimSe       
    }
    FimMetodo
    publico Metodo fecharConta()
    {
        se (saldo > 0) entao
            Escreva ("Conta com dinheiro");
        senao se (saldo < 0) entao
            Escreva ("Conta em débito");
        senao
            setStatus(false)
        FimSe
    }
    FimMetodo
    publico Metodo depositar(v:Real)
    {
        se (status = verdadeiro) entao
            setSaldo(getSaldo() + v);
        senao
            Escreva("Impossível depositar");
        FimSe 
    }
    FimMetodo
    publico Metodo sacar(v:Real)
    {
        se (status = verdadeiro) entao
            se (saldo > v) entao    
                setSaldo(getsaldo() + v );
            senao
                Escreva("Saldo insuficiente");
            FimSe
        senao
            Escreva("Impossível sacar");
        FimSe                
    }
    FimMetodo
    publico Metodo pagarMensal()
    {
        var v: Real
        se (tipo = "CC") entao
            v = 12;
        senao se (tipo = "CP") entao
            v = 20;
        FimSe    

        se(status = verdadeiro) entao
            se (saldo > v)  entao
                saldo = saldo - v;
            senao
                Escreva("Saldo insuficiente");
            FimSe
        senao
            Escreva("Impossível pagar");
        FimSe                  
    }
    FimMetodo

FimClasse