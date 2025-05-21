namespace Teste
{
  public class ClasseDerivada : ClasseAbstrata
  {

    using UnityEngine;
    using UnityEditor;
    using UnityEngine.UIElements;
    using UnityEditor.UIElements;
    
    [CustomPropertyDrawer(typeof())]
    public class ClasseDerivada : PropertyDrawer
    {
      public override VisualElement CreatePropertyGUI(SerializedProperty property)
      {
        throw new System.NotImplementedException();
      }
    }
    private int _valor;
    public int Valor
    {
      get { return _valor; }
      set { _valor = value; }
    }
    private string _texto;
    public string Texto
    {
      get { return _texto; }
      set { _texto = value; }
    }
    public ClasseDerivada()
    {
      _valor = -10;
    }

    public override void MostrarValor()
    {
      Console.WriteLine(_valor);
      Console.WriteLine(base.Valor);
    }
  }

}