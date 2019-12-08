using System;

class calc{

  public static double soma(double[] vet, int qtd){
    double result = vet[0];
    for(int x=1; x<qtd; x++){
      result += vet[x];
    }
    return result;
  }

  public static double sub(double[] vet, int qtd){
    double result = vet[0];
    for(int x=1; x<qtd; x++){
      result -= vet[x];
    }
    return result;
  }

  public static double mult(double[] vet, int qtd){
    double result = vet[0];
    for(int x=1; x<qtd; x++){
      result *= vet[x];
    }
    return result;
  }

  public static double div(double[] vet, int qtd){
    double result = vet[0];
    for(int x=1; x<qtd; x++){
      if(vet[x] == 0){
        throw new DivideByZeroException();
      }
      result /= vet[x];
    }
    return result;
  }
}