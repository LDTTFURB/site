# Manual de Boas Práticas Unity e C-Sharp

## Resumo

Esta página tem como objetivo apresentar padrões de projeto e boas práticas de programação no desenvolvimento de jogos em Unity e C-Sharp. Para cada etapa é mostrado um resumo dessa prática com links de auxílio.  

Porém já se adianta que os padrões de projeto aplicados em Unity na sua maioria são aplicados usando as funcionalidades da própria Engine. Dessa maneira a implementação do padrão é facilitada, porém foge um pouco da sua teoria e consequentemente da sua implementação, se comparado a um sistema genérico usando C-Sharp puro.  

Uma última observação é que no caso do projeto Furbot, todas as referências são tiradas dos vídeos em inglês, pelo fato dos vídeos serem mais completos e a implementação do Furbot ser em inglês.  

## Padrões do Projeto

Nesta seção contém alguns dos padrões de projeto mais conhecidos. A aplicação deles vai sempre depender do planejamento, arquitetura e necessidade do seu projeto.  

### Singleton

Singleton é um padrão de projeto de software. Este padrão garante a existência de apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto.  

**EN**: [Everything You Need to Know About Singletons in Unity](https://youtu.be/mpM0C6quQjs)  
**PT-BR** [Como Criar Singletons na Unity em C# - Tutorial Rápido # 01](https://youtu.be/-IdHXqXON1o)  

### Padrão Observer

O Observer é um padrão de projeto comportamental que permite que um objeto notifique outros objetos sobre alterações em seu estado. Este padrão fornece uma maneira de assinar e cancelar a assinatura desses eventos para qualquer objeto que implemente uma interface de assinante.  

**EN**: [Observer Pattern - Game Programming Patterns in Unity & C#](https://youtu.be/Yy7Dt2usGy0)  
**PT-BR**: [Usando eventos no desenvolvimento de jogos - Tutorial](https://youtu.be/EydZk5MFB78)  

### Padrão Command

O Command é um padrão de projeto comportamental que converte solicitações ou operações simples em objetos. A conversão permite a execução adiada ou remota de comandos, armazenamento do histórico de comandos, etc.  

**EN**: [Command Pattern - Game Programming Patterns in Unity & C#](https://youtu.be/UoNumkMTx-U)  
**PT-BR**: [Command Pattern in Unity](https://youtu.be/dt-qYkZ3Mt0) _(Apenas com legendas)_  

### Padrão State

O padrão de estado é um padrão de projeto de software comportamental que implementa uma máquina de estado de forma orientada a objetos. Esse padrão é usado na programação de computadores para encapsular o comportamento variável do mesmo objeto com base em seu estado interno.  

**EN**: [The 6 Design Patterns game devs need?](https://youtu.be/hQE8lQk9ikE?t=1276)  _(21:15)_  
**PT-BR**: [Como usar Design Pattern - Finite State Machine com Unity e C#](https://youtu.be/i-VkhmDfrok)  

### Padrão Flyweight

O Flyweight é um padrão de projeto estrutural que permite que os programas suportem grandes quantidades de objetos, mantendo baixo o consumo de memória. O padrão consegue isso compartilhando partes do estado do objeto entre vários objetos.  

**EN**: [The 6 Design Patterns game devs need?](https://youtu.be/hQE8lQk9ikE?t=1061)  _(17:41)_  
**PT-BR**: [Designpatterns in Unity - Flyweight 01](https://youtu.be/By579DX9aYc) _(Apenas com legendas)_  

## Código Fonte

### Interfaces

**EN**: [What are Interfaces? (C# Basics)](https://youtu.be/MZOrGXk4XFI)  

### Delegates

**EN**: [What are Delegates? (C# Basics, Lambda, Action, Func)](https://youtu.be/3ZfwqWl-YI0)  

### Events

**EN**: [What are Events? (C# Basics)](https://youtu.be/OuZrhykVytg)  

### Scriptable Objects

**EN**: [SCRIPTABLE OBJECTS in Unity](https://youtu.be/aPXvoWVabPY)  
**PT-BR**: [USANDO SCRIPTABLE OBJECTS NA UNITY | TUTORIAL](https://youtu.be/_6yYIf__m7s)  

### Dicas de refatoração

**EN**: [4 Tips for Refactoring Your Code for Readability](https://youtu.be/7oZBfpI_hxI)  
**PT-BR**: [7 Dicas para Melhorar seus Códigos - Unity C#](https://youtu.be/B2ikFkFWSLM)  

### SOLID

SOLID são cinco princípios da programação orientada a objetos que facilitam no desenvolvimento de softwares, tornando-os fáceis de manter e estender. Esses princípios podem ser aplicados a qualquer linguagem de POO.  

[Artigo em português](https://medium.com/desenvolvendo-com-paixao/o-que-%C3%A9-solid-o-guia-completo-para-voc%C3%AA-entender-os-5-princ%C3%ADpios-da-poo-2b937b3fc530)  

**EN**:

- **Parte 1**: [SOLID Principles in Unity](https://youtu.be/QDldZWvNK_E)  
- **Parte 2**: [Learn By Example - SOLID Principles in Unity (Part 2)](https://youtu.be/Fs8jy7DHDyc)  

**PT-BR**: [SOLID fica FÁCIL com Essas Ilustrações](https://youtu.be/6SfrO3D4dHM)  

## Interface do Usuário

### Configuração da Interface

A importância de uma configuração está na decisão das resoluções que seu jogo irá rodar. Hoje em dia a dificuldade está nos inúmeros tipos de resoluções causadas pelos diversos tipos e tamanhos de celulares.  

**EN**: [Simple UI Setup (Unity Tutorial for Beginners)](https://youtu.be/VHFJgQraVUs)  
**PT-BR**: [Como fazer Interface ajustável no Unity - UI Responsiva](https://youtu.be/5rosjAX2Cag)  

### Otimização do DrawCalls

DrawCalls é o método da API gráfica responsável pelo desenho do objeto na interface. Esse método é chamado para cada grupo de imagens, esse grupos se chamam Batch. Colocando seus assets de imagem em um mesmo Batch minimiza a quantidade de DrawCalls em um único frame.  

**EN**: [Unity Optimize UI - Reduce your Draw Calls Improve your performance in 10 MINUTES!](https://youtu.be/_EmwV98r4RY)  
**PT-BR**: [Utilizando Sprite Atlas em Unity3D](https://youtu.be/tfqwa-eImcw)  

### Panel Manager

Uma das etapas que rendem bastante trabalho é o gerenciamento dos painéis e pop ups que precisam ser habilitados e desabilitados constantemente em um jogo. Não só num caso de interface como esse, mas para gerenciar sistemas do jogo, utilizamos alguns scripts com esta finalidade. O link abaixo mostra o passo a passo de um script de gerenciamento de Panels em Unity.  

**EN**: [Unity Panel Manager - Panels & Popups the RIGHT WAY! (Unity 2021)](https://youtu.be/texonivDsy0)  

## Design de Áudio

### Audio Manager

Igual Panel Manager usa-se uma maneira de tocar áudios do jogo de um só lugar, sem espalhar referências de áudio em todo código fonte.  

**EN**: [Simple Sound Manager (Unity Tutorial)](https://youtu.be/QL29aTa7J5Q)  

### Funcionalidades de Áudio

Indo um pouco na contramão do objetivo desta página, mas o link abaixo apresenta as funcionalidades do Unity para o processo de criação e modificação dos áudios.  

**EN**: [What you NEED to know about game audio as a beginner in 2021! Unity3d](https://youtu.be/B9yxkJuHLek)
