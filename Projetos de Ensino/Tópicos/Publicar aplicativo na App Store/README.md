# Como publicar um app na App Store  

## Apple ID e conta de desenvolvedor da App Store  

Antes de tudo é necessário ter um Apple ID, para criar um [clique aqui](https://appleid.apple.com/account). Além disso deve-se ter uma [conta de desenvolvedor da App Store](https://developer.apple.com/).  

## Certificados, IDs e Profiles  

Para publicar seu app na App Store, é necessário fazer algumas certificações para que a Apple possa garantir a segurança da sua loja.  

### Certificado de Distribuição  

Esse certificado autentifica você como criador do software, ou seja, o seu nome ou da sua organização que aparecerá no campo de "Seller" na App Store.  

Em sua conta de desenvolvedor, vá em ![image](https://github.com/LDTTFURB/site/assets/126025055/e8c57c61-e32e-4476-868f-8c050fcd76ee) width = 100 height=auto>  

Em seguida clique em **Create a certificate**, selecione a opção *Apple Distribution* e aperte em **Continue**.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/c4a613e2-7a20-4e7a-ab86-0ec042a77860" width=90% height=auto>  

Agora para continuar, é preciso pedir uma Solicitação de Assinatura de Certificado (CSR). Para fazer isso, abra o Keychain Acess e pressione a aba **Keychain Access -> Certificate Assistant -> Request a Certificate From a Certificate Authority**.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/16ac917e-8a1f-4c64-bd93-69edd11c9898" width=90% height=auto>  

Na janela que abrir, faça as seguintes mudanças:  

- Em User Email Adress, digite o email utilizado para criar a conta de desenvolvedor da App Store  
- Em Common Name, coloque o nome da pessoa/organização que deve vir no CSR  
- Selecione a opção *Saved to Disk*  
- Clique em **Continue** e escolha onde deve ser salva a Solicitação de Assinatura de Certificado  

Voltando ao site, em Choose File, selecione o arquivo do CSR, aperte em **Continue** e depois em **Download** para baixar o Certificado de Distribuição.  

### Identificadores  

Agora é necessário criar um ID para o app. Volte para a página de Certificates, Identifiers & Profiles, clique em **Identifiers**, depois no botão com um "+", selecione *App IDs* e aperte em **Continue**.  

![identifiers](https://github.com/LDTTFURB/site/assets/126025055/eae45299-38c6-4cad-90f9-ec983ab02a1a)  

![appIDs](https://github.com/LDTTFURB/site/assets/126025055/056f7e99-6fb7-40db-a4b2-4bc260267a28)  

Na próxima página, selecione *App* e novamente clique em **Continue**.  

![appEappClip](https://github.com/LDTTFURB/site/assets/126025055/09cdd48a-ecc2-4eb2-8e27-810fdbea4887)  

O próximo passo é criar um identificador em Bundle ID, que será utilizado para identificar o app, e preencher o campo Description com uma pequena descrição. Depois disso, marque todos os serviços que seu aplicativo terá acesso e aperte em **Register**.  

![bundleID](https://github.com/LDTTFURB/site/assets/126025055/03916491-60cd-4ac8-9f26-627a8afd8d90)  

### Profile  

Depois de criar o Certificado de Distribuição e o ID do App, é preciso criar um Profile que irá conectar os dois. Novamente de volta à página de Certificates, Identifiers & Profiles, vá até **Profiles** e pressione o botão **Generate Profile**. Na próxima aba, na seção Distribution, selecione *App Store* e clique em **Continue**.  

![provisioningProfile](https://github.com/LDTTFURB/site/assets/126025055/31873f91-fcf4-46dc-9120-aa97024a2e8b)  

Em seguida, selecione o [ID do App](./Publicar-aplicativo-na-AppStore#identificadores) criado anteriormente e pressione **Continue**. Dessa vez, escolha o [Certificado de Distribuição](./Publicar-aplicativo-na-AppStore#certificado-de-distribuição) gerado antes e novamente clique em **Continue**.  

Para continuar, em Provisioning Profile Name, digite o nome do seu Profile, aperte em **Generate** e após isso pressione o botão de **Download** para baixar o profile que acabou de ser gerado.  

## Criar app na App Store Connect  

Mais uma vez na página inicial da sua conta de desenvolvedor, aperte em **App Store Connect** e depois em **Go to App Store Connect**.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/d88112d1-8884-4e0a-8379-e7d2ee031251" width=95% height=auto>  

Já na App Store Connect, aperte em **My Apps**, em seguida no botão com um "+" e por fim em **New App**.  

![newApp](https://github.com/LDTTFURB/site/assets/126025055/3f31465e-9170-4dff-938f-d1da9c609c18)  

A janela de criação de app que abrir deverá ser preenchida com as seguintes informações:  

- As plataformas que seu app ficará disponível  
- Nome do seu aplicativo  
- Idioma principal  
- [Bundle ID](./Publicar-aplicativo-na-AppStore#identificadores) que foi criado anteriormente  
- SKU, que é um ID que ficará dentro do sistema da Apple e não será visto por nenhum usuário
- Permissões que outras pessoas terão no seu app  

Por fim, aperte em **Create**.  

## Build e Upload para o App Store Connect  

No projeto do seu app na Unity, clique em **File -> Build Settings**.  

![image1](https://github.com/LDTTFURB/site/assets/126025055/de558281-db75-426b-8310-bb7def28779d)  

Mude a plataforma selecionada para iOS, arraste todas as cenas que serão utilizadas no seu aplicativo para a área Scenes In Build e então pressione o botão de **Build**.  

<img src="https://github.com/LDTTFURB/site/assets/126025055/3de94bea-29f7-4a13-a871-5743049a7a51" width=80% height=auto>  

Assim que a build estiver pronta, abra o arquivo *.xcodeproj* no [Xcode](https://developer.apple.com/xcode/), aperte no nome do projeto no canto superior esquerdo e depois em **Signing & Capabilities**.  

![xcode](https://github.com/LDTTFURB/site/assets/126025055/66315b65-32a4-4749-9de1-1e80a32fdb66)  

Em Signing & Capabilities, pressione o botão **Add Account** e entre com o seu Apple ID. Agora, é preciso instalar o [Certificado de Distribuição](./Publicar-aplicativo-na-AppStore#certificado-de-distribuição) criado anteriormente. Para fazer isso, basta clicar duas vezes no arquivo do certificado (o nome é *distribution.cer*) que ele será adicionado ao Keychain Access. Em seguida, desmarque a opção *Automatically manage signing* e em *Team*, selecione a sua recém adicionada conta de desenvolvedor da App Store. Já em *Provisioning Profile*, adicione o [Profile](./Publicar-aplicativo-na-AppStore#profile) feito alguns passos atrás e verifique se o ID é igual ao do Bundle Identifier.  

Agora para fazer a build no Xcode, clique em **Product -> Archive**:  

![buildXcode](https://github.com/LDTTFURB/site/assets/126025055/89304458-0861-400f-b3f4-51bddf6ba398)  

Quando o processo estiver concluído, na janela que abrir, clique em **Distribute App** e depois faça as seguintes alterações, apertando em **Next** no final de cada:  

1) Selecione a opção *App Store Connect*  
2) Na aba seguinte, para fazer o upload direto para a App Store Connect clique em **Upload**, caso queira fazer manualmente, pressione **Export**  
3) As duas próximas opções estão marcadas por padrão mas são opcionais, você pode escolher deixá-las marcadas ou não  
4) Selecione o [Profile](./Publicar-aplicativo-na-AppStore#profile) novamente  

Por fim, aperte em **Upload**.  

## Configurando Teste Interno  

Voltando para o site da App Store Connect, aperte em **TestFlight** e será possível ver a build que acabou de ser carregada. Entretanto algumas informações ainda estão faltando, por isso clique em **Manage**.  

![testFlight](https://github.com/LDTTFURB/site/assets/126025055/32359c7a-35fb-4ae1-8968-73f77bf88521)  

Na guia que abrir, algumas perguntas sobre criptografia e seu app devem ser respondidas. Por fim, aperte em **Start Internal Testing**.  

Depois disso, clique no número que estiver do lado do ícone do seu app.  

![numero](https://github.com/LDTTFURB/site/assets/126025055/66f83e6c-eb7e-4e20-8691-ba0476d8b1c4)  

Na aba de Internal Testing, é possível especificar o que deve ser testado e criar um grupo de testadores ou adicioná-los manualmente.  

![testingDetails](https://github.com/LDTTFURB/site/assets/126025055/1cab74d3-f245-45d8-b26a-370a67e45c8b)  

Depois de configurar o teste interno, clique em **Submitt for Review**. Após isso é necessário esperar que a solicitação seja aprovada e logo em seguida, será possível que os participantes do seu grupo de Internal Testing acessem o seu aplicativo.  

## Publicando o app na App Store Connect  

Pressione a aba **App Store** para voltar para a página inicial do aplicativo. Na seção Version Information, algumas fotos de tela para pré-visualização do seu app na loja devem ser enviadas, além de outras informações, como descrição, texto promocional, site de suporte, etc.  

![versionInformation](https://github.com/LDTTFURB/site/assets/126025055/651ee62d-f76c-40ca-a4e1-96a73669aef5)  

Rolando a página para baixo, na seção de Build, pressione o botão **Select a build before you submit your app** e selecione a build que deseja publicar.  

Nessa aba é possível ainda determinar se o app será publicado automaticamente ou manualmente, além de algumas outras configurações. Sinta-se livre para explorá-las e assim que estiver pronto clique em **Save** na parte superior da página.  

No lado direito, aperte em **App Information**.  

![appInformation](https://github.com/LDTTFURB/site/assets/126025055/757042db-5291-43b2-8fb6-a5a4211e65c7)  

Com a página aberta, em Content Rights deve-se responder sobre conteúdo de terceiros presente em seu aplicativo. Já em Age Rating, é necessário especificar a idade do público-alvo de seu app.  

Agora clique em **App Privacy** no menu lateral na esquerda. Em Privacy Policy URL, deve-se digitar o link da política de privacidade do seu aplicativo. Embaixo dessa seção, aperte em **Get Started** para responder um questionário sobre os dados que serão coletados durante o uso do seu app.  

Após fazer isso pressione o botão de **Prepare for Submission**, depois no de **Submit for Review** para enviar seu aplicativo para a revisão.  

![submitForReview](https://github.com/LDTTFURB/site/assets/126025055/7cec9db0-76c1-4ff1-aace-db1edafa52cc)  

De acordo com a Apple, 50% da submissões são processadas em 24 horas e 90% em 48 horas. Caso seja encontrada alguma falha, será necessário [repetir esse último processo](./Publicar-aplicativo-na-AppStore#publicando-o-app-na-app-store-connect) corrigindo os erros. Quando não houver mais defeitos, o app será publicado automaticamente, entretanto, se foi escolhida a publicação manual, deve-se entrar na App Store Connect e pressionar o botão **Release This Version**. Depois de publicado, o aplicativo pode levar até 24 horas para aparecer na App Store.  

## Vídeo completo  

[Clique aqui para ir para o vídeo usado como referência para este tutorial.](https://youtu.be/z4vX4JdIxv4)  
