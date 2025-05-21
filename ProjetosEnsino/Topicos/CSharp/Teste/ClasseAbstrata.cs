namespace Teste
{
  public abstract class ClasseAbstrata
  {
    private int _valor;

    public ClasseAbstrata()
    {
      _valor = -5;
    }

    public ClasseAbstrata(int valor)
    {
      _valor = valor;
    }

    public abstract void MostrarValor();

    public int Valor
    {
      get { return _valor; }
      set { _valor = value; }
    }

  }
}