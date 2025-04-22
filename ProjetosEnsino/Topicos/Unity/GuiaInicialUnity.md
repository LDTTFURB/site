# GUIA INICIAL PARA BOLSISTAS UNITY

Este guia foi criado para facilitar sua entrada em projetos existentes que utilizam Unity, fornecendo orientações essenciais sobre as ferramentas, normas e padrões adotados pelo LDTT. Aqui, você encontrará informações que vão te ajudar a entender melhor nosso fluxo de trabalho, organização de arquivos, convenções de nomenclatura e outras práticas fundamentais para garantir a eficiência e a qualidade dos nossos projetos.
Seja qual for o seu nível de experiência com Unity, este material servirá como um ponto de partida para que você se adapte rapidamente e possa contribuir da melhor forma possível. E lembre-se: sempre que surgir alguma dúvida, pergunte a um colega! Estamos todos aqui para desenvolver e aprender juntos, logo, a comunicação é muito importante para o funcionamento do laboratório.

## FERRAMENTAS UTILIZADAS

Para começar, é muito importante que você tenha acesso às ferramentas utilizadas nos projetos. <b>Caso você esteja utilizando uma máquina da Furb</b>, 
verifique se elas estão instaladas corretamente. Se estiver faltando alguma ferramenta ou você precisar instalar/atualizar algo que necessite de permissão de administrador, entre em contato com o professor Dalton ou outro professor responsável.


## UNITY

A <b>Unity</b> é o principal software utilizado para desenvolver jogos no nosso laboratório. Ela é um motor de jogos desenvolvido pela Unity Technologies, e oferece diversas ferramentas para <b>criar jogos 2D e 3D</b> para diferentes dispositivos, 
desde mobile até para óculos de realidade virtual. A principal linguagem utilizada no desenvolvimento de jogos pela Unity é o <b>C#</b>.
Você pode aprender um pouco mais sobre a Unity e suas aplicações [neste link](https://www.youtube.com/watch?v=pyw2HTsdkEQ)
Para utilizar a Unity, é necessário [criar uma conta na Unity ID](https://login.unity.com/en/sign-in) e [baixar o software Unity Hub](https://unity.com/pt/download), que serve como uma central para criar, gerenciar e abrir seus projetos. 
Também é necessário baixar uma versão da Unity para os projetos. Existem diferentes versões da Unity, cada uma com suas ferramentas e particularidades. 
Atualmente, utilizamos em nossos projetos uma das versões mais atuais, a <B>Unity 6</b>, lançada em 2024. Mais especificamente, utilizamos o patch <b>6000.29f1</b>. Caso sua máquina não o tenha, [você pode baixá-lo neste link](https://unity.com/releases/editor/whats-new/6000.0.29#installs).


## GIT E GITHUB

Outras ferramentas utilizadas em nossos projetos são o <b>Git</b> e o <b>GitHub</b>. Como desenvolvedor, você já deve conhecê-los, mas caso seja a primeira vez que ouve falar sobre algum deles, Git é um sistema de controle de versão de arquivos; em outras palavras, é responsável por guardar o histórico de alterações sempre que alguém modificar algum arquivo que está sendo monitorado por ele. Já o GitHub é um repositório remoto - como uma “rede social dev” - em que é possível armazenar e compartilhar projetos de desenvolvimento de software.[ Você pode entender um pouco melhor sobre eles nesse link](https://www.alura.com.br/artigos/o-que-e-git-github).
	Outra ferramenta muito utilizada pelos bolsistas do LDTT é o <b>GitHub Desktop</b>. Ele simplifica o uso do Git e GitHub, permitindo que os usuários utilizem as duas ferramentas de forma mais interativa e visual. Você pode [instalá-lo neste link](https://desktop.github.com/download/) e [aprender um pouco mais sobre ele por aqui](https://www.youtube.com/watch?v=y_3hJcw0dns).
	Todos os projetos desenvolvidos pelo LDTT são criados e mantidos na organização do LDTT no GitHub. Para ganhar acesso ao seu projeto, entre em contato com o professor Dalton e peça para ele adicioná-lo.
	[Aprenda um pouco de Git e GitHub aqui](https://www.youtube.com/watch?v=-l4Aa8wef8s)!


## IDE

As <b>IDEs</b> (“Integrated Development Environment” / “ambiente de desenvolvimento integrado”) são ferramentas de desenvolvimento para editar o código, acessar um terminal, executar um script , debugar e compilar usando um único ambiente, e são a principal ferramenta utilizadas pelos desenvolvedores.
Por padrão, a IDE utilizada pela Unity é o <b>Visual Studio</b>, criada pela Microsoft. Ao instalar uma versão da Unity, já será também instalada e configurada uma versão do Visual Studio em sua máquina. <b>Apesar de ser recomendado utilizá-la</b>, é possível utilizar outras IDEs de sua escolha que sejam compatíveis com o C# e a Unity, como o Visual Studio Code e o <i>JetBrains Rider</i>.


# TUTORIAIS UNITY

## Udemy
[Curso Unity 2D e 3D na Udemy](https://www.udemy.com/course/o-guia-definitivo-para-desenvolvimento-de-jogos-com-unity/learn/lecture/9232056#overview)

[Acesso à conta](../ChavesSenhas/README.md)

<i>Fazer da seção 1 até a 14</i> 

## Unity
[Curso Oficial da Unity Essentials](https://learn.unity.com/pathway/unity-essentials?language=br)

Acesse com sua conta Unity ID

<i>Não precisa fazer o capítulo Publishing Essentials (Só se quiser)</i>

# ACESSANDO E TRABALHANDO EM UM PROJETO

Devido ao escopo dos projetos e à rotatividade de bolsistas, é muito provável que você irá em algum momento se deparar com algum projeto que já está foi/está sendo trabalhado por outros bolsistas. Por esse motivo, é importante que alguns padrões sejam seguidos, para facilitar o trabalho cooperativo com seus colegas. Tanto nos repositórios quanto dentro dos projetos, algumas normas são seguidas, e serão apresentadas neste capítulo.


## GIT: Branches, Commits e Pull Requests

Ao entrar em um de nossos repositórios, perceberá que existem diversos branches criados. Por padrão, todos os projetos precisam ter 2 branches principais: <b>“main”</b> e <b>“develop”</b>. Por padrão, o branch “main” guarda a última versão estável do projeto. Já o branch “develop” guarda a última versão em desenvolvimento do projeto. Pense na branch “main” como a versão final de um jogo, ou uma versão “LTS” de um aplicativo. Já a “develop” pense como uma versão de testes/beta de um jogo, ou versão “Stable” de um aplicativo.
	Isso quer dizer que mesmo que a branch “develop” seja uma versão do projeto em desenvolvimento, não significa que ela possa ser mantida em mau estado ou com códigos que não funcionem. Logo, para criar/testar novas features ou arrumar bugs, é necessário criar uma nova branch para você poder trabalhar no projeto.
Essas novas branches podem ser criadas por você ou seus colegas, e sempre terão como base a “develop”. Por padrão, essas branches devem conter um nome, que pode ser a nova feature que irá testar/criar, seguida de “/” e o seu primeiro nome ou apelido, como pode ser visto nas imagens abaixo:

<img src="https://github.com/user-attachments/assets/cb34bbbd-5f26-4aff-b3a3-99cac20a79b8" width=30% height=auto> <img src="https://github.com/user-attachments/assets/d530b29c-7f89-455e-b537-4fbea853b1e6" width=34% height=auto>


Outro ponto importante para se atentar são os commits. Ao realizar um commit, seja claro no que foi alterado e publicado. Isso não só irá ajudar seus colegas a entender seu trabalho, como também pode ajudar a você mesmo na hora de publicar a branch via Pull Request (mais detalhes depois). É muito importante que as features criadas, mudanças realizadas e bugs arrumados sejam anotados para o controle do projeto. Também é interessante acrescentar no título dos commits <b>“fix/”</b> para commits de correção e <b>“feat/”</b> para commits de implementação para melhor compreensão do que foi feito.


![image](https://github.com/user-attachments/assets/75732f92-08cc-43d8-b072-8777f114f183) ![image](https://github.com/user-attachments/assets/2e55bfe8-e281-41f1-98d2-d546c1eeb70a)



Por último, mas não menos importante, Pull Requests. A ordem para os Pull Requests sempre será a seguinte: <b>SUA BRANCH -> develop -> main</b>. Logo, atente-se quando abrir um Pull Request, pois pode acontecer de ele abrir da sua branch para a “main”. Além disso, escreva nos comentários do seu Pull Request todas as mudanças feitas. Ele precisa ser um resumo de todos os seus commits. Não precisa ser muito específico e detalhado, mas tente englobar as principais mudanças realizadas.
	Após publicar o seu Pull Request, espere para um dos responsáveis do projeto analisar e aceitar o merge. Não saia dando merge, pois pode ocorrer algum conflito que precise ser arrumado. Seja paciente.


![image](https://github.com/user-attachments/assets/eaeab45e-2868-421d-9720-3e2fbc77fa33)

Após seu merge ser aceito, <b>crie uma nova branch</b> para continuar trabalhando no seu projeto. Caso preferir, você também pode dar “rebase” na sua branch com base na “develop”. Porém, é recomendado que crie uma nova branch, assim, você consegue separar os commits de cada feature adicionado ou mudanças feitas, e evitará mais facilmente conflitos de código.

## UNITY: Boas Práticas e Convenções

Dentro do projeto também seguimos algumas normas para padronização. [Este documento](https://docs.google.com/document/d/1GngSO6ZCpCthvPQP6ri8Rm5cNR_9k4ME3vWAX3B4tyk/edit?pli=1&tab=t.0) apresenta boas práticas e padrões seguidos nos nossos projetos Unity. 
[Já este documento](https://docs.google.com/document/d/1bncqkJJxBkCD1ro23AX1pr1rMplbuYwO8Ko27TO_kCI/edit?tab=t.0) apresenta a nomenclatura utilizada em arquivos, classes, funções e variáveis. 
<b>É de extrema importância ler, compreender e seguir essas convenções</b>, para facilitar a leitura e manutenção do código por outros desenvolvedores.
