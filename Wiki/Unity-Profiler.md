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
