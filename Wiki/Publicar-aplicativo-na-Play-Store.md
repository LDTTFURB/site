# Como publicar um app na Google Play Store  

## Conta de desenvolvedor do Play Console  

Antes de iniciar, é necessário ter uma conta Google de desenvolvedor para poder acessar o Google Play Console.

[Clique aqui para ver um passo a passo de como registrar uma conta de desenvolvedor do Google Play](https://support.google.com/googleplay/android-developer/answer/6112435?hl=pt-BR&ref_topic=3450769&sjid=5964308152178289480-SA#zippy=)  

## Criando o app na Google Play Console  

Ao entrar na página inicial do [Play Console](https://play.google.com/console), aperte em Create App.  

![criarApp](https://github.com/LDTTFURB/site/assets/126025055/5d26da61-6d84-4690-8610-844f27e2c2a1)  

Após ter clicado, você será redirecionado para uma página em que são necessárias algumas informações do seu aplicativo.  

![appDetails](https://github.com/LDTTFURB/site/assets/126025055/d307fca9-cd61-4504-abfc-75ce95e776c7)  

Depois disso, aceite os termos de declaração e vá para a próxima página. Assim, você terá pronto um rascunho do seu app. Para continuar, deve-se informar mais alguns detalhes sobre o seu aplicativo:  

<img src="https://github.com/LDTTFURB/site/assets/126025055/9e6929ec-c15c-4b28-8f28-2dcf3d552d0a" width=80% height=auto>  

## Criando a build do app na Unity  

No projeto do seu app na Unity, clique em **File -> Build Settings**:  

![image1](https://github.com/LDTTFURB/site/assets/126025055/de558281-db75-426b-8310-bb7def28779d)  

Mude a plataforma selecionada para Android, e então arraste todas as cenas que serão utilizadas no seu aplicativo para a área Scenes In Build:  

<img src="https://github.com/LDTTFURB/site/assets/126025055/185d5c9b-ab7d-44ae-9bed-ced72b42ceb6" width=80% height=auto>  

Depois disso aperte em **Player Settings**:  

<img src="https://github.com/LDTTFURB/site/assets/126025055/0f50ddd1-4d7c-426b-9d1c-61b5c6c5e115" width=80% height=auto>  

Após ter clicado, vá para a seção Other Settings e procure pela subseção Configuration. Quando estiver nela, faça as seguintes alterações:  

- Mude *Scripting Backend* de **Mono** para **IL2CPP**  
- Marque as opções **ARM65** e **Enable Armv9 Security Features for Arm64**.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/9813f214-9fd5-4e16-83e2-854a4acc6191" width=80% height=auto>  

Agora mude para a seção de Publishing Settings e aperte em **Keystore Manager** para criar uma chave de autenticação, ou se já possuir uma, preencha com o nome e senha.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/d0a76637-820b-4b0a-839c-499a824539f4" width=80% height=auto>  

<img src="https://github.com/LDTTFURB/site/assets/126025055/6c111504-dead-4965-8f26-5b3c2156fd0d" width=80% height=auto>  

Após isso volte para o menu de Build Settings e faça estas alterações:  

- Marque a opção **Build App Bundle (Google Play)**  
- Mude *Create symbols.zip* para **Public**  

Agora, por fim, pressione o botão de **Build**.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/99aa3e6c-0b05-4478-8a9f-8609e1beeb7d" width=80% height=auto>  

## Upload para teste interno  

Antes de publicar o seu aplicativo para produção, é importante distribuir rapidamente os builds para um pequeno grupo de testadores. Assim sendo, volte ao Play Console e clique na parte de **Internal Testing**.  

Para definir as pessoas que irão analisar seu app, vá na aba Testers e aperte em **Create email list** e adicione o email de cada membro do seu grupo selecionado.  

Na parte de How testers join your test, um link para que seus testadores possam baixar o seu aplicativo ficará disponível depois que você dar upload nos arquivos.  

![testers](https://github.com/LDTTFURB/site/assets/126025055/8b857d8a-9568-4609-a8b4-e1b64b410545)  

Para dar upload dos pacotes de seu app, clique em **Releases**, depois em **Create new release** e arraste o arquivo *.aab* para a seção App Bundles. Em seguida, aperte nos 3 pontinhos que estão do lado direito do arquivo que você acabou de dar upload, a seguir em **Upload native debug symbols(.zip)** e agora arraste o arquivo *.zip* para a janela.  

![appBundles](https://github.com/LDTTFURB/site/assets/126025055/431e473e-d014-4ca8-8a6e-c8f59fb75001)  

![tresPontinhos](https://github.com/LDTTFURB/site/assets/126025055/60b234de-9e2a-44d8-8c5f-d986492eee79)  

Após fazer isso, clique em **Start rollout to Internal Testing** e agora seu aplicativo poderá ser baixado na Play Store pelos seus testadores internos através daquele [link disponível](./Publicar-aplicativo-na-Play-Store#upload-para-teste-interno) *(imagem 1)* em How testers join your test.  

## Publicando o app na Google Play Store  

Para iniciar a produção do seu app, vá até a seção Production, clique em **Country/Region** e selecione os países em que seu aplicativo será publicado.  

Em seguida, aperte em **Releases**, depois em **Create new release** e você será redirecionado para uma [interface semelhante](./Publicar-aplicativo-na-Play-Store#upload-para-teste-interno) *(imagem 2)* a que foi utilizada no teste interno. Entretanto, como já foi feito o upload dos pacotes do app, aperte em **Add from library** e selecione o bundle que será postado.  

Por fim, clique em **Review release** e em **Start rollout to Production**. Agora é necessário esperar a equipe do Google validar o seu aplicativo. Após isso, o app estará imediatamente na Play Store.  


# Possíveis Erros da PlayStore
 A playstore testa os jogos antes deles irem para a loja e muitas vezes eles acham rejeitam o aplicativo por causa de algum erro no programa, caso isso ocorra eles mandam pelo e-mail qual erro ocorreu detalhadamente. Alguns erros encontrados:

## Issue found: Violation of Broken Functionality policy.
Este erro ocorre quando algum componente do jogo não esteja funcionando corretamente, normalmente quando um botão não tenha funcionalidade ou algum objeto não está responsivo.

![image](https://github.com/LDTTFURB/site/assets/83525918/bc1f61dc-faa0-41cb-bd87-55fddeebddde)


## Issue found: Violation of Misleading Claims policy.

Quando algo que estava na descrição não esta na versão final do jogo, tem que descrever precisamente tudo que está no jogo sem acrescentar nada e nem tirar nada.

![image](https://github.com/LDTTFURB/site/assets/83525918/5dec28be-9daa-414e-ba6f-d8f37ed53de6)


## Issue found: Invalid privacy policy
Erro de politica de privacidade inválida, o link da política de privacidade que atualmente é https://ldttfurb.github.io/site/temoCondicoesUso.

![image](https://github.com/LDTTFURB/site/assets/83525918/7f73d2ea-2e60-4ca8-8305-3859de5a9bad)

Precisa colocar o link em dois lugares diferentes o primeiro é no próprio Google Play Console siga a imagem: 

![image](https://github.com/LDTTFURB/site/assets/83525918/4feed284-b215-46b5-b3b4-9f442dabe96c)

Depois precisa inserir algum botão dentro do jogo se possível em algum menu ou lugar fácil de ver, comando na unity para abrir links: Application.OpenURL("https://ldttfurb.github.io/site/temoCondicoesUso");


## Issue found: Metadata
Ocorre quando eles a descrição do jogo, ícone ou fotos não estão 100% de acordo com o jogo final. Para resolver coloque se possível o máximo de fotos que mostram tudo do jogo/app, na descrição fale exatamente tudo que tem na versão sendo postada evite colocar coisa a mais e não deixe o texto muito abrangente, eles também podem falar que o ícone ou titulo são propagandas ou algum tipo de informação falsa, porém o que eles mais veem é se a descrição bate com o jogo e se está bem detalhada.

![image](https://github.com/LDTTFURB/site/assets/83525918/02ba989f-fd39-4cc4-86b8-c83f41013141)




