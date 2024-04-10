# O que é Unity?

**Unity** é um motor gratuito para desenvolvimento de _videogames_ 2D e 3D para diversas plataformas. Essa ferramenta, conhecida por ter sido utilizada na produção de jogos como **Cuphead**, **Hollow Knight** e **Ori and the Blind Forest**, possui todas funcionalidades típicas de uma _game engine_, como motor gráfico para renderização de gráficos 2D e 3D, motor de física que simula as interações entre objetos e programação por scripting, que na Unity, é feita através da **linguagem C#**.  

![Interface da Unity](https://github.com/LDTTFURB/site/assets/126025055/17ad2405-66a9-434e-b883-f497a4cb6f14)  

## Cursos Udemy  

[O Guia Definitivo para Desenvolvimento de Jogos com Unity](https://www.udemy.com/share/101IFc3@cVok5vxk0j-iW8plhgiYrzJhavlFfBVykhsEwdWuhq_78qf4yLYAbWT35bHUkOht/)  
[Animação 2D Disney - Guia Completo ( nível 1 - iniciante )](https://www.udemy.com/share/101SiQ3@wmBHN3MCoswA7EFj9gePuNYsR-9enM61ShZw8tGGjTH8Bwj7AgIU8GJucFts_b66/)  
[Curso Completo de Design de Interface](https://www.udemy.com/share/101XfS3@IYJAQElMLyBENoV1iYYDyxEFDLDjGa9YEUEUZ0RrXJB83Oi7ms1z79abvlZUypOu/)  
[Academia UNITY 2D - Produção de Jogos](https://www.udemy.com/share/101QmK3@T4YT7avmk-a2FWQuZzlv8cy4VDRtRWGLbLWfdfe-WjaS8_PpYEClBiZmfhPQzUh5/)  

[Complete C# Unity Game Developer 3D](https://www.udemy.com/course/unitycourse2/?kw=complete+c%23&src=sac)  
[RPG Core Combat Creator: Learn Intermediate Unity C# Coding](https://www.udemy.com/course/unityrpg/?kw=rpg+core&src=sac)  
[Complete Blender Creator: Learn 3D Modelling for Beginners](https://www.udemy.com/course/blendertutorial/?kw=complete+blender&src=sac)  
[Ultimate Blender 3D Character Creation & Animation Course](https://www.udemy.com/course/blender3dcharacteranimation/?kw=ultimate+blender+3d&src=sac)  
[Creating 3D environments in Blender](https://www.udemy.com/course/blender-environments/?kw=creating+3d+blender&src=sac)  
[The Beginner's Guide to Artificial Intelligence (Unity 2022)](https://www.udemy.com/course/artificial-intelligence-in-unity/?kw=the+beginner%27s+guide+to&src=sac)  
[Modern UI Development in Unity 4.6/5.0](https://www.udemy.com/course/modern-ui-development-in-unity-46-or-50/?kw=modern+ui&src=sac)  
[Procedural Terrain Generation with Unity](https://www.udemy.com/course/procedural-terrain-generation-with-unity/?kw=procedural&src=sac)  
[How to Program Voxel Worlds Like Minecraft with C# in Unity](https://www.udemy.com/course/unityminecraft/?kw=how+to+program+voxel&src=sac)  

[Learn To Create A Complete Menu System in Unity](https://www.udemy.com/course/unitymenus/?start=0#overview)  
[Unity 3D - Create a Reusable UI System](https://www.udemy.com/course/unity-2017-create-a-reusable-ui-system/?start=0#overview)  
[Desenvolvimento 3D com Unity 2019 + Multiplayer](https://www.udemy.com/course/desenvolvimento-3d-com-unity-2019-multiplayer/?start=0#overview)  
[Criando Páginas Web com o GitHub Pages](https://www.udemy.com/course/github-pages/?start=0#overview)  
[Aprenda Unity 5 (2016) - Como criar um jogo de plataforma 3D](https://www.udemy.com/course/como-criar-um-jogo-de-plataforma-3d-aprenda-unity-5/?start=0#overview)  
[Aprenda Unity 2D e 3D e Programação em C#](https://www.udemy.com/course/aprenda-unity-2018-e-faca-seu-primeiro-jogo/#overview)  
[Git e contribuições para projetos Open Source](https://www.udemy.com/course/git-e-github/learn/lecture/6995588?start=0#overview)  

## Manual de Boas Práticas Unity e C-Sharp

Para prosseguir para o manual [clique aqui](./Manual-de-Boas-Pr%C3%A1ticas-Unity-e-C-Sharp)

# Profiler (geral)

O profiler é uma ferramenta integrada ao Unity que nos permite monitorar o desempenho em várias esferas da aplicação, como por exemplo:  

- Uso de CPU;
- Uso de Memória;  
- Rendering;  
- Responsividade.  

Para utilizar basta usar o atalho ``Ctrl+7``, que abrirá a interface abaixo.  

![image](https://user-images.githubusercontent.com/107584167/186481709-20e061d1-8b10-4d50-b727-c6244965146b.png)  

Para selecionar a instância a se fazer o tracking é necessário selecionar no topo da tela, onde por exemplo se você tiver um celular conectado rodando a aplicação a ser profilada, poderá ter um monitoramento em tempo real pelo computador.  

![image](https://user-images.githubusercontent.com/107584167/186481709-20e061d1-8b10-4d50-b727-c6244965146b.png)  

Depois é só clicar no botão diretamente ao lado, que consiste de 2 círculos um sobre o outro (Símbolo de gravação) para monitorar a instância.  
Para ter mais detalhes sobre um frame em específico é necessário clicar em cima da região que quer se ter insights, e pausar a gravação (pois ela apaga o registro depois de 300 frames, que podem ser aumentados, com o custo de performance. [Para saber mais](https://docs.unity3d.com/Manual/ProfilerWindow.html)).  
Segue um exemplo de uma gravação onde se pegou um frame aleatório para trazer informações extras. Repare que na parte inferior aparece com mais detalhes de informação do frame (na figura da opção *Timeline* para baixo).  

![image](https://user-images.githubusercontent.com/107584167/186484833-1718e75a-7721-49a2-84b2-9a37c12527f8.png)

Uma anotação: O Semaphore.WaitForSignal não ocupa memória, nem causa queda de frames normalmente. Sua função é esperar o fim do frame para começar a trabalhar no próximo. Por isso ele pole levar "muito" tempo.

[Para mais informações no profiler em geral](https://docs.unity3d.com/Manual/Profiler.html)

## Profiler (Android)

Antes de pensar em profiler para profilar no Android, precisa-se dar nome ao pacote que esta sendo utilizando, pois será utilizado um comando para abrir o aplicativo com permissões extras que vai permitir ver o uso de CPU por método (deep profiling) que será implantada a nível de código. Antes, deve-se verificar se o que está abaixo está configurado certo (Scripting Backend = mono):

``Edit > Project Settings > Player > Android > Configuration > Scripting Backend = mono``

Agora para o nome, ``...Player > Identification > Package Name`` Devemos dar um nome seguindo um padrão:
``com.NomeDaCompanhia.NomeDoPRoduto``. O nome da companhia e o nome do produto se encontram no topo da pagina Player, por padrão o Unity define a companhia como DefaultCompany e o nome como o nome do Projeto.

Quando tudo estiver pronto, agora é necessário que se faça a build, e em seguida envie ela para o android
(um Build && Run deve fazer todo o processo automaticamente)
Mas deve-se fechar o aplicativo quando abrir, pois será reaberto pelo console do Logcat utilizando o prompt de comando.

## Como instalar o Logcat?

Para instalar o Log Cat (Extensão que salva Logs do Android em tempo real e traz outras utilidades como um console), ler: [https://docs.unity3d.com/Packages/com.unity.mobile.android-logcat@0.1/manual/index.html](https://docs.unity3d.com/Packages/com.unity.mobile.android-logcat@0.1/manual/index.html)

Mas em forma resumida, da para achar o Logcat no Package Manager.

No android Cat (Atalho: Alt+6) no canto superior direito clique em ``Tools > Open Terminal``
Lá deve ser inserido:
``adb shell am start -n {identificador da bundle -> com.NomeDaCompanhia.NomeDoProduto}/com.unity3d.player.UnityPlayerActivity -e 'unity' '-deepprofiling'``

Isso deve ser feito somente se for necessário deep profiling ([como descrito aqui](https://docs.unity3d.com/Manual/profiler-profiling-applications.html)).  

Claro, para que isto seja possível vai ser necessário colocar seu celular em modo desenvolvedor. Quando conectado via USB à maquina deve-se permitir acesso de arquivos e depuração (irá pedir automaticamente).  

Se tudo for feito corretamente esta deve ser a tela:

![image](https://user-images.githubusercontent.com/107584167/188675259-8802029b-a1ab-4834-a2cf-dd47706e21a3.png)  

## Monitorar trechos de código específicos

Para profilar trechos específicos deve-se ver: <https://docs.unity3d.com/ScriptReference/Unity.Profiling.ProfilerMarker.html>  

[Segue um código de exemplo](./IO_Controladora.cs)

Repare nas linhas: 6, 14, 15, 21, 64 a presença de linhas que dizem respeito ao profiler:  

``06: using Unity.Profiling;`` Inclui a biblioteca que possui as ferramentas necessárias para profilar
``14://Logcat:``  

  ``15: ProfilerMarker comecoOpen = new ProfilerMarker("Open CPU USAGE"); aqui está declarado um atributo da classe que pertence ao profiler. A string em parênteses é o nome do marcador do Profiler que será utilizado para identifica-lo junto aos outros processos da aplicação.``  
  
  ``21: comecoOpen.Begin(); define onde irá começar a coleta das amostras de dados durante o runtime da aplicação.``  
  
  ``64: comecoOpen.End(); define onde irá terminar a coleta das amostras de dados durante o runtime da aplicação.``  
  
  Todas as chamadas que acontecerem entre 21 e 64 serão capturadas pelo marcador de profiler (ProfilerMarker) e será mostrado nos logs da aplicação  

Lembre-se de iniciar pelo Logcat o processo utilizando ``adb shell am start -n {insert bundle identifier here}/com.unity3d.player.UnityPlayerActivity -e 'unity' '-deepprofiling'``:

 Precisa fechar totalmente o aplicativo, incluindo em segundo plano  

![image](https://user-images.githubusercontent.com/107584167/186498070-d22ca11c-4dc7-4f1c-ab19-2d89982c0cb6.png)  

O resultado:

![image](https://user-images.githubusercontent.com/107584167/186498991-281c820b-a4cf-4537-8dd6-162b7c11a0a6.png)  

Vale anotar que para profilar a aplicação no PC, deve-se clicar em "Deep profile" (perto do botão de gravação de atividade do profiler, à direita) e que não é possível fazer buscas com deep profiling ligado no pc, ou seja, se for nomeado um ProfilerMarker de "teste", e digitarmos "teste" na barra de busca, a Unity irá alertar: "Showing search results are disabled while recording with deep profiling. Stop recording to see search results". Então deve-se clicar no botão vermelho para parar a gravação de informação para poder ver os resultados da busca. E ao ligar novamente, os resultados ficarão impossibilitados de serem pesquisados  

## Categorias do profiler  

Também é possível atribuir categorias ao que está sendo profilado, como IA, Audio, entre outras opções. Para fazer isso é necessário fazer um overload no construtor do DeepProfiler, e atribuir uma classe antes do nome, como na imagem abaixo:  

![image](https://user-images.githubusercontent.com/107584167/188687421-7f14dafb-82ff-4591-a33f-75a3e84425c6.png)  

# Por que a responsividade?

Um problema que pode acontecer durante o processo de desenvolvimento de um app é que ao exportar, as diferentes configurações de tela podem trazer comportamentos atípicos como elementos movendo-se para fora da tela, ou sobrepondo-se uns sobre os outros.
Para isso temos duas soluções:

- Simulação de dispositivos
- Modo prévia de resolução

## Simulação de dispositivos

Existe um pacote no Unity chamado "Device Simulator" no Unity, que permite que seja emulado uma tela de celular no player (com resolução e limitações físicas, como câmeras). No entanto, até a data que isto está sendo escrito (08/09/22), este pacote está como prévia (incompleto). Então é necessário configurar antes o projeto para receber pacotes em prévia (este processo é necessário pois a premissa é que alguns pacotes em prévia  podem trazer impacto de performance, entre outros fatores)

Para fazer isso, é necessário seguir o seguinte caminho: ``Edit -> Project Settings -> Package Manager``.

![image](https://user-images.githubusercontent.com/107584167/189195128-c21ae7ee-9217-4a29-b978-cb7b12bc9d18.png)

Segundo o fórum oficial da Unity:  
Em *(A)* clique em "Enable Preview Packages", algo como "Ativar pacotes em prévia" em português.
Em *(B)* pode-se ver os pacotes em prévia em uso:

  1) Lista de pacotes em uso no escopo definido do projeto
  2) Detalhes da entidade selecionada

Agora é necessário ir ao package manager e buscar por Device Simulator. Para mais detalhes do funcionamento do Device Simulator, [ler](https://docs.unity3d.com/Packages/com.unity.device-simulator@3.0/manual/index.html). Para mais detalhes sobre pacotes em prévia, [ler](https://docs.unity3d.com/Manual/pack-preview.html).

Repare que existem limitações ao Device Simulator, além dos já citados na aba **"limitations"** (Limitações em portugês) na página do package. A principal para este texto é: Embora exista uma gama enorme de dispositivos para escolher, podem faltar a resolução de um dispositivo não listado. O que nos leva à segunda solução:

## Resoluções costumizadas

Para experimentar resoluções personalizadas, precisa-se antes saber qual é a resolução do dispositivo que se está querendo "simular". Para ajudar na escolha, segundo a [BrowserStack](https://www.browserstack.com/guide/ideal-screen-sizes-for-responsive-design), foi feita [uma busca das resoluções mais comuns para design responsivo](https://gs.statcounter.com/screen-resolution-stats/tablet/worldwide).

Com a resolução em mãos, é necessário ir até: ``Game preview -> Resolução -> "+"``:

![image](https://user-images.githubusercontent.com/107584167/189198110-1dd2a2a8-53ae-409d-905c-e3a046a8c0d2.png)

E então se preenche com os dados necessários:

![image](https://user-images.githubusercontent.com/107584167/189198337-d69dce26-7c0a-46fb-b3b5-beeced05b438.png)

Agora deve ficar disponível a resolução com o nome escolhido e suas características (Tab S4 para o exemplo)

![image](https://user-images.githubusercontent.com/107584167/189198577-1e0b27dc-0b69-4882-9ae5-bfdaab9c057d.png)

# Material sobre o Motor de Jogos Unity.  

A Quick Guide to Artificial Intelligence with Unity (FREE)  
<https://learntocreategames.com/display_book_info/?id=16&/>  
[QGT_AI_2017-09-04a_lr.pdf](_._/QGT_AI_2017-09-04a_lr.pdf)  

A Quick Guide to Card Games with Unity (FREE)  
<https://learntocreategames.com/display_book_info/?id=18&/>  
[qgt_cards_d.pdf](_._/qgt_cards_d.pdf)  

A Quick Guide to 2d Infinite Runners with Unity (FREE)  
<https://learntocreategames.com/display_book_info/?id=15&/>  
[qgt_infinite_2017-09-02a.pdf](_._/qgt_infinite_2017-09-02a.pdf)  

A Quick Guide to Procedural Levels with Unity (FREE)  
<https://learntocreategames.com/display_book_info/?id=13&/>  

A Quick Guide to C# with Unity (FREE)  
<https://learntocreategames.com/display_book_info/?id=12&/>  

A Quick Guide to 3D World and Vehicles with Unity 5 (FREE)  
<https://learntocreategames.com/display_book_info/?id=11&/>  

Becoming Comfortable with Unity (FREE)  
<https://learntocreategames.com/display_book_info/?id=9&/>  

## Unity_Grupo

### A Quick Guide to C# with Unity (FREE)

site: <https://learntocreategames.com/display_book_info/?id=12&/>  
<https://books.apple.com/br/book/a-quick-guide-to-c-with-unity/id1534232585?l=en-GB>  

Unity from Zero to proficiency (Foundations)

Ultimate Guide to 2D Games Development

### A Beginner's Guide to Puzzle Games

Páginas: 121  
Ano: 2020  
Valor: 34,90  
<https://books.apple.com/br/book/a-beginners-guide-to-puzzle-games/id1542093576?l=en-GB>  

### The Ultimate Guide to 2D games with Unity  

Páginas: 267  
Ano: 2020  
Valor: 54,90  
<https://books.apple.com/br/book/the-ultimate-guide-to-2d-games-with-unity/id1534663028?l=en-GB>  

### Unity from Zero to proficiency (Beginner)

Páginas: 249  
Ano: 2019  
Valor: 59,90  

### Unity from Zero to Proficiency (Foundations): a Step-by-step Guide to Creating your First Game

Páginas: 133  
Ano: 2019  
Valor: 37,90  
<https://books.apple.com/br/book/unity-from-zero-to-proficiency-foundations-a-step/id1111244554?l=en-GB>  

### Unity from Zero to proficiency (Intermediate)

Páginas: 353  
Ano: 2018  
Valor: 54,90  
<https://books.apple.com/br/book/unity-from-zero-to-proficiency-intermediate/id1534247439?l=en-GB>  

### Unity from Proficiency to Mastery (Artificial Intelligence)

Páginas: 142  
Ano: 2020  
Valor: 44,90  
<https://books.apple.com/br/book/unity-from-proficiency-to-mastery-artificial-intelligence/id1534217871?l=en-GB>  

### Unity from Zero to proficiency (Proficient)

Páginas: 184  
Ano: 2020  
Valor: 49,90  
<https://books.apple.com/br/book/unity-from-zero-to-proficiency-proficient/id1534207827?l=en-GB>  

### Unity from Zero to proficiency (Advanced)

Páginas: 220  
Ano: 2018  
Valor: 49,90  
<https://books.apple.com/br/book/unity-from-zero-to-proficiency-advanced/id1534207818?l=en-GB>  

### Unity from Proficiency to Mastery (C# Programming)

Páginas: 222  
Ano: 2020  
Valor: 42,90  
