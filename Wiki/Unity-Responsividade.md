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
