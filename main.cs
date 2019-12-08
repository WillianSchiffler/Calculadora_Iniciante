using System;

class MainClass {
  public static void Main () {
    
    int x = -1;

    Console.WriteLine("Qual a qtd de nº?");
    int qtd = int.Parse(Console.ReadLine());
    double[] num = new double[qtd];

    do{
    Console.WriteLine("1- Carregar números; 2- Fazer operação; 3 - Visualizar vetor; -1 - sair");
    
    x = int.Parse(Console.ReadLine());

      switch (x){
        case 1: 
        for(int y=0; y<qtd; y++){
          Console.WriteLine("Digite o próx. nº:");
          num[y] = double.Parse(Console.ReadLine());
        }
        break;

        case 2:
        Console.WriteLine("Qual a operação desejada? + - * /");
        char op = char.Parse(Console.ReadLine());

        switch(op){
          case '+':
          Console.WriteLine("Resultado: {0}", calc.soma(num, qtd));
          break;

          case '-':
          Console.WriteLine("Resultado: {0}", calc.sub(num, qtd));
          break;

          case '*':
          Console.WriteLine("Resultado: {0}", calc.mult(num, qtd));
          break;

          case '/':
          try{
            Console.WriteLine("Resultado: {0}", calc.div(num, qtd));
          }
          catch(DivideByZeroException){
            Console.WriteLine("DIVISÃO POR 0!!");
          }
          break;

          default: 
          Console.WriteLine("Operação inválida!");
          break;
        }
        break;

        case 3:
        Console.WriteLine("Qual posição gostaria de visualizar?");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Posição: {0}   Nº: {1}", pos, num[pos-1]);
        break;

        default:
        Console.WriteLine("Opção inválida!");
        break;
      }
    } while(x>0);
  }
}