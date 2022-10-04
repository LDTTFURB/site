# Criar uma wiki

> Para propósitos práticos, vou desenvolver uma wiki “primitiva” para [meu repositório de Java swing.](https://github.com/ADalmolin3103/javax/wiki).  

Para criar uma wiki, vá até um repositório e clique em <img src="https://user-images.githubusercontent.com/78660963/173675597-0641c6e0-a778-498b-a774-c15d26041323.png" width = 60 height=auto>

![image](https://user-images.githubusercontent.com/78660963/173675719-8bfdd621-95e8-4b31-8151-18183f43aba8.png)

Clique em criar a primeira página. Após isso, você irá conceber uma página em branco com uma janela para o título, e outra para o conteúdo da página.

![image](https://user-images.githubusercontent.com/78660963/173675742-75294dbb-e5f8-4688-b0f4-6c2069adafc7.png)

A Wiki, de uma forma diferente do MD tradicional (do README por exemplo), possuí opções que facilitam o desenvolvimento de páginas, como inserir imagens, links, deixar o texto em negrito, itálico, entre outros. Após criar uma página e dar um commit, ela deverá aparecer na janela principal com outras opções, dessa forma:

![image](https://user-images.githubusercontent.com/78660963/173675776-2d4c1963-125e-445d-85b7-706820d5c721.png)

Após isso você terá uma página inicial para a introdução/resumo do projeto. Repare que o nome da página é Home, e isso é necessário para que esta página seja mostrada ao clicar em “Wiki”, da forma que uma wiki sem home será apresentada como uma lista de páginas. Qualquer página pode ser a home, basta renomear. Para renomear uma página, clique em editar, e depois reescreva o nome da página:

![image](https://user-images.githubusercontent.com/78660963/173675796-87befc9a-e847-45f7-b70d-cd92a2009f0c.png)

![image](https://user-images.githubusercontent.com/78660963/173675803-6077046b-16bf-44b5-b81e-bc0ff8ea9601.png)

O mesmo é válido para editar e reestruturar a página (editar conteúdo, adicionar imagens, links...).

## Novas páginas, organização de conteúdo, barra lateral e rodapé:

Agora, para adicionar outras páginas, só é necessário clicar em adicionar página, ao lado de editar, e adicionar novos conteúdos:

![image](https://user-images.githubusercontent.com/78660963/173675852-d36e3b99-599b-49d1-91fa-c22f0fd22968.png)

Após isso, deverá aparecer um navegador de página, que agrupa as páginas, e seus conteúdos por títulos (# a 6#), o que ajuda a organizar a corrente de conteúdo a ser mostrado.
Barras laterais são um elemento que pode ser adicionado, que irá ser renderizado ao lado direito da página, para adicionar, clique em “+Add custom sidebar” logo abaixo do navegador de página:

<img src="https://user-images.githubusercontent.com/78660963/173675877-8ab8991e-f3a6-4503-b49b-25e10ada3b02.png" width="300" height=auto>

<img src="https://user-images.githubusercontent.com/78660963/173675895-d91431e0-2504-4026-ac64-0d3a9e3eb1de.png" width="300" height=auto>

## Rodapé

Assim como as outras funcionalidades, para adicionar um rodapé, basta ir até o final da página, e clicar em “+Add a custom footer”. Após a página ser criada e editada, basta salvar que será mostrado:
![image](https://user-images.githubusercontent.com/78660963/173676042-0b8ea2f4-eb48-417f-978a-09567d971dde.png)

## Segurança, permissão de acesso e desativar wiki

Se em existe um projeto grande, não é produtivo que qualquer um consiga editar a página detalhando os recursos da wiki, com essa visão, é possível alterar o acesso. Por padrão, todos que estão como colaboradores do projeto tem esse poder, então para mudar deve-se dirigir até a página principal do repositório (não da wiki, mas do repositório), e configurar os colaboradores e seus recursos. 
Para desativar a wiki (digamos, por exemplo, temporariamente para atualização de código), ainda nas configurações do repositório, em geral, encontra-se a opção Wikis, onde se desativada, não será mais mostrada a wiki para o público geral
**A segunda opção é um perigo, pois caso desmarcado, o poder de edição não será limitado aos colaboradores, ao passo que qualquer um poderá editar a wiki.**

A wiki que fiz para demonstrar estes tópicos está disponível [aqui](https://github.com/ADalmolin3103/javax/wiki).
