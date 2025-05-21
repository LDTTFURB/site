// FILE: ProgramTest.cs
using System;
using Xunit;

public class ProgramTest
{
  [Fact]
  public void TestBitwiseOperations()
  {
    int numero = 5; // Em binário: 0000 0101
    int complemento = ~numero; // Inverte os bits

    Assert.Equal(5, numero);
    Assert.Equal(-6, complemento);
    Assert.Equal("00000000000000000000000000000101", Convert.ToString(numero, 2).PadLeft(32, '0'));
    Assert.Equal("11111111111111111111111111111010", Convert.ToString(complemento, 2).PadLeft(32, '0'));
  }

  [Fact]
  public void TestTestePassagemParametro()
  {
    int valor = 5;
    Program.TestePassagemParametro(ref valor);
    Assert.Equal(10, valor);
  }

  [Fact]
  public void TestDivNumeroOperations()
  {
    int divNumero = 10;
    divNumero <<= 1;
    divNumero >>= 1;
    divNumero >>= 1;
    divNumero >>= 1;

    Assert.Equal(1, divNumero);
  }
}using UnityEngine;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Burst;
using Unity.Jobs;

public struct ProgramTest : IJob
{
  public void Execute()
  {
    
  }
}