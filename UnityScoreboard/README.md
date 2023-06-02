# Scoreboard Unity Plugin

(links em um repositório privado/inexistente de outra organização)

Este repositório disponibiliza um asset desenvolvido com a **Unity 2018.4.4f1** para cadastrar pontuações de usuários e listar essas pontuações em um quadro de pontuações na UI. A imagem abaixo demonstra os elementos da UI contidos neste asset.

As imagens abaixo apresentam os componentes UI disponibilizados:

<p align="center">
  <img width="420" src="https://github.com/furbldtt/HOME/blob/main/UnityScoreboard/img/scoreboard01.png">
  <img width="420" src="https://github.com/furbldtt/HOME/blob/main/UnityScoreboard/img/scoreboard02.png">
</p>

Caso queira apenas baixar o package para importar no seu projeto, basta [clicar aqui](https://github.com/furbldtt/HOME/blob/main/UnityScoreboard/scoreboard-unity.unitypackage). O package já contém uma cena demonstrando um exemplo de uso do plugin.

O diagrama abaixo apresenta as classes e funcionalidades disponibilizadas pelo plugin:
<p align="center">
  <img src="https://github.com/furbldtt/HOME/blob/main/UnityScoreboard/img/scoreboard-unity.jpg">
</p>

No diagrama é possível observar que as pontuações não são persistidas em banco de dados ou em arquivos. Todas as pontuações ficam armazenadas em uma lista na memória, ou seja, quando a cena for reiniciada, todas as pontuações inseridas serão perdidas. Porém, neste mesmo repositório existe uma outra versão do mesmo projeto que utiliza a biblioteca [google-sheets-unity](https://github.com/furbldtt/HOME/tree/main/Unity_GSheets) para persistir a pontuação em uma planilha do GoogleDrive.
